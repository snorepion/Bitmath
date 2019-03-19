using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MathNet.Numerics;

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
        Double[,] externalWeights = new Double[2, 2];
        Point CurrentSelected = new Point(0, 0);
        RenderDisplay rd = new RenderDisplay(null);
        public TransformCreator() => InitializeComponent();
        #region Voxel values section
        private void VoxelPossibleValuesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            LowerBoundTb.Text = ColorMap.Keys.ElementAt(VoxelPossibleValuesListBox.SelectedIndex)[0].ToString();
            UpperBoundTb.Text = ColorMap.Keys.ElementAt(VoxelPossibleValuesListBox.SelectedIndex)[1].ToString();
            ColorVisualizerBox.BackColor = ColorMap.Values.ElementAt(VoxelPossibleValuesListBox.SelectedIndex)[0];
        }
        private void AddVoxelPossibleValueBtn_Click(object sender, EventArgs e)
        {
            ColorMap.Add(new double[] { -1, 1 }, new Color[] { Color.Black });
            VoxelPossibleValuesListBox.Items.Add("-1, 1");
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
            if (VoxelPossibleValuesListBox.Items.Count > 0)
                Double.TryParse(LowerBoundTb.Text, out ColorMap.Keys.ElementAt(VoxelPossibleValuesListBox.SelectedIndex)[0]);
        }
        private void UpperBoundTb_TextChanged(object sender, EventArgs e)
        {
            if (VoxelPossibleValuesListBox.Items.Count > 0)
                Double.TryParse(UpperBoundTb.Text, out ColorMap.Keys.ElementAt(VoxelPossibleValuesListBox.SelectedIndex)[1]);
        }
        private void ColorVisualizerBox_Click(object sender, EventArgs e)
        {
            if (VoxelPossibleValuesListBox.Items.Count > 0)
            {
                ChangeColorDialog.Color = ColorVisualizerBox.BackColor;
                if (ChangeColorDialog.ShowDialog() == DialogResult.OK)
                {
                    ColorVisualizerBox.BackColor = ChangeColorDialog.Color;
                    ColorMap.Values.ElementAt(VoxelPossibleValuesListBox.SelectedIndex)[0] = ChangeColorDialog.Color;
                }
            }
        }
        #endregion
        #region Effects of other voxels
        private void TopLeftMultiplierTb_TextChanged(object sender, EventArgs e)
        {
            CurrentSelected = new Point(0, 0);
            Double.TryParse(TopLeftMultiplierTb.Text, out externalWeights[0, 0]);
        }
        private void TopCenterMultiplierTb_TextChanged(object sender, EventArgs e)
        {
            CurrentSelected = new Point(1, 0);
            Double.TryParse(TopLeftMultiplierTb.Text, out externalWeights[1, 0]);
        }
        private void TopRightMultiplierTb_TextChanged(object sender, EventArgs e)
        {
            CurrentSelected = new Point(2, 0);
            Double.TryParse(TopLeftMultiplierTb.Text, out externalWeights[2, 0]);
        }
        private void CenterLeftMultiplierTb_TextChanged(object sender, EventArgs e)
        {
            CurrentSelected = new Point(0, 1);
            Double.TryParse(TopLeftMultiplierTb.Text, out externalWeights[0, 1]);
        }
        private void CenterRightMultiplierTb_TextChanged(object sender, EventArgs e)
        {
            CurrentSelected = new Point(2, 1);
            Double.TryParse(TopLeftMultiplierTb.Text, out externalWeights[2, 1]);
        }
        private void BottomLeftMultiplierTb_TextChanged(object sender, EventArgs e)
        {
            CurrentSelected = new Point(0, 2);
            Double.TryParse(TopLeftMultiplierTb.Text, out externalWeights[0, 2]);
        }
        private void BottomCenterMultiplierTb_TextChanged(object sender, EventArgs e)
        {
            CurrentSelected = new Point(1, 2);
            Double.TryParse(TopLeftMultiplierTb.Text, out externalWeights[1, 2]);
        }
        private void BottomRightMultiplierTb_TextChanged(object sender, EventArgs e)
        {
            CurrentSelected = new Point(2, 2);
            Double.TryParse(TopLeftMultiplierTb.Text, out externalWeights[2, 2]);
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
    }
}
