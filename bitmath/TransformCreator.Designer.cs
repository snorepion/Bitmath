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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TopLeftMultiplierTb = new System.Windows.Forms.TextBox();
            this.TopCenterMultiplierTb = new System.Windows.Forms.TextBox();
            this.TopRightMultiplierTb = new System.Windows.Forms.TextBox();
            this.CenterLeftMultiplierTb = new System.Windows.Forms.TextBox();
            this.BottomLeftMultiplierTb = new System.Windows.Forms.TextBox();
            this.BottomCenterMultiplierTb = new System.Windows.Forms.TextBox();
            this.BottomRightMultiplierTb = new System.Windows.Forms.TextBox();
            this.CenterRightMultiplierTb = new System.Windows.Forms.TextBox();
            this.CenterMuliplierTb = new System.Windows.Forms.TextBox();
            this.AddRb = new System.Windows.Forms.RadioButton();
            this.MultiplyRb = new System.Windows.Forms.RadioButton();
            this.ExpRb = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.VoxelPossibleValuesListBox = new System.Windows.Forms.ListBox();
            this.LowerBoundTb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.UpperBoundTb = new System.Windows.Forms.TextBox();
            this.AddVoxelPossibleValueBtn = new System.Windows.Forms.Button();
            this.ColorVisualizerBox = new System.Windows.Forms.Panel();
            this.RemoveVoxelPossibleValueBtn = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.MaxWeightTb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.MinBoundTb = new System.Windows.Forms.TextBox();
            this.GaussRb = new System.Windows.Forms.RadioButton();
            this.PoissonRb = new System.Windows.Forms.RadioButton();
            this.ManualRb = new System.Windows.Forms.RadioButton();
            this.ManualEditBtn = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.MainMenu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.renderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.renderSilentlyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.displayRenderF10ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rerenderF5ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rerenderSilentlyF6ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.applyTransformToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.VxCtCb = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.BmpPaletteCb = new System.Windows.Forms.ComboBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.EnableBatchModeChb = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.BatchOutputTb = new System.Windows.Forms.TextBox();
            this.SelectBatchOutputDirectoryBtn = new System.Windows.Forms.Button();
            this.GifCb = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.frameCtTb = new System.Windows.Forms.TextBox();
            this.AnimationEditorBtn = new System.Windows.Forms.Button();
            this.CustomAnimateChb = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.MainMenu.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
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
            this.groupBox1.Location = new System.Drawing.Point(382, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(196, 114);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Effect of other voxels";
            // 
            // TopLeftMultiplierTb
            // 
            this.TopLeftMultiplierTb.Location = new System.Drawing.Point(6, 19);
            this.TopLeftMultiplierTb.Name = "TopLeftMultiplierTb";
            this.TopLeftMultiplierTb.Size = new System.Drawing.Size(57, 20);
            this.TopLeftMultiplierTb.TabIndex = 0;
            this.TopLeftMultiplierTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TopCenterMultiplierTb
            // 
            this.TopCenterMultiplierTb.Location = new System.Drawing.Point(69, 19);
            this.TopCenterMultiplierTb.Name = "TopCenterMultiplierTb";
            this.TopCenterMultiplierTb.Size = new System.Drawing.Size(57, 20);
            this.TopCenterMultiplierTb.TabIndex = 1;
            this.TopCenterMultiplierTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TopRightMultiplierTb
            // 
            this.TopRightMultiplierTb.Location = new System.Drawing.Point(132, 19);
            this.TopRightMultiplierTb.Name = "TopRightMultiplierTb";
            this.TopRightMultiplierTb.Size = new System.Drawing.Size(57, 20);
            this.TopRightMultiplierTb.TabIndex = 2;
            this.TopRightMultiplierTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CenterLeftMultiplierTb
            // 
            this.CenterLeftMultiplierTb.Location = new System.Drawing.Point(6, 45);
            this.CenterLeftMultiplierTb.Name = "CenterLeftMultiplierTb";
            this.CenterLeftMultiplierTb.Size = new System.Drawing.Size(57, 20);
            this.CenterLeftMultiplierTb.TabIndex = 3;
            this.CenterLeftMultiplierTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BottomLeftMultiplierTb
            // 
            this.BottomLeftMultiplierTb.Location = new System.Drawing.Point(6, 71);
            this.BottomLeftMultiplierTb.Name = "BottomLeftMultiplierTb";
            this.BottomLeftMultiplierTb.Size = new System.Drawing.Size(57, 20);
            this.BottomLeftMultiplierTb.TabIndex = 4;
            this.BottomLeftMultiplierTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BottomCenterMultiplierTb
            // 
            this.BottomCenterMultiplierTb.Location = new System.Drawing.Point(69, 71);
            this.BottomCenterMultiplierTb.Name = "BottomCenterMultiplierTb";
            this.BottomCenterMultiplierTb.Size = new System.Drawing.Size(57, 20);
            this.BottomCenterMultiplierTb.TabIndex = 5;
            this.BottomCenterMultiplierTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BottomRightMultiplierTb
            // 
            this.BottomRightMultiplierTb.Location = new System.Drawing.Point(132, 71);
            this.BottomRightMultiplierTb.Name = "BottomRightMultiplierTb";
            this.BottomRightMultiplierTb.Size = new System.Drawing.Size(57, 20);
            this.BottomRightMultiplierTb.TabIndex = 6;
            this.BottomRightMultiplierTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CenterRightMultiplierTb
            // 
            this.CenterRightMultiplierTb.Location = new System.Drawing.Point(132, 45);
            this.CenterRightMultiplierTb.Name = "CenterRightMultiplierTb";
            this.CenterRightMultiplierTb.Size = new System.Drawing.Size(57, 20);
            this.CenterRightMultiplierTb.TabIndex = 7;
            this.CenterRightMultiplierTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CenterMuliplierTb
            // 
            this.CenterMuliplierTb.Location = new System.Drawing.Point(69, 45);
            this.CenterMuliplierTb.Name = "CenterMuliplierTb";
            this.CenterMuliplierTb.ReadOnly = true;
            this.CenterMuliplierTb.Size = new System.Drawing.Size(57, 20);
            this.CenterMuliplierTb.TabIndex = 8;
            this.CenterMuliplierTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // AddRb
            // 
            this.AddRb.AutoSize = true;
            this.AddRb.Location = new System.Drawing.Point(6, 94);
            this.AddRb.Name = "AddRb";
            this.AddRb.Size = new System.Drawing.Size(44, 17);
            this.AddRb.TabIndex = 9;
            this.AddRb.Text = "Add";
            this.AddRb.UseVisualStyleBackColor = true;
            // 
            // MultiplyRb
            // 
            this.MultiplyRb.AutoSize = true;
            this.MultiplyRb.Checked = true;
            this.MultiplyRb.Location = new System.Drawing.Point(56, 94);
            this.MultiplyRb.Name = "MultiplyRb";
            this.MultiplyRb.Size = new System.Drawing.Size(60, 17);
            this.MultiplyRb.TabIndex = 10;
            this.MultiplyRb.TabStop = true;
            this.MultiplyRb.Text = "Multiply";
            this.MultiplyRb.UseVisualStyleBackColor = true;
            // 
            // ExpRb
            // 
            this.ExpRb.AutoSize = true;
            this.ExpRb.Location = new System.Drawing.Point(122, 94);
            this.ExpRb.Name = "ExpRb";
            this.ExpRb.Size = new System.Drawing.Size(70, 17);
            this.ExpRb.TabIndex = 11;
            this.ExpRb.Text = "Exponent";
            this.ExpRb.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.RemoveVoxelPossibleValueBtn);
            this.groupBox2.Controls.Add(this.ColorVisualizerBox);
            this.groupBox2.Controls.Add(this.AddVoxelPossibleValueBtn);
            this.groupBox2.Controls.Add(this.UpperBoundTb);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.LowerBoundTb);
            this.groupBox2.Controls.Add(this.VoxelPossibleValuesListBox);
            this.groupBox2.Location = new System.Drawing.Point(12, 27);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(208, 114);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Voxel values";
            // 
            // VoxelPossibleValuesListBox
            // 
            this.VoxelPossibleValuesListBox.FormattingEnabled = true;
            this.VoxelPossibleValuesListBox.Location = new System.Drawing.Point(6, 26);
            this.VoxelPossibleValuesListBox.Name = "VoxelPossibleValuesListBox";
            this.VoxelPossibleValuesListBox.Size = new System.Drawing.Size(120, 56);
            this.VoxelPossibleValuesListBox.TabIndex = 0;
            // 
            // LowerBoundTb
            // 
            this.LowerBoundTb.Location = new System.Drawing.Point(6, 88);
            this.LowerBoundTb.Name = "LowerBoundTb";
            this.LowerBoundTb.Size = new System.Drawing.Size(41, 20);
            this.LowerBoundTb.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "to";
            // 
            // UpperBoundTb
            // 
            this.UpperBoundTb.Location = new System.Drawing.Point(75, 88);
            this.UpperBoundTb.Name = "UpperBoundTb";
            this.UpperBoundTb.Size = new System.Drawing.Size(51, 20);
            this.UpperBoundTb.TabIndex = 3;
            // 
            // AddVoxelPossibleValueBtn
            // 
            this.AddVoxelPossibleValueBtn.Location = new System.Drawing.Point(132, 26);
            this.AddVoxelPossibleValueBtn.Name = "AddVoxelPossibleValueBtn";
            this.AddVoxelPossibleValueBtn.Size = new System.Drawing.Size(70, 27);
            this.AddVoxelPossibleValueBtn.TabIndex = 4;
            this.AddVoxelPossibleValueBtn.Text = "Add";
            this.AddVoxelPossibleValueBtn.UseVisualStyleBackColor = true;
            // 
            // ColorVisualizerBox
            // 
            this.ColorVisualizerBox.BackColor = System.Drawing.Color.White;
            this.ColorVisualizerBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ColorVisualizerBox.Location = new System.Drawing.Point(132, 88);
            this.ColorVisualizerBox.Name = "ColorVisualizerBox";
            this.ColorVisualizerBox.Size = new System.Drawing.Size(38, 20);
            this.ColorVisualizerBox.TabIndex = 5;
            // 
            // RemoveVoxelPossibleValueBtn
            // 
            this.RemoveVoxelPossibleValueBtn.Location = new System.Drawing.Point(132, 55);
            this.RemoveVoxelPossibleValueBtn.Name = "RemoveVoxelPossibleValueBtn";
            this.RemoveVoxelPossibleValueBtn.Size = new System.Drawing.Size(70, 27);
            this.RemoveVoxelPossibleValueBtn.TabIndex = 6;
            this.RemoveVoxelPossibleValueBtn.Text = "Remove";
            this.RemoveVoxelPossibleValueBtn.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.ManualEditBtn);
            this.groupBox3.Controls.Add(this.ManualRb);
            this.groupBox3.Controls.Add(this.PoissonRb);
            this.groupBox3.Controls.Add(this.GaussRb);
            this.groupBox3.Controls.Add(this.MinBoundTb);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.MaxWeightTb);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Location = new System.Drawing.Point(226, 27);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(150, 114);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Weights";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Maximum";
            // 
            // MaxWeightTb
            // 
            this.MaxWeightTb.Location = new System.Drawing.Point(63, 19);
            this.MaxWeightTb.Name = "MaxWeightTb";
            this.MaxWeightTb.Size = new System.Drawing.Size(57, 20);
            this.MaxWeightTb.TabIndex = 12;
            this.MaxWeightTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Minimum";
            // 
            // MinBoundTb
            // 
            this.MinBoundTb.Location = new System.Drawing.Point(63, 45);
            this.MinBoundTb.Name = "MinBoundTb";
            this.MinBoundTb.Size = new System.Drawing.Size(57, 20);
            this.MinBoundTb.TabIndex = 14;
            this.MinBoundTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // GaussRb
            // 
            this.GaussRb.AutoSize = true;
            this.GaussRb.Checked = true;
            this.GaussRb.Location = new System.Drawing.Point(9, 71);
            this.GaussRb.Name = "GaussRb";
            this.GaussRb.Size = new System.Drawing.Size(69, 17);
            this.GaussRb.TabIndex = 15;
            this.GaussRb.TabStop = true;
            this.GaussRb.Text = "Gaussian";
            this.GaussRb.UseVisualStyleBackColor = true;
            // 
            // PoissonRb
            // 
            this.PoissonRb.AutoSize = true;
            this.PoissonRb.Location = new System.Drawing.Point(84, 71);
            this.PoissonRb.Name = "PoissonRb";
            this.PoissonRb.Size = new System.Drawing.Size(62, 17);
            this.PoissonRb.TabIndex = 16;
            this.PoissonRb.Text = "Poisson";
            this.PoissonRb.UseVisualStyleBackColor = true;
            // 
            // ManualRb
            // 
            this.ManualRb.AutoSize = true;
            this.ManualRb.Location = new System.Drawing.Point(9, 89);
            this.ManualRb.Name = "ManualRb";
            this.ManualRb.Size = new System.Drawing.Size(60, 17);
            this.ManualRb.TabIndex = 17;
            this.ManualRb.Text = "Manual";
            this.ManualRb.UseVisualStyleBackColor = true;
            // 
            // ManualEditBtn
            // 
            this.ManualEditBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.ManualEditBtn.Location = new System.Drawing.Point(71, 88);
            this.ManualEditBtn.Name = "ManualEditBtn";
            this.ManualEditBtn.Size = new System.Drawing.Size(75, 20);
            this.ManualEditBtn.TabIndex = 18;
            this.ManualEditBtn.Text = "Edit";
            this.ManualEditBtn.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.groupBox6);
            this.groupBox4.Controls.Add(this.groupBox5);
            this.groupBox4.Location = new System.Drawing.Point(12, 151);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(566, 150);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Render settings";
            // 
            // MainMenu
            // 
            this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.modifyToolStripMenuItem});
            this.MainMenu.Location = new System.Drawing.Point(0, 0);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Size = new System.Drawing.Size(589, 24);
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
            this.displayRenderF10ToolStripMenuItem,
            this.rerenderF5ToolStripMenuItem,
            this.rerenderSilentlyF6ToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.newToolStripMenuItem.Text = "New (Ctrl+N)";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.openToolStripMenuItem.Text = "Open (Ctrl+O)";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.saveToolStripMenuItem.Text = "Save (Ctrl+S)";
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.saveAsToolStripMenuItem.Text = "Save as... (Ctrl+Shift+S)";
            // 
            // renderToolStripMenuItem
            // 
            this.renderToolStripMenuItem.Name = "renderToolStripMenuItem";
            this.renderToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.renderToolStripMenuItem.Text = "Render (F11)";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(194, 6);
            // 
            // renderSilentlyToolStripMenuItem
            // 
            this.renderSilentlyToolStripMenuItem.Name = "renderSilentlyToolStripMenuItem";
            this.renderSilentlyToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.renderSilentlyToolStripMenuItem.Text = "Render silently (F12)";
            // 
            // displayRenderF10ToolStripMenuItem
            // 
            this.displayRenderF10ToolStripMenuItem.Name = "displayRenderF10ToolStripMenuItem";
            this.displayRenderF10ToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.displayRenderF10ToolStripMenuItem.Text = "Display render (F10)";
            // 
            // rerenderF5ToolStripMenuItem
            // 
            this.rerenderF5ToolStripMenuItem.Name = "rerenderF5ToolStripMenuItem";
            this.rerenderF5ToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.rerenderF5ToolStripMenuItem.Text = "Rerender (F5)";
            // 
            // rerenderSilentlyF6ToolStripMenuItem
            // 
            this.rerenderSilentlyF6ToolStripMenuItem.Name = "rerenderSilentlyF6ToolStripMenuItem";
            this.rerenderSilentlyF6ToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.rerenderSilentlyF6ToolStripMenuItem.Text = "Rerender silently (F6)";
            // 
            // modifyToolStripMenuItem
            // 
            this.modifyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.applyTransformToolStripMenuItem});
            this.modifyToolStripMenuItem.Name = "modifyToolStripMenuItem";
            this.modifyToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.modifyToolStripMenuItem.Text = "Modify";
            // 
            // applyTransformToolStripMenuItem
            // 
            this.applyTransformToolStripMenuItem.Name = "applyTransformToolStripMenuItem";
            this.applyTransformToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.applyTransformToolStripMenuItem.Text = "Apply transform... (Ctrl+T)";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.BmpPaletteCb);
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Controls.Add(this.VxCtCb);
            this.groupBox5.Controls.Add(this.label4);
            this.groupBox5.Location = new System.Drawing.Point(7, 20);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(200, 124);
            this.groupBox5.TabIndex = 0;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Details";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "# of voxels";
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
            this.VxCtCb.Location = new System.Drawing.Point(68, 13);
            this.VxCtCb.Name = "VxCtCb";
            this.VxCtCb.Size = new System.Drawing.Size(127, 21);
            this.VxCtCb.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Palette";
            // 
            // BmpPaletteCb
            // 
            this.BmpPaletteCb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BmpPaletteCb.FormattingEnabled = true;
            this.BmpPaletteCb.Items.AddRange(new object[] {
            "1 bpp - black and white",
            "8 bpp - 256 colors",
            "8 bpp - grayscale",
            "16 bpp - 65535 colors",
            "32 bpp - standard ARGB"});
            this.BmpPaletteCb.Location = new System.Drawing.Point(68, 40);
            this.BmpPaletteCb.Name = "BmpPaletteCb";
            this.BmpPaletteCb.Size = new System.Drawing.Size(127, 21);
            this.BmpPaletteCb.TabIndex = 3;
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
            this.groupBox6.Location = new System.Drawing.Point(214, 20);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(219, 124);
            this.groupBox6.TabIndex = 1;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Batch mode";
            // 
            // EnableBatchModeChb
            // 
            this.EnableBatchModeChb.AutoSize = true;
            this.EnableBatchModeChb.Location = new System.Drawing.Point(6, 15);
            this.EnableBatchModeChb.Name = "EnableBatchModeChb";
            this.EnableBatchModeChb.Size = new System.Drawing.Size(118, 17);
            this.EnableBatchModeChb.TabIndex = 0;
            this.EnableBatchModeChb.Text = "Enable batch mode";
            this.EnableBatchModeChb.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Output";
            // 
            // BatchOutputTb
            // 
            this.BatchOutputTb.Location = new System.Drawing.Point(51, 32);
            this.BatchOutputTb.Name = "BatchOutputTb";
            this.BatchOutputTb.ReadOnly = true;
            this.BatchOutputTb.Size = new System.Drawing.Size(121, 20);
            this.BatchOutputTb.TabIndex = 2;
            // 
            // SelectBatchOutputDirectoryBtn
            // 
            this.SelectBatchOutputDirectoryBtn.BackColor = System.Drawing.SystemColors.Control;
            this.SelectBatchOutputDirectoryBtn.Enabled = false;
            this.SelectBatchOutputDirectoryBtn.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.SelectBatchOutputDirectoryBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SelectBatchOutputDirectoryBtn.ForeColor = System.Drawing.Color.DarkGray;
            this.SelectBatchOutputDirectoryBtn.Location = new System.Drawing.Point(178, 30);
            this.SelectBatchOutputDirectoryBtn.Name = "SelectBatchOutputDirectoryBtn";
            this.SelectBatchOutputDirectoryBtn.Size = new System.Drawing.Size(35, 23);
            this.SelectBatchOutputDirectoryBtn.TabIndex = 3;
            this.SelectBatchOutputDirectoryBtn.Text = "...";
            this.SelectBatchOutputDirectoryBtn.UseVisualStyleBackColor = false;
            // 
            // GifCb
            // 
            this.GifCb.AutoCheck = false;
            this.GifCb.AutoSize = true;
            this.GifCb.Enabled = false;
            this.GifCb.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.GifCb.FlatAppearance.BorderSize = 0;
            this.GifCb.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.GifCb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GifCb.Location = new System.Drawing.Point(130, 15);
            this.GifCb.Name = "GifCb";
            this.GifCb.Size = new System.Drawing.Size(40, 17);
            this.GifCb.TabIndex = 4;
            this.GifCb.Text = "GIF";
            this.GifCb.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 61);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Number of frames";
            // 
            // frameCtTb
            // 
            this.frameCtTb.Location = new System.Drawing.Point(102, 58);
            this.frameCtTb.Name = "frameCtTb";
            this.frameCtTb.ReadOnly = true;
            this.frameCtTb.Size = new System.Drawing.Size(111, 20);
            this.frameCtTb.TabIndex = 6;
            // 
            // AnimationEditorBtn
            // 
            this.AnimationEditorBtn.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.AnimationEditorBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AnimationEditorBtn.ForeColor = System.Drawing.Color.DarkGray;
            this.AnimationEditorBtn.Location = new System.Drawing.Point(117, 85);
            this.AnimationEditorBtn.Name = "AnimationEditorBtn";
            this.AnimationEditorBtn.Size = new System.Drawing.Size(96, 24);
            this.AnimationEditorBtn.TabIndex = 7;
            this.AnimationEditorBtn.Text = "Animation Editor";
            this.AnimationEditorBtn.UseVisualStyleBackColor = true;
            // 
            // CustomAnimateChb
            // 
            this.CustomAnimateChb.AutoSize = true;
            this.CustomAnimateChb.Location = new System.Drawing.Point(6, 91);
            this.CustomAnimateChb.Name = "CustomAnimateChb";
            this.CustomAnimateChb.Size = new System.Drawing.Size(109, 17);
            this.CustomAnimateChb.TabIndex = 8;
            this.CustomAnimateChb.Text = "Custom animation";
            this.CustomAnimateChb.UseVisualStyleBackColor = true;
            // 
            // TransformCreator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 312);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.MainMenu);
            this.MainMenuStrip = this.MainMenu;
            this.Name = "TransformCreator";
            this.Text = "Transform Creator | Bitmath";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.MainMenu.ResumeLayout(false);
            this.MainMenu.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton ExpRb;
        private System.Windows.Forms.RadioButton MultiplyRb;
        private System.Windows.Forms.RadioButton AddRb;
        private System.Windows.Forms.TextBox CenterMuliplierTb;
        private System.Windows.Forms.TextBox CenterRightMultiplierTb;
        private System.Windows.Forms.TextBox BottomRightMultiplierTb;
        private System.Windows.Forms.TextBox BottomCenterMultiplierTb;
        private System.Windows.Forms.TextBox BottomLeftMultiplierTb;
        private System.Windows.Forms.TextBox CenterLeftMultiplierTb;
        private System.Windows.Forms.TextBox TopRightMultiplierTb;
        private System.Windows.Forms.TextBox TopCenterMultiplierTb;
        private System.Windows.Forms.TextBox TopLeftMultiplierTb;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox UpperBoundTb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox LowerBoundTb;
        private System.Windows.Forms.ListBox VoxelPossibleValuesListBox;
        private System.Windows.Forms.Panel ColorVisualizerBox;
        private System.Windows.Forms.Button AddVoxelPossibleValueBtn;
        private System.Windows.Forms.Button RemoveVoxelPossibleValueBtn;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton GaussRb;
        private System.Windows.Forms.TextBox MinBoundTb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox MaxWeightTb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton PoissonRb;
        private System.Windows.Forms.Button ManualEditBtn;
        private System.Windows.Forms.RadioButton ManualRb;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.MenuStrip MainMenu;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem renderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem renderSilentlyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem displayRenderF10ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rerenderF5ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rerenderSilentlyF6ToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ComboBox VxCtCb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolStripMenuItem modifyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem applyTransformToolStripMenuItem;
        private System.Windows.Forms.ComboBox BmpPaletteCb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.CheckBox EnableBatchModeChb;
        private System.Windows.Forms.CheckBox GifCb;
        private System.Windows.Forms.Button SelectBatchOutputDirectoryBtn;
        private System.Windows.Forms.TextBox BatchOutputTb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox frameCtTb;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox CustomAnimateChb;
        private System.Windows.Forms.Button AnimationEditorBtn;
    }
}

