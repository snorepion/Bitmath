using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MathNet.Numerics.Distributions;
using MathNet.Numerics.Random;

namespace bitmath
{
    public partial class TransformCreator : Form
    {
        Dictionary<Double[], Color[]> ColorMap = new Dictionary<Double[], Color[]>(); // Only one color is actually present in this array; however, to change the value of the color within a dictionary, it has to be an array.
        WeightType[,] wt = new WeightType[,] {
            { WeightType.Times, WeightType.Times, WeightType.Times },
            { WeightType.Times, WeightType.Times, WeightType.Times },
            { WeightType.Times, WeightType.Times, WeightType.Times }
        };
        Double[,] externalWeights = new Double[3, 3];
        Dictionary<TextBox, Point> Correspondence { get; set; }
        Point CurrentSelected = new Point(0, 0);
        RenderDisplay rd = new RenderDisplay(null);
        Voxel[,] Cur { get; set; }
        Type[] AllowableTypes =
        {
            typeof(ListBox),
            typeof(CheckBox),
            typeof(RadioButton),
            typeof(TextBox),
            typeof(ComboBox)
        };
        public TransformCreator() {
            InitializeComponent();
            Correspondence = new Dictionary<TextBox, Point>()
            {
                { TopLeftMultiplierTb, new Point(0, 0) },
                { TopCenterMultiplierTb, new Point(1, 0) },
                { TopRightMultiplierTb, new Point(2, 0) },
                { CenterLeftMultiplierTb, new Point(0, 1) },
                { CenterRightMultiplierTb, new Point(2, 1) },
                { BottomLeftMultiplierTb, new Point(0, 2) },
                { BottomCenterMultiplierTb, new Point(1, 2) },
                { BottomRightMultiplierTb, new Point(2, 2) }
            };
        }
        #region Voxel values section
        private void VoxelPossibleValuesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                LowerBoundTb.Text = ColorMap.Keys.ElementAt(VoxelPossibleValuesListBox.SelectedIndex)[0].ToString();
                UpperBoundTb.Text = ColorMap.Keys.ElementAt(VoxelPossibleValuesListBox.SelectedIndex)[1].ToString();
                ColorVisualizerBox.BackColor = ColorMap.Values.ElementAt(VoxelPossibleValuesListBox.SelectedIndex)[0];
            }
            catch { }
        }
        private void AddVoxelPossibleValueBtn_Click(object sender, EventArgs e)
        {
            ColorMap.Add(new double[] { -1, 1 }, new Color[] { Color.Black });
            VoxelPossibleValuesListBox.Items.Add("-1, 1 : Color[Black]");
        }
        private void RemoveVoxelPossibleValueBtn_Click(object sender, EventArgs e)
        {
            if (VoxelPossibleValuesListBox.Items.Count > 0)
            {
                ColorMap.Remove(ColorMap.Keys.ElementAt(VoxelPossibleValuesListBox.SelectedIndex));
                VoxelPossibleValuesListBox.Items.RemoveAt(VoxelPossibleValuesListBox.SelectedIndex);
            }
        }
        private void LowerBoundTb_TextChanged(object sender, EventArgs e)
        {
            if (VoxelPossibleValuesListBox.Items.Count > 0 && VoxelPossibleValuesListBox.SelectedIndex >= 0)
            {
                Double.TryParse(LowerBoundTb.Text, out ColorMap.Keys.ElementAt(VoxelPossibleValuesListBox.SelectedIndex)[0]);
                VoxelPossibleValuesListBox.Items[VoxelPossibleValuesListBox.SelectedIndex] = ColorMap.Keys.ElementAt(VoxelPossibleValuesListBox.SelectedIndex)[0].ToString() + ", " + ColorMap.Keys.ElementAt(VoxelPossibleValuesListBox.SelectedIndex)[1].ToString() + " : " + ColorMap.Values.ElementAt(VoxelPossibleValuesListBox.SelectedIndex)[0].ToString();
            }
        }
        private void UpperBoundTb_TextChanged(object sender, EventArgs e)
        {
            if (VoxelPossibleValuesListBox.Items.Count > 0 && VoxelPossibleValuesListBox.SelectedIndex >= 0)
            {
                Double.TryParse(UpperBoundTb.Text, out ColorMap.Keys.ElementAt(VoxelPossibleValuesListBox.SelectedIndex)[1]);
                VoxelPossibleValuesListBox.Items[VoxelPossibleValuesListBox.SelectedIndex] = ColorMap.Keys.ElementAt(VoxelPossibleValuesListBox.SelectedIndex)[0].ToString() + ", " + ColorMap.Keys.ElementAt(VoxelPossibleValuesListBox.SelectedIndex)[1].ToString() + " : " + ColorMap.Values.ElementAt(VoxelPossibleValuesListBox.SelectedIndex)[0].ToString();
            }
        }
        private void ColorVisualizerBox_Click(object sender, EventArgs e)
        {
            if (VoxelPossibleValuesListBox.Items.Count > 0 && VoxelPossibleValuesListBox.SelectedIndex >= 0)
            {
                ChangeColorDialog.Color = ColorVisualizerBox.BackColor;
                if (ChangeColorDialog.ShowDialog() == DialogResult.OK)
                {
                    ColorVisualizerBox.BackColor = ChangeColorDialog.Color;
                    ColorMap.Values.ElementAt(VoxelPossibleValuesListBox.SelectedIndex)[0] = ChangeColorDialog.Color;
                    VoxelPossibleValuesListBox.Items[VoxelPossibleValuesListBox.SelectedIndex] = ColorMap.Keys.ElementAt(VoxelPossibleValuesListBox.SelectedIndex)[0].ToString() + ", " + ColorMap.Keys.ElementAt(VoxelPossibleValuesListBox.SelectedIndex)[1].ToString() + " : " + ColorMap.Values.ElementAt(VoxelPossibleValuesListBox.SelectedIndex)[0].ToString();
                }
            }
        }
        #endregion
        #region Effects of other voxels
        private void MultiplierTb_Enter(object sender, EventArgs e)
        {
            Correspondence.TryGetValue(sender as TextBox, out Point p);
            CurrentSelected = p;
            switch (wt[p.X, p.Y])
            {
                case WeightType.Add:
                    AddRb.Checked = true;
                    break;
                case WeightType.Times:
                    MultiplyRb.Checked = true;
                    break;
                case WeightType.Exp:
                    ExpRb.Checked = true;
                    break;
            }
        }
        private void MultiplierTb_TextChanged(object sender, EventArgs e)
        {
            TextBox tb = sender as TextBox;
            Correspondence.TryGetValue(tb, out CurrentSelected);
            Double.TryParse(tb.Text, out externalWeights[CurrentSelected.X, CurrentSelected.Y]);
        }
        private void AddRb_CheckedChanged(object sender, EventArgs e)
        {
            if (AddRb.Checked) wt[CurrentSelected.X, CurrentSelected.Y] = WeightType.Add;
        }
        private void MultiplyRb_CheckedChanged(object sender, EventArgs e)
        {
            if (MultiplyRb.Checked) wt[CurrentSelected.X, CurrentSelected.Y] = WeightType.Times;
        }
        private void ExpRb_CheckedChanged(object sender, EventArgs e)
        {
            if (ExpRb.Checked) wt[CurrentSelected.X, CurrentSelected.Y] = WeightType.Exp;
        }
        #endregion
        #region Rendering
        private void CreateNew()
        {
            Size s = GetRenderSize();
            if (Double.TryParse(MeanTb.Text, out double m1) && Double.TryParse(StdDevTb.Text, out double m2) && Double.TryParse(DefaultToTb.Text, out double m3))
            {
                CryptoRandomSource r = new CryptoRandomSource();
                Normal n = new Normal(m1, m2);
                double[] samp = new double[s.Width * s.Height];
                n.Samples(samp);
                samp = samp.OrderBy(x => r.Next()).ToArray();
                Cur = Voxel.GenerateVoxels(s.Width, s.Height, samp, externalWeights, wt, GetChoiceType(), m2, ColorMap.Keys.Select(x => x[0]).ToArray(), m3);
            }
            else MessageBox.Show("Render failed: inappropriate text for weights.");
        }
        private void RenderCurrent()
        {
            Size s = GetRenderSize();
            if (s != new Size(0, 0))
            {
                rd.BmpToDisplay = Voxel.RenderAll(Cur, s.Width, s.Height, GetPixelFormat(), ColorMap);
                rd.Size = s;
                rd.ReloadImage();
            }
        }
        private Size GetRenderSize()
        {
            try
            {
                switch (VxCtCb.SelectedIndex)
                {
                    case 0:
                        return new Size(128, 128);
                    case 1:
                        return new Size(256, 256);
                    case 2:
                        return new Size(512, 512);
                    case 3:
                        return new Size(1024, 1024);
                    case 4:
                        return new Size(1920, 1280);
                    default:
                        string[] s = VxCtCb.Text.Split('x');
                        return new Size(Int32.Parse(s[0]), Int32.Parse(s[1]));
                }
            }
            catch
            {
                MessageBox.Show("Invalid size (should be formatted {Number}x{Number}, nothing else).");
                return new Size(0, 0);
            }
        }
        private PixelFormat GetPixelFormat()
        {
            switch (BmpPaletteCb.SelectedIndex)
            {
                case 0:
                    return PixelFormat.Format16bppArgb1555;
                case 1:
                    return PixelFormat.Format32bppArgb;
                default:
                    return PixelFormat.DontCare;
            }
        }
        private int GetChoiceType()
        {
            if (ProbabilisticChoiceRb.Checked) return 0;
            else return 1;
        }
        private int GetWeightType()
        {
            if (GaussRb.Checked) return 0;
            if (PoissonRb.Checked) return 1;
            if (ManualRb.Checked) return 2;
            return 0;
        }
        private void renderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateNew();
            RenderCurrent();
            rd.Show();
        }
        private void renderSilentlyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateNew();
        }
        private void displayRenderF10ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rd.Show();
        }
        private void rerenderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RenderCurrent();
            rd.Show();
        }
        private void rerenderSilentlyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RenderCurrent();
        }
        #endregion
        private void PoissonRb_CheckedChanged(object sender, EventArgs e)
        {
            if (PoissonRb.Checked) LambdaTb.ReadOnly = false;
            else LambdaTb.ReadOnly = true;
        }
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            this.InitializeComponent();
            externalWeights = new Double[3, 3];
            wt = new WeightType[,] {
            { WeightType.Times, WeightType.Times, WeightType.Times },
            { WeightType.Times, WeightType.Times, WeightType.Times },
            { WeightType.Times, WeightType.Times, WeightType.Times }
            };
            ColorMap = new Dictionary<Double[], Color[]>();
            CurrentSelected = new Point(0, 0);
            Cur = new Voxel[0, 0];
        }
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog()
            {
                Filter = "Bitmath profiles|*.bpf"
            };
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                DeserializeForm(ofd.FileName);
            }
        }
        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog() {
                Filter = "Bitmath profiles|*.bpf"
            };
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                SerializeForm(sfd.FileName);
            }
        }
        private void SerializeForm(string fn)
        {
            foreach (ListBox l in this.Descendants<ListBox>())
                ControlStateS.Tables["ListBoxes"].Rows.Add(l.Name, l.Items.Cast<Object>().ToArray());
            ControlStateS.Tables["ListBoxes"].AcceptChanges();
            foreach (ComboBox cb in this.Descendants<ComboBox>())
                ControlStateS.Tables["ComboBoxes"].Rows.Add(cb.Name, cb.SelectedIndex, cb.Text, cb.Enabled);
            ControlStateS.Tables["ComboBoxes"].AcceptChanges();
            foreach (CheckBox chb in this.Descendants<CheckBox>())
                ControlStateS.Tables["CheckBoxes"].Rows.Add(chb.Name, chb.Checked, chb.Enabled);
            ControlStateS.Tables["CheckBoxes"].AcceptChanges();
            foreach (RadioButton rb in this.Descendants<RadioButton>())
                ControlStateS.Tables["RadioButtons"].Rows.Add(rb.Name, rb.Checked, rb.Enabled);
            ControlStateS.Tables["RadioButtons"].AcceptChanges();
            foreach (TextBox tb in this.Descendants<TextBox>())
                ControlStateS.Tables["TextBoxes"].Rows.Add(tb.Name, tb.Text, tb.ReadOnly, tb.Enabled);
            ControlStateS.Tables["TextBoxes"].AcceptChanges();
            if (Cur != default(Voxel[,]))
            {
                foreach (Voxel v in Cur)
                    VoxelsS.Tables["VoxelData"].Rows.Add(v.Value, v.Weight, v.Position);
            }
            string statefn = Path.GetTempFileName();
            string voxfn = Path.GetTempFileName();
            ControlStateS.WriteXml(statefn);
            VoxelsS.WriteXml(voxfn);
            if (File.Exists(fn)) File.Delete(fn);
            CombineFiles(new[] { statefn, voxfn }, fn);
        }
        private void DeserializeForm(string fn)
        {
            string statefn = Path.GetTempFileName();
            string voxfn = Path.GetTempFileName();
            BreakUpFiles(new[] { statefn, voxfn }, fn);
            ControlStateS.ReadXml(statefn);
            foreach (DataRow d in ControlStateS.Tables["TextBoxes"].Rows)
                SetTextBoxProperties(Controls.Find(d["ControlNames"].ToString(), true)[0] as TextBox, d["Text"].ToString(), (bool)d["Enabled"], (bool)d["ReadOnly"]);
            foreach (DataRow d in ControlStateS.Tables["ComboBoxes"].Rows)
                SetComboBoxProperties(Controls.Find(d["ControlNames"].ToString(), true)[0] as ComboBox, (int)d["SelectedIndex"], d["Text"].ToString(), (bool)d["Enabled"]);
            foreach (DataRow d in ControlStateS.Tables["CheckBoxes"].Rows)
                SetCheckBoxProperties(Controls.Find(d["ControlNames"].ToString(), true)[0] as CheckBox, (bool)d["Checked"], (bool)d["Enabled"]);
            foreach (DataRow d in ControlStateS.Tables["RadioButtons"].Rows)
                SetRadioButtonProperties(Controls.Find(d["ControlNames"].ToString(), true)[0] as RadioButton, (bool)d["Checked"], (bool)d["Enabled"]);
            foreach (DataRow d in ControlStateS.Tables["ListBoxes"].Rows)
                SetListBoxProperties(Controls.Find(d["ControlNames"].ToString(), true)[0] as ListBox, (object[])d["Items"]);
            List<Voxel> VoxelsFromFile = new List<Voxel>();
            VoxelsS.ReadXml(voxfn);
            foreach (DataRow d in VoxelsS.Tables["VoxelData"].Rows)
                VoxelsFromFile.Add(new Voxel((double)d["W"], (double)d["Val"], ((Point)d["Pos"]).X, ((Point)d["Pos"]).Y));
            if (VoxelsFromFile.Count > 0)
            {
                Voxel final = VoxelsFromFile.Last();
                if (Cur == null) Cur = new Voxel[final.Position.X + 1, final.Position.Y + 1];
                foreach (Voxel v in VoxelsFromFile) Cur[v.Position.X, v.Position.Y] = v;
            }
        }
        private void CombineFiles(string[] Files, string OutputLocation)
        {
            StringBuilder sb = new StringBuilder();
            foreach (string s in Files)
            {
                sb.Append(File.ReadAllText(s));
                sb.Append("\r\n{EndFile}\r\n");
            }
            File.WriteAllText(OutputLocation, sb.ToString());
        }
        private void BreakUpFiles(string[] OutLoc, string source)
        {
            string Conts = File.ReadAllText(source);
            string[] NewFileContents = Conts.Split(new[] { "\r\n{EndFile}\r\n" }, StringSplitOptions.None);
            for (int i = 0; i < NewFileContents.Length - 1; i++)
            {
                File.WriteAllText(OutLoc[i], NewFileContents[i]);
            }
        }
        private void SetTextBoxProperties(TextBox tb, string Text, bool Enabled, bool ReadOnly)
        {
            tb.Text = Text;
            tb.Enabled = Enabled;
            tb.ReadOnly = ReadOnly;
        }
        private void SetComboBoxProperties(ComboBox cb, int SelectedIndex, string Text, bool Enabled)
        {
            cb.Text = Text;
            cb.Enabled = Enabled;
            cb.SelectedIndex = SelectedIndex;
        }
        private void SetCheckBoxProperties(CheckBox chb, bool Checked, bool Enabled)
        {
            chb.Checked = Checked;
            chb.Enabled = Enabled;
        }
        private void SetRadioButtonProperties(RadioButton rb, bool Checked, bool Enabled)
        {
            rb.Checked = Checked;
            rb.Enabled = Enabled;
        }
        private void SetListBoxProperties(ListBox lb, object[] items)
        {
            lb.Items.Clear();
            lb.Items.AddRange(items);
        }
    }
    public static class Extensions
    {
        public static IEnumerable<T> Descendants<T>(this Control control) where T : class
        {
            foreach (Control child in control.Controls)
            {
                T childOfT = child as T;
                if (childOfT != null)
                {
                    yield return (T)childOfT;
                }

                if (child.HasChildren)
                {
                    foreach (T descendant in Descendants<T>(child))
                    {
                        yield return descendant;
                    }
                }
            }
        }
    }
}
