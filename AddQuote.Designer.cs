namespace MegaDesk
{
    partial class AddQuote
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
            this.newQuote = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.customerName = new System.Windows.Forms.Label();
            this.deskSize = new System.Windows.Forms.GroupBox();
            this.depthLabel = new System.Windows.Forms.Label();
            this.widthLabel = new System.Windows.Forms.Label();
            this.DepthnumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.widthNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.surfaceMaterialDropdown = new System.Windows.Forms.ComboBox();
            this.rushOrderCombo = new System.Windows.Forms.ComboBox();
            this.drawersNum = new System.Windows.Forms.NumericUpDown();
            this.drawersNumLab = new System.Windows.Forms.Label();
            this.surfaceMatLab = new System.Windows.Forms.Label();
            this.deliveryLab = new System.Windows.Forms.Label();
            this.getQouteBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.deskSize.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DepthnumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.widthNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.drawersNum)).BeginInit();
            this.SuspendLayout();
            // 
            // newQuote
            // 
            this.newQuote.AutoSize = true;
            this.newQuote.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newQuote.Location = new System.Drawing.Point(327, 21);
            this.newQuote.Name = "newQuote";
            this.newQuote.Size = new System.Drawing.Size(135, 29);
            this.newQuote.TabIndex = 0;
            this.newQuote.Text = "New Quote";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(256, 80);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(280, 20);
            this.textBox1.TabIndex = 1;
            // 
            // customerName
            // 
            this.customerName.AutoSize = true;
            this.customerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerName.Location = new System.Drawing.Point(128, 82);
            this.customerName.Name = "customerName";
            this.customerName.Size = new System.Drawing.Size(122, 18);
            this.customerName.TabIndex = 2;
            this.customerName.Text = "Customer Name:";
            // 
            // deskSize
            // 
            this.deskSize.Controls.Add(this.depthLabel);
            this.deskSize.Controls.Add(this.widthLabel);
            this.deskSize.Controls.Add(this.DepthnumericUpDown);
            this.deskSize.Controls.Add(this.widthNumericUpDown);
            this.deskSize.Location = new System.Drawing.Point(131, 132);
            this.deskSize.Name = "deskSize";
            this.deskSize.Size = new System.Drawing.Size(200, 100);
            this.deskSize.TabIndex = 3;
            this.deskSize.TabStop = false;
            this.deskSize.Text = "Desk Size";
            // 
            // depthLabel
            // 
            this.depthLabel.AutoSize = true;
            this.depthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.depthLabel.Location = new System.Drawing.Point(6, 58);
            this.depthLabel.Name = "depthLabel";
            this.depthLabel.Size = new System.Drawing.Size(50, 17);
            this.depthLabel.TabIndex = 3;
            this.depthLabel.Text = "Depth:";
            this.depthLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // widthLabel
            // 
            this.widthLabel.AutoSize = true;
            this.widthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.widthLabel.Location = new System.Drawing.Point(9, 23);
            this.widthLabel.Name = "widthLabel";
            this.widthLabel.Size = new System.Drawing.Size(48, 17);
            this.widthLabel.TabIndex = 2;
            this.widthLabel.Text = "Width:";
            // 
            // DepthnumericUpDown
            // 
            this.DepthnumericUpDown.Location = new System.Drawing.Point(59, 55);
            this.DepthnumericUpDown.Maximum = new decimal(new int[] {
            48,
            0,
            0,
            0});
            this.DepthnumericUpDown.Minimum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.DepthnumericUpDown.Name = "DepthnumericUpDown";
            this.DepthnumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.DepthnumericUpDown.TabIndex = 1;
            this.DepthnumericUpDown.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            // 
            // widthNumericUpDown
            // 
            this.widthNumericUpDown.Location = new System.Drawing.Point(59, 20);
            this.widthNumericUpDown.Maximum = new decimal(new int[] {
            96,
            0,
            0,
            0});
            this.widthNumericUpDown.Minimum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.widthNumericUpDown.Name = "widthNumericUpDown";
            this.widthNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.widthNumericUpDown.TabIndex = 0;
            this.widthNumericUpDown.Value = new decimal(new int[] {
            24,
            0,
            0,
            0});
            // 
            // surfaceMaterialDropdown
            // 
            this.surfaceMaterialDropdown.FormattingEnabled = true;
            this.surfaceMaterialDropdown.Items.AddRange(new object[] {
            "Laminate",
            "Oak",
            "Pine",
            "Rosewood",
            "Veneer"});
            this.surfaceMaterialDropdown.Location = new System.Drawing.Point(466, 165);
            this.surfaceMaterialDropdown.Name = "surfaceMaterialDropdown";
            this.surfaceMaterialDropdown.Size = new System.Drawing.Size(121, 21);
            this.surfaceMaterialDropdown.TabIndex = 4;
            // 
            // rushOrderCombo
            // 
            this.rushOrderCombo.FormattingEnabled = true;
            this.rushOrderCombo.Items.AddRange(new object[] {
            "Rush- 3 Days",
            "Rush- 5 Days",
            "Rush- 7 Days",
            "No Rush"});
            this.rushOrderCombo.Location = new System.Drawing.Point(466, 192);
            this.rushOrderCombo.Name = "rushOrderCombo";
            this.rushOrderCombo.Size = new System.Drawing.Size(121, 21);
            this.rushOrderCombo.TabIndex = 5;
            // 
            // drawersNum
            // 
            this.drawersNum.Location = new System.Drawing.Point(466, 139);
            this.drawersNum.Name = "drawersNum";
            this.drawersNum.Size = new System.Drawing.Size(70, 20);
            this.drawersNum.TabIndex = 6;
            // 
            // drawersNumLab
            // 
            this.drawersNumLab.AutoSize = true;
            this.drawersNumLab.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drawersNumLab.Location = new System.Drawing.Point(335, 143);
            this.drawersNumLab.Name = "drawersNumLab";
            this.drawersNumLab.Size = new System.Drawing.Size(125, 16);
            this.drawersNumLab.TabIndex = 7;
            this.drawersNumLab.Text = "Number of Drawers:";
            // 
            // surfaceMatLab
            // 
            this.surfaceMatLab.AutoSize = true;
            this.surfaceMatLab.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.surfaceMatLab.Location = new System.Drawing.Point(353, 170);
            this.surfaceMatLab.Name = "surfaceMatLab";
            this.surfaceMatLab.Size = new System.Drawing.Size(107, 16);
            this.surfaceMatLab.TabIndex = 8;
            this.surfaceMatLab.Text = "Surface Material:";
            // 
            // deliveryLab
            // 
            this.deliveryLab.AutoSize = true;
            this.deliveryLab.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deliveryLab.Location = new System.Drawing.Point(400, 197);
            this.deliveryLab.Name = "deliveryLab";
            this.deliveryLab.Size = new System.Drawing.Size(60, 16);
            this.deliveryLab.TabIndex = 9;
            this.deliveryLab.Text = "Delivery:";
            // 
            // getQouteBtn
            // 
            this.getQouteBtn.Location = new System.Drawing.Point(208, 272);
            this.getQouteBtn.Name = "getQouteBtn";
            this.getQouteBtn.Size = new System.Drawing.Size(110, 39);
            this.getQouteBtn.TabIndex = 10;
            this.getQouteBtn.Text = "Get Quote";
            this.getQouteBtn.UseVisualStyleBackColor = true;
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(439, 272);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(110, 39);
            this.cancelBtn.TabIndex = 11;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // AddQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.getQouteBtn);
            this.Controls.Add(this.deliveryLab);
            this.Controls.Add(this.surfaceMatLab);
            this.Controls.Add(this.drawersNumLab);
            this.Controls.Add(this.drawersNum);
            this.Controls.Add(this.rushOrderCombo);
            this.Controls.Add(this.surfaceMaterialDropdown);
            this.Controls.Add(this.deskSize);
            this.Controls.Add(this.customerName);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.newQuote);
            this.Name = "AddQuote";
            this.Text = "AddQuote";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AddQuote_FormClosed);
            this.deskSize.ResumeLayout(false);
            this.deskSize.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DepthnumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.widthNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.drawersNum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label newQuote;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label customerName;
        private System.Windows.Forms.GroupBox deskSize;
        private System.Windows.Forms.Label depthLabel;
        private System.Windows.Forms.Label widthLabel;
        private System.Windows.Forms.NumericUpDown DepthnumericUpDown;
        private System.Windows.Forms.NumericUpDown widthNumericUpDown;
        private System.Windows.Forms.ComboBox surfaceMaterialDropdown;
        private System.Windows.Forms.ComboBox rushOrderCombo;
        private System.Windows.Forms.NumericUpDown drawersNum;
        private System.Windows.Forms.Label drawersNumLab;
        private System.Windows.Forms.Label surfaceMatLab;
        private System.Windows.Forms.Label deliveryLab;
        private System.Windows.Forms.Button getQouteBtn;
        private System.Windows.Forms.Button cancelBtn;
    }
}