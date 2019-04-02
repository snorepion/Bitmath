using System;
using System.Runtime.Serialization;
using System.Windows.Forms;

namespace bitmath
{
    partial class TransformCreator
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ExpRb = new System.Windows.Forms.RadioButton();
            this.MultiplyRb = new System.Windows.Forms.RadioButton();
            this.AddRb = new System.Windows.Forms.RadioButton();
            this.CenterMuliplierTb = new System.Windows.Forms.TextBox();
            this.CenterRightMultiplierTb = new System.Windows.Forms.TextBox();
            this.BottomRightMultiplierTb = new System.Windows.Forms.TextBox();
            this.BottomCenterMultiplierTb = new System.Windows.Forms.TextBox();
            this.BottomLeftMultiplierTb = new System.Windows.Forms.TextBox();
            this.CenterLeftMultiplierTb = new System.Windows.Forms.TextBox();
            this.TopRightMultiplierTb = new System.Windows.Forms.TextBox();
            this.TopCenterMultiplierTb = new System.Windows.Forms.TextBox();
            this.TopLeftMultiplierTb = new System.Windows.Forms.TextBox();
            this.ColorVisualizerBoxOn = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ManualEditBtn = new System.Windows.Forms.Button();
            this.ManualRb = new System.Windows.Forms.RadioButton();
            this.PoissonRb = new System.Windows.Forms.RadioButton();
            this.GaussRb = new System.Windows.Forms.RadioButton();
            this.StdDevTb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.MeanTb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.CustomAnimateChb = new System.Windows.Forms.CheckBox();
            this.AnimationEditorBtn = new System.Windows.Forms.Button();
            this.frameCtTb = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.GifCb = new System.Windows.Forms.CheckBox();
            this.SelectBatchOutputDirectoryBtn = new System.Windows.Forms.Button();
            this.BatchOutputTb = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.EnableBatchModeChb = new System.Windows.Forms.CheckBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.FpsTb = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.LambdaTb = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.BmpPaletteCb = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.VxCtCb = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.ColorVisualizerBoxOff = new System.Windows.Forms.Panel();
            this.DefaultToTb = new System.Windows.Forms.TextBox();
            this.DefaultRb = new System.Windows.Forms.RadioButton();
            this.ProbabilisticChoiceRb = new System.Windows.Forms.RadioButton();
            this.MainMenu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.renderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.renderSilentlyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.displayRenderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rerenderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rerenderSilentlyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.applyTransformToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ChangeColorDialog = new System.Windows.Forms.ColorDialog();
            this.VoxelsS = new bitmath.Voxels();
            this.ControlStateSource = new System.Windows.Forms.BindingSource(this.components);
            this.ControlStateS = new bitmath.ControlState();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.MainMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VoxelsS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ControlStateSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ControlStateS)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ExpRb);
            this.groupBox1.Controls.Add(this.MultiplyRb);
            this.groupBox1.Controls.Add(this.AddRb);
            this.groupBox1.Controls.Add(this.CenterMuliplierTb);
            this.groupBox1.Controls.Add(this.CenterRightMultiplierTb);
            this.groupBox1.Controls.Add(this.BottomRightMultiplierTb);
            this.groupBox1.Controls.Add(this.BottomCenterMultiplierTb);
            this.groupBox1.Controls.Add(this.BottomLeftMultiplierTb);
            this.groupBox1.Controls.Add(this.CenterLeftMultiplierTb);
            this.groupBox1.Controls.Add(this.TopRightMultiplierTb);
            this.groupBox1.Controls.Add(this.TopCenterMultiplierTb);
            this.groupBox1.Controls.Add(this.TopLeftMultiplierTb);
            this.groupBox1.Location = new System.Drawing.Point(399, 33);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(194, 140);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Effect of other voxels";
            // 
            // ExpRb
            // 
            this.ExpRb.AutoSize = true;
            this.ExpRb.Location = new System.Drawing.Point(132, 116);
            this.ExpRb.Margin = new System.Windows.Forms.Padding(4);
            this.ExpRb.Name = "ExpRb";
            this.ExpRb.Size = new System.Drawing.Size(36, 21);
            this.ExpRb.TabIndex = 11;
            this.ExpRb.Text = "^";
            this.ExpRb.UseVisualStyleBackColor = true;
            this.ExpRb.CheckedChanged += new System.EventHandler(this.ExpRb_CheckedChanged);
            // 
            // MultiplyRb
            // 
            this.MultiplyRb.AutoSize = true;
            this.MultiplyRb.Checked = true;
            this.MultiplyRb.Location = new System.Drawing.Point(70, 116);
            this.MultiplyRb.Margin = new System.Windows.Forms.Padding(4);
            this.MultiplyRb.Name = "MultiplyRb";
            this.MultiplyRb.Size = new System.Drawing.Size(34, 21);
            this.MultiplyRb.TabIndex = 10;
            this.MultiplyRb.TabStop = true;
            this.MultiplyRb.Text = "*";
            this.MultiplyRb.UseVisualStyleBackColor = true;
            this.MultiplyRb.CheckedChanged += new System.EventHandler(this.MultiplyRb_CheckedChanged);
            // 
            // AddRb
            // 
            this.AddRb.AutoSize = true;
            this.AddRb.Location = new System.Drawing.Point(8, 116);
            this.AddRb.Margin = new System.Windows.Forms.Padding(4);
            this.AddRb.Name = "AddRb";
            this.AddRb.Size = new System.Drawing.Size(37, 21);
            this.AddRb.TabIndex = 9;
            this.AddRb.Text = "+";
            this.AddRb.UseVisualStyleBackColor = true;
            this.AddRb.CheckedChanged += new System.EventHandler(this.AddRb_CheckedChanged);
            // 
            // CenterMuliplierTb
            // 
            this.CenterMuliplierTb.Location = new System.Drawing.Point(70, 56);
            this.CenterMuliplierTb.Margin = new System.Windows.Forms.Padding(4);
            this.CenterMuliplierTb.Name = "CenterMuliplierTb";
            this.CenterMuliplierTb.ReadOnly = true;
            this.CenterMuliplierTb.Size = new System.Drawing.Size(54, 22);
            this.CenterMuliplierTb.TabIndex = 8;
            this.CenterMuliplierTb.Text = "Base";
            this.CenterMuliplierTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CenterRightMultiplierTb
            // 
            this.CenterRightMultiplierTb.Location = new System.Drawing.Point(132, 56);
            this.CenterRightMultiplierTb.Margin = new System.Windows.Forms.Padding(4);
            this.CenterRightMultiplierTb.Name = "CenterRightMultiplierTb";
            this.CenterRightMultiplierTb.Size = new System.Drawing.Size(54, 22);
            this.CenterRightMultiplierTb.TabIndex = 7;
            this.CenterRightMultiplierTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CenterRightMultiplierTb.TextChanged += new System.EventHandler(this.MultiplierTb_TextChanged);
            this.CenterRightMultiplierTb.Enter += new System.EventHandler(this.MultiplierTb_Enter);
            // 
            // BottomRightMultiplierTb
            // 
            this.BottomRightMultiplierTb.Location = new System.Drawing.Point(132, 87);
            this.BottomRightMultiplierTb.Margin = new System.Windows.Forms.Padding(4);
            this.BottomRightMultiplierTb.Name = "BottomRightMultiplierTb";
            this.BottomRightMultiplierTb.Size = new System.Drawing.Size(54, 22);
            this.BottomRightMultiplierTb.TabIndex = 6;
            this.BottomRightMultiplierTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.BottomRightMultiplierTb.TextChanged += new System.EventHandler(this.MultiplierTb_TextChanged);
            this.BottomRightMultiplierTb.Enter += new System.EventHandler(this.MultiplierTb_Enter);
            // 
            // BottomCenterMultiplierTb
            // 
            this.BottomCenterMultiplierTb.Location = new System.Drawing.Point(70, 87);
            this.BottomCenterMultiplierTb.Margin = new System.Windows.Forms.Padding(4);
            this.BottomCenterMultiplierTb.Name = "BottomCenterMultiplierTb";
            this.BottomCenterMultiplierTb.Size = new System.Drawing.Size(54, 22);
            this.BottomCenterMultiplierTb.TabIndex = 5;
            this.BottomCenterMultiplierTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.BottomCenterMultiplierTb.TextChanged += new System.EventHandler(this.MultiplierTb_TextChanged);
            this.BottomCenterMultiplierTb.Enter += new System.EventHandler(this.MultiplierTb_Enter);
            // 
            // BottomLeftMultiplierTb
            // 
            this.BottomLeftMultiplierTb.Location = new System.Drawing.Point(8, 87);
            this.BottomLeftMultiplierTb.Margin = new System.Windows.Forms.Padding(4);
            this.BottomLeftMultiplierTb.Name = "BottomLeftMultiplierTb";
            this.BottomLeftMultiplierTb.Size = new System.Drawing.Size(54, 22);
            this.BottomLeftMultiplierTb.TabIndex = 4;
            this.BottomLeftMultiplierTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.BottomLeftMultiplierTb.TextChanged += new System.EventHandler(this.MultiplierTb_TextChanged);
            this.BottomLeftMultiplierTb.Enter += new System.EventHandler(this.MultiplierTb_Enter);
            // 
            // CenterLeftMultiplierTb
            // 
            this.CenterLeftMultiplierTb.Location = new System.Drawing.Point(8, 56);
            this.CenterLeftMultiplierTb.Margin = new System.Windows.Forms.Padding(4);
            this.CenterLeftMultiplierTb.Name = "CenterLeftMultiplierTb";
            this.CenterLeftMultiplierTb.Size = new System.Drawing.Size(54, 22);
            this.CenterLeftMultiplierTb.TabIndex = 3;
            this.CenterLeftMultiplierTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CenterLeftMultiplierTb.TextChanged += new System.EventHandler(this.MultiplierTb_TextChanged);
            this.CenterLeftMultiplierTb.Enter += new System.EventHandler(this.MultiplierTb_Enter);
            // 
            // TopRightMultiplierTb
            // 
            this.TopRightMultiplierTb.Location = new System.Drawing.Point(132, 23);
            this.TopRightMultiplierTb.Margin = new System.Windows.Forms.Padding(4);
            this.TopRightMultiplierTb.Name = "TopRightMultiplierTb";
            this.TopRightMultiplierTb.Size = new System.Drawing.Size(54, 22);
            this.TopRightMultiplierTb.TabIndex = 2;
            this.TopRightMultiplierTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TopRightMultiplierTb.TextChanged += new System.EventHandler(this.MultiplierTb_TextChanged);
            this.TopRightMultiplierTb.Enter += new System.EventHandler(this.MultiplierTb_Enter);
            // 
            // TopCenterMultiplierTb
            // 
            this.TopCenterMultiplierTb.Location = new System.Drawing.Point(70, 23);
            this.TopCenterMultiplierTb.Margin = new System.Windows.Forms.Padding(4);
            this.TopCenterMultiplierTb.Name = "TopCenterMultiplierTb";
            this.TopCenterMultiplierTb.Size = new System.Drawing.Size(54, 22);
            this.TopCenterMultiplierTb.TabIndex = 1;
            this.TopCenterMultiplierTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TopCenterMultiplierTb.TextChanged += new System.EventHandler(this.MultiplierTb_TextChanged);
            this.TopCenterMultiplierTb.Enter += new System.EventHandler(this.MultiplierTb_Enter);
            // 
            // TopLeftMultiplierTb
            // 
            this.TopLeftMultiplierTb.Location = new System.Drawing.Point(8, 23);
            this.TopLeftMultiplierTb.Margin = new System.Windows.Forms.Padding(4);
            this.TopLeftMultiplierTb.Name = "TopLeftMultiplierTb";
            this.TopLeftMultiplierTb.Size = new System.Drawing.Size(54, 22);
            this.TopLeftMultiplierTb.TabIndex = 0;
            this.TopLeftMultiplierTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TopLeftMultiplierTb.TextChanged += new System.EventHandler(this.MultiplierTb_TextChanged);
            this.TopLeftMultiplierTb.Enter += new System.EventHandler(this.MultiplierTb_Enter);
            // 
            // ColorVisualizerBoxOn
            // 
            this.ColorVisualizerBoxOn.BackColor = System.Drawing.Color.White;
            this.ColorVisualizerBoxOn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ColorVisualizerBoxOn.Location = new System.Drawing.Point(85, 78);
            this.ColorVisualizerBoxOn.Margin = new System.Windows.Forms.Padding(4);
            this.ColorVisualizerBoxOn.Name = "ColorVisualizerBoxOn";
            this.ColorVisualizerBoxOn.Size = new System.Drawing.Size(71, 20);
            this.ColorVisualizerBoxOn.TabIndex = 5;
            this.ColorVisualizerBoxOn.Click += new System.EventHandler(this.ColorVisualizerBoxOn_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.ManualEditBtn);
            this.groupBox3.Controls.Add(this.ManualRb);
            this.groupBox3.Controls.Add(this.PoissonRb);
            this.groupBox3.Controls.Add(this.GaussRb);
            this.groupBox3.Controls.Add(this.StdDevTb);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.MeanTb);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Location = new System.Drawing.Point(186, 33);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(200, 140);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Weights";
            // 
            // ManualEditBtn
            // 
            this.ManualEditBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.ManualEditBtn.Location = new System.Drawing.Point(95, 108);
            this.ManualEditBtn.Margin = new System.Windows.Forms.Padding(4);
            this.ManualEditBtn.Name = "ManualEditBtn";
            this.ManualEditBtn.Size = new System.Drawing.Size(100, 25);
            this.ManualEditBtn.TabIndex = 18;
            this.ManualEditBtn.Text = "Edit";
            this.ManualEditBtn.UseVisualStyleBackColor = true;
            // 
            // ManualRb
            // 
            this.ManualRb.AutoSize = true;
            this.ManualRb.Location = new System.Drawing.Point(12, 110);
            this.ManualRb.Margin = new System.Windows.Forms.Padding(4);
            this.ManualRb.Name = "ManualRb";
            this.ManualRb.Size = new System.Drawing.Size(75, 21);
            this.ManualRb.TabIndex = 17;
            this.ManualRb.Text = "Manual";
            this.ManualRb.UseVisualStyleBackColor = true;
            // 
            // PoissonRb
            // 
            this.PoissonRb.AutoSize = true;
            this.PoissonRb.Location = new System.Drawing.Point(112, 87);
            this.PoissonRb.Margin = new System.Windows.Forms.Padding(4);
            this.PoissonRb.Name = "PoissonRb";
            this.PoissonRb.Size = new System.Drawing.Size(79, 21);
            this.PoissonRb.TabIndex = 16;
            this.PoissonRb.Text = "Poisson";
            this.PoissonRb.UseVisualStyleBackColor = true;
            this.PoissonRb.CheckedChanged += new System.EventHandler(this.PoissonRb_CheckedChanged);
            // 
            // GaussRb
            // 
            this.GaussRb.AutoSize = true;
            this.GaussRb.Checked = true;
            this.GaussRb.Location = new System.Drawing.Point(12, 87);
            this.GaussRb.Margin = new System.Windows.Forms.Padding(4);
            this.GaussRb.Name = "GaussRb";
            this.GaussRb.Size = new System.Drawing.Size(89, 21);
            this.GaussRb.TabIndex = 15;
            this.GaussRb.TabStop = true;
            this.GaussRb.Text = "Gaussian";
            this.GaussRb.UseVisualStyleBackColor = true;
            // 
            // StdDevTb
            // 
            this.StdDevTb.Location = new System.Drawing.Point(59, 56);
            this.StdDevTb.Margin = new System.Windows.Forms.Padding(4);
            this.StdDevTb.Name = "StdDevTb";
            this.StdDevTb.Size = new System.Drawing.Size(132, 22);
            this.StdDevTb.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 59);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "Stdev";
            // 
            // MeanTb
            // 
            this.MeanTb.Location = new System.Drawing.Point(59, 24);
            this.MeanTb.Margin = new System.Windows.Forms.Padding(4);
            this.MeanTb.Name = "MeanTb";
            this.MeanTb.Size = new System.Drawing.Size(132, 22);
            this.MeanTb.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 27);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mean";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.groupBox6);
            this.groupBox4.Controls.Add(this.groupBox5);
            this.groupBox4.Location = new System.Drawing.Point(16, 186);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox4.Size = new System.Drawing.Size(577, 185);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Render settings";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.CustomAnimateChb);
            this.groupBox6.Controls.Add(this.AnimationEditorBtn);
            this.groupBox6.Controls.Add(this.frameCtTb);
            this.groupBox6.Controls.Add(this.label7);
            this.groupBox6.Controls.Add(this.GifCb);
            this.groupBox6.Controls.Add(this.SelectBatchOutputDirectoryBtn);
            this.groupBox6.Controls.Add(this.BatchOutputTb);
            this.groupBox6.Controls.Add(this.label6);
            this.groupBox6.Controls.Add(this.EnableBatchModeChb);
            this.groupBox6.Location = new System.Drawing.Point(285, 25);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox6.Size = new System.Drawing.Size(284, 153);
            this.groupBox6.TabIndex = 1;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Batch mode";
            // 
            // CustomAnimateChb
            // 
            this.CustomAnimateChb.AutoSize = true;
            this.CustomAnimateChb.Enabled = false;
            this.CustomAnimateChb.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.CustomAnimateChb.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.CustomAnimateChb.Location = new System.Drawing.Point(8, 112);
            this.CustomAnimateChb.Margin = new System.Windows.Forms.Padding(4);
            this.CustomAnimateChb.Name = "CustomAnimateChb";
            this.CustomAnimateChb.Size = new System.Drawing.Size(142, 21);
            this.CustomAnimateChb.TabIndex = 8;
            this.CustomAnimateChb.Text = "Custom animation";
            this.CustomAnimateChb.UseVisualStyleBackColor = true;
            // 
            // AnimationEditorBtn
            // 
            this.AnimationEditorBtn.Enabled = false;
            this.AnimationEditorBtn.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.AnimationEditorBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AnimationEditorBtn.ForeColor = System.Drawing.Color.DarkGray;
            this.AnimationEditorBtn.Location = new System.Drawing.Point(153, 105);
            this.AnimationEditorBtn.Margin = new System.Windows.Forms.Padding(4);
            this.AnimationEditorBtn.Name = "AnimationEditorBtn";
            this.AnimationEditorBtn.Size = new System.Drawing.Size(128, 30);
            this.AnimationEditorBtn.TabIndex = 7;
            this.AnimationEditorBtn.Text = "Animation Editor";
            this.AnimationEditorBtn.UseVisualStyleBackColor = true;
            // 
            // frameCtTb
            // 
            this.frameCtTb.Enabled = false;
            this.frameCtTb.Location = new System.Drawing.Point(132, 71);
            this.frameCtTb.Margin = new System.Windows.Forms.Padding(4);
            this.frameCtTb.Name = "frameCtTb";
            this.frameCtTb.ReadOnly = true;
            this.frameCtTb.Size = new System.Drawing.Size(147, 22);
            this.frameCtTb.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 75);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(121, 17);
            this.label7.TabIndex = 5;
            this.label7.Text = "Number of frames";
            // 
            // GifCb
            // 
            this.GifCb.AutoCheck = false;
            this.GifCb.AutoSize = true;
            this.GifCb.BackColor = System.Drawing.Color.Transparent;
            this.GifCb.Enabled = false;
            this.GifCb.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.GifCb.FlatAppearance.BorderSize = 0;
            this.GifCb.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.GifCb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GifCb.Location = new System.Drawing.Point(173, 18);
            this.GifCb.Margin = new System.Windows.Forms.Padding(4);
            this.GifCb.Name = "GifCb";
            this.GifCb.Size = new System.Drawing.Size(48, 21);
            this.GifCb.TabIndex = 4;
            this.GifCb.Text = "GIF";
            this.GifCb.UseVisualStyleBackColor = false;
            // 
            // SelectBatchOutputDirectoryBtn
            // 
            this.SelectBatchOutputDirectoryBtn.BackColor = System.Drawing.SystemColors.Control;
            this.SelectBatchOutputDirectoryBtn.Enabled = false;
            this.SelectBatchOutputDirectoryBtn.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.SelectBatchOutputDirectoryBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SelectBatchOutputDirectoryBtn.ForeColor = System.Drawing.Color.DarkGray;
            this.SelectBatchOutputDirectoryBtn.Location = new System.Drawing.Point(229, 37);
            this.SelectBatchOutputDirectoryBtn.Margin = new System.Windows.Forms.Padding(4);
            this.SelectBatchOutputDirectoryBtn.Name = "SelectBatchOutputDirectoryBtn";
            this.SelectBatchOutputDirectoryBtn.Size = new System.Drawing.Size(47, 28);
            this.SelectBatchOutputDirectoryBtn.TabIndex = 3;
            this.SelectBatchOutputDirectoryBtn.Text = "...";
            this.SelectBatchOutputDirectoryBtn.UseVisualStyleBackColor = false;
            // 
            // BatchOutputTb
            // 
            this.BatchOutputTb.Enabled = false;
            this.BatchOutputTb.Location = new System.Drawing.Point(68, 39);
            this.BatchOutputTb.Margin = new System.Windows.Forms.Padding(4);
            this.BatchOutputTb.Name = "BatchOutputTb";
            this.BatchOutputTb.ReadOnly = true;
            this.BatchOutputTb.Size = new System.Drawing.Size(153, 22);
            this.BatchOutputTb.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 43);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 17);
            this.label6.TabIndex = 1;
            this.label6.Text = "Output";
            // 
            // EnableBatchModeChb
            // 
            this.EnableBatchModeChb.AutoSize = true;
            this.EnableBatchModeChb.Location = new System.Drawing.Point(8, 18);
            this.EnableBatchModeChb.Margin = new System.Windows.Forms.Padding(4);
            this.EnableBatchModeChb.Name = "EnableBatchModeChb";
            this.EnableBatchModeChb.Size = new System.Drawing.Size(152, 21);
            this.EnableBatchModeChb.TabIndex = 0;
            this.EnableBatchModeChb.Text = "Enable batch mode";
            this.EnableBatchModeChb.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.FpsTb);
            this.groupBox5.Controls.Add(this.label9);
            this.groupBox5.Controls.Add(this.LambdaTb);
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Controls.Add(this.BmpPaletteCb);
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Controls.Add(this.VxCtCb);
            this.groupBox5.Controls.Add(this.label4);
            this.groupBox5.Location = new System.Drawing.Point(9, 25);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox5.Size = new System.Drawing.Size(267, 153);
            this.groupBox5.TabIndex = 0;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Details";
            // 
            // FpsTb
            // 
            this.FpsTb.Location = new System.Drawing.Point(91, 109);
            this.FpsTb.Name = "FpsTb";
            this.FpsTb.ReadOnly = true;
            this.FpsTb.Size = new System.Drawing.Size(168, 22);
            this.FpsTb.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 112);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 17);
            this.label9.TabIndex = 6;
            this.label9.Text = "Frames/sec";
            // 
            // LambdaTb
            // 
            this.LambdaTb.Location = new System.Drawing.Point(91, 80);
            this.LambdaTb.Name = "LambdaTb";
            this.LambdaTb.ReadOnly = true;
            this.LambdaTb.Size = new System.Drawing.Size(168, 22);
            this.LambdaTb.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 83);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 17);
            this.label8.TabIndex = 4;
            this.label8.Text = "Lambda";
            // 
            // BmpPaletteCb
            // 
            this.BmpPaletteCb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BmpPaletteCb.FormattingEnabled = true;
            this.BmpPaletteCb.Items.AddRange(new object[] {
            "16 bpp - 32768 colors",
            "32 bpp - standard ARGB"});
            this.BmpPaletteCb.Location = new System.Drawing.Point(91, 49);
            this.BmpPaletteCb.Margin = new System.Windows.Forms.Padding(4);
            this.BmpPaletteCb.Name = "BmpPaletteCb";
            this.BmpPaletteCb.Size = new System.Drawing.Size(168, 24);
            this.BmpPaletteCb.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 53);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 17);
            this.label5.TabIndex = 2;
            this.label5.Text = "Palette";
            // 
            // VxCtCb
            // 
            this.VxCtCb.FormattingEnabled = true;
            this.VxCtCb.Items.AddRange(new object[] {
            "128x128 - Extra small",
            "256x256 - Small",
            "512x512 - Medium",
            "1024x1024 - Large",
            "1920x1080 - Desktop"});
            this.VxCtCb.Location = new System.Drawing.Point(91, 16);
            this.VxCtCb.Margin = new System.Windows.Forms.Padding(4);
            this.VxCtCb.Name = "VxCtCb";
            this.VxCtCb.Size = new System.Drawing.Size(168, 24);
            this.VxCtCb.TabIndex = 1;
            this.VxCtCb.Text = "128x128";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 20);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "# of voxels";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.ColorVisualizerBoxOff);
            this.groupBox7.Controls.Add(this.ColorVisualizerBoxOn);
            this.groupBox7.Controls.Add(this.DefaultToTb);
            this.groupBox7.Controls.Add(this.DefaultRb);
            this.groupBox7.Controls.Add(this.ProbabilisticChoiceRb);
            this.groupBox7.Location = new System.Drawing.Point(16, 33);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(163, 140);
            this.groupBox7.TabIndex = 2;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Values";
            // 
            // ColorVisualizerBoxOff
            // 
            this.ColorVisualizerBoxOff.BackColor = System.Drawing.Color.White;
            this.ColorVisualizerBoxOff.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ColorVisualizerBoxOff.Location = new System.Drawing.Point(6, 78);
            this.ColorVisualizerBoxOff.Margin = new System.Windows.Forms.Padding(4);
            this.ColorVisualizerBoxOff.Name = "ColorVisualizerBoxOff";
            this.ColorVisualizerBoxOff.Size = new System.Drawing.Size(71, 20);
            this.ColorVisualizerBoxOff.TabIndex = 6;
            this.ColorVisualizerBoxOff.Click += new System.EventHandler(this.ColorVisualizerBoxOff_Click);
            // 
            // DefaultToTb
            // 
            this.DefaultToTb.Location = new System.Drawing.Point(102, 49);
            this.DefaultToTb.Name = "DefaultToTb";
            this.DefaultToTb.Size = new System.Drawing.Size(54, 22);
            this.DefaultToTb.TabIndex = 2;
            this.DefaultToTb.Text = "on";
            // 
            // DefaultRb
            // 
            this.DefaultRb.AutoSize = true;
            this.DefaultRb.Checked = true;
            this.DefaultRb.Location = new System.Drawing.Point(6, 50);
            this.DefaultRb.Name = "DefaultRb";
            this.DefaultRb.Size = new System.Drawing.Size(90, 21);
            this.DefaultRb.TabIndex = 1;
            this.DefaultRb.TabStop = true;
            this.DefaultRb.Text = "Default to";
            this.DefaultRb.UseVisualStyleBackColor = true;
            // 
            // ProbabilisticChoiceRb
            // 
            this.ProbabilisticChoiceRb.AutoSize = true;
            this.ProbabilisticChoiceRb.Location = new System.Drawing.Point(6, 21);
            this.ProbabilisticChoiceRb.Name = "ProbabilisticChoiceRb";
            this.ProbabilisticChoiceRb.Size = new System.Drawing.Size(150, 21);
            this.ProbabilisticChoiceRb.TabIndex = 0;
            this.ProbabilisticChoiceRb.Text = "Probabilistic choice";
            this.ProbabilisticChoiceRb.UseVisualStyleBackColor = true;
            // 
            // MainMenu
            // 
            this.MainMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.modifyToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.MainMenu.Location = new System.Drawing.Point(0, 0);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.MainMenu.Size = new System.Drawing.Size(607, 28);
            this.MainMenu.TabIndex = 4;
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.toolStripSeparator1,
            this.renderToolStripMenuItem,
            this.renderSilentlyToolStripMenuItem,
            this.displayRenderToolStripMenuItem,
            this.rerenderToolStripMenuItem,
            this.rerenderSilentlyToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(237, 26);
            this.newToolStripMenuItem.Text = "New (Ctrl+N)";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(237, 26);
            this.openToolStripMenuItem.Text = "Open (Ctrl+O)";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(237, 26);
            this.saveToolStripMenuItem.Text = "Save (Ctrl+S)";
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(237, 26);
            this.saveAsToolStripMenuItem.Text = "Save as... (Ctrl+Shift+S)";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(234, 6);
            // 
            // renderToolStripMenuItem
            // 
            this.renderToolStripMenuItem.Name = "renderToolStripMenuItem";
            this.renderToolStripMenuItem.Size = new System.Drawing.Size(237, 26);
            this.renderToolStripMenuItem.Text = "Render (F11)";
            this.renderToolStripMenuItem.Click += new System.EventHandler(this.renderToolStripMenuItem_Click);
            // 
            // renderSilentlyToolStripMenuItem
            // 
            this.renderSilentlyToolStripMenuItem.Name = "renderSilentlyToolStripMenuItem";
            this.renderSilentlyToolStripMenuItem.Size = new System.Drawing.Size(237, 26);
            this.renderSilentlyToolStripMenuItem.Text = "Render silently (F12)";
            this.renderSilentlyToolStripMenuItem.Click += new System.EventHandler(this.renderSilentlyToolStripMenuItem_Click);
            // 
            // displayRenderToolStripMenuItem
            // 
            this.displayRenderToolStripMenuItem.Name = "displayRenderToolStripMenuItem";
            this.displayRenderToolStripMenuItem.Size = new System.Drawing.Size(237, 26);
            this.displayRenderToolStripMenuItem.Text = "Display render (F10)";
            this.displayRenderToolStripMenuItem.Click += new System.EventHandler(this.displayRenderF10ToolStripMenuItem_Click);
            // 
            // rerenderToolStripMenuItem
            // 
            this.rerenderToolStripMenuItem.Name = "rerenderToolStripMenuItem";
            this.rerenderToolStripMenuItem.Size = new System.Drawing.Size(237, 26);
            this.rerenderToolStripMenuItem.Text = "Rerender (F5)";
            this.rerenderToolStripMenuItem.Click += new System.EventHandler(this.rerenderToolStripMenuItem_Click);
            // 
            // rerenderSilentlyToolStripMenuItem
            // 
            this.rerenderSilentlyToolStripMenuItem.Name = "rerenderSilentlyToolStripMenuItem";
            this.rerenderSilentlyToolStripMenuItem.Size = new System.Drawing.Size(237, 26);
            this.rerenderSilentlyToolStripMenuItem.Text = "Rerender silently (F6)";
            this.rerenderSilentlyToolStripMenuItem.Click += new System.EventHandler(this.rerenderSilentlyToolStripMenuItem_Click);
            // 
            // modifyToolStripMenuItem
            // 
            this.modifyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.applyTransformToolStripMenuItem});
            this.modifyToolStripMenuItem.Name = "modifyToolStripMenuItem";
            this.modifyToolStripMenuItem.Size = new System.Drawing.Size(68, 24);
            this.modifyToolStripMenuItem.Text = "Modify";
            // 
            // applyTransformToolStripMenuItem
            // 
            this.applyTransformToolStripMenuItem.Name = "applyTransformToolStripMenuItem";
            this.applyTransformToolStripMenuItem.Size = new System.Drawing.Size(255, 26);
            this.applyTransformToolStripMenuItem.Text = "Apply transform... (Ctrl+T)";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contentsToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // contentsToolStripMenuItem
            // 
            this.contentsToolStripMenuItem.Name = "contentsToolStripMenuItem";
            this.contentsToolStripMenuItem.Size = new System.Drawing.Size(171, 26);
            this.contentsToolStripMenuItem.Text = "Contents (F1)";
            // 
            // ChangeColorDialog
            // 
            this.ChangeColorDialog.AnyColor = true;
            this.ChangeColorDialog.FullOpen = true;
            // 
            // VoxelsS
            // 
            this.VoxelsS.DataSetName = "Voxels";
            this.VoxelsS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ControlStateSource
            // 
            this.ControlStateSource.DataSource = this.ControlStateS;
            this.ControlStateSource.Position = 0;
            // 
            // ControlStateS
            // 
            this.ControlStateS.DataSetName = "ControlState";
            this.ControlStateS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // TransformCreator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 384);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.MainMenu);
            this.MainMenuStrip = this.MainMenu;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TransformCreator";
            this.Text = "Transform Creator | Bitmath";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.MainMenu.ResumeLayout(false);
            this.MainMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VoxelsS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ControlStateSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ControlStateS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
        private ControlState ControlState;
        public GroupBox groupBox1;
        public RadioButton ExpRb;
        public RadioButton MultiplyRb;
        public RadioButton AddRb;
        public TextBox CenterMuliplierTb;
        public TextBox CenterRightMultiplierTb;
        public TextBox BottomRightMultiplierTb;
        public TextBox BottomCenterMultiplierTb;
        public TextBox BottomLeftMultiplierTb;
        public TextBox CenterLeftMultiplierTb;
        public TextBox TopRightMultiplierTb;
        public TextBox TopCenterMultiplierTb;
        public TextBox TopLeftMultiplierTb;
        public Panel ColorVisualizerBoxOn;
        public GroupBox groupBox3;
        public RadioButton GaussRb;
        public TextBox StdDevTb;
        public Label label3;
        public TextBox MeanTb;
        public Label label2;
        public RadioButton PoissonRb;
        public Button ManualEditBtn;
        public RadioButton ManualRb;
        public GroupBox groupBox4;
        public MenuStrip MainMenu;
        public ToolStripMenuItem fileToolStripMenuItem;
        public ToolStripMenuItem newToolStripMenuItem;
        public ToolStripMenuItem openToolStripMenuItem;
        public ToolStripMenuItem saveToolStripMenuItem;
        public ToolStripMenuItem saveAsToolStripMenuItem;
        public ToolStripSeparator toolStripSeparator1;
        public ToolStripMenuItem renderToolStripMenuItem;
        public ToolStripMenuItem renderSilentlyToolStripMenuItem;
        public ToolStripMenuItem displayRenderToolStripMenuItem;
        public ToolStripMenuItem rerenderToolStripMenuItem;
        public ToolStripMenuItem rerenderSilentlyToolStripMenuItem;
        public GroupBox groupBox5;
        public ComboBox VxCtCb;
        public Label label4;
        public ToolStripMenuItem modifyToolStripMenuItem;
        public ToolStripMenuItem applyTransformToolStripMenuItem;
        public ComboBox BmpPaletteCb;
        public Label label5;
        public GroupBox groupBox6;
        public CheckBox EnableBatchModeChb;
        public CheckBox GifCb;
        public Button SelectBatchOutputDirectoryBtn;
        public TextBox BatchOutputTb;
        public Label label6;
        public TextBox frameCtTb;
        public Label label7;
        public CheckBox CustomAnimateChb;
        public Button AnimationEditorBtn;
        public TextBox LambdaTb;
        public Label label8;
        public GroupBox groupBox7;
        public TextBox DefaultToTb;
        public RadioButton DefaultRb;
        public RadioButton ProbabilisticChoiceRb;
        public ToolStripMenuItem helpToolStripMenuItem;
        public ToolStripMenuItem contentsToolStripMenuItem;
        public ColorDialog ChangeColorDialog;
        public TextBox FpsTb;
        public Label label9;
        public BindingSource ControlStateSource;
        public ControlState ControlStateS;
        private Voxels VoxelsS;
        public Panel ColorVisualizerBoxOff;
    }
}

