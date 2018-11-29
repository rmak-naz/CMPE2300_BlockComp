namespace ICA5_BlockComp
{
    partial class ICA5_BlockComp
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
            this.B_Randomize = new System.Windows.Forms.Button();
            this.GB_SortType = new System.Windows.Forms.GroupBox();
            this.B_Sort = new System.Windows.Forms.Button();
            this.RB_Hue = new System.Windows.Forms.RadioButton();
            this.RB_Brightness = new System.Windows.Forms.RadioButton();
            this.RB_Saturation = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.LB_CompNum = new System.Windows.Forms.Label();
            this.GB_SortType.SuspendLayout();
            this.SuspendLayout();
            // 
            // B_Randomize
            // 
            this.B_Randomize.Location = new System.Drawing.Point(13, 13);
            this.B_Randomize.Name = "B_Randomize";
            this.B_Randomize.Size = new System.Drawing.Size(259, 23);
            this.B_Randomize.TabIndex = 0;
            this.B_Randomize.Text = "Randomize!";
            this.B_Randomize.UseVisualStyleBackColor = true;
            this.B_Randomize.Click += new System.EventHandler(this.B_Randomize_Click);
            // 
            // GB_SortType
            // 
            this.GB_SortType.Controls.Add(this.B_Sort);
            this.GB_SortType.Controls.Add(this.RB_Hue);
            this.GB_SortType.Controls.Add(this.RB_Brightness);
            this.GB_SortType.Controls.Add(this.RB_Saturation);
            this.GB_SortType.Location = new System.Drawing.Point(13, 43);
            this.GB_SortType.Name = "GB_SortType";
            this.GB_SortType.Size = new System.Drawing.Size(259, 127);
            this.GB_SortType.TabIndex = 1;
            this.GB_SortType.TabStop = false;
            this.GB_SortType.Text = "Sort Type:";
            // 
            // B_Sort
            // 
            this.B_Sort.Enabled = false;
            this.B_Sort.Location = new System.Drawing.Point(7, 90);
            this.B_Sort.Name = "B_Sort";
            this.B_Sort.Size = new System.Drawing.Size(246, 23);
            this.B_Sort.TabIndex = 3;
            this.B_Sort.Text = "Sort!";
            this.B_Sort.UseVisualStyleBackColor = true;
            this.B_Sort.Click += new System.EventHandler(this.B_Sort_Click);
            // 
            // RB_Hue
            // 
            this.RB_Hue.AutoSize = true;
            this.RB_Hue.Location = new System.Drawing.Point(7, 66);
            this.RB_Hue.Name = "RB_Hue";
            this.RB_Hue.Size = new System.Drawing.Size(45, 17);
            this.RB_Hue.TabIndex = 2;
            this.RB_Hue.TabStop = true;
            this.RB_Hue.Text = "Hue";
            this.RB_Hue.UseVisualStyleBackColor = true;
            // 
            // RB_Brightness
            // 
            this.RB_Brightness.AutoSize = true;
            this.RB_Brightness.Location = new System.Drawing.Point(7, 43);
            this.RB_Brightness.Name = "RB_Brightness";
            this.RB_Brightness.Size = new System.Drawing.Size(74, 17);
            this.RB_Brightness.TabIndex = 1;
            this.RB_Brightness.TabStop = true;
            this.RB_Brightness.Text = "Brightness";
            this.RB_Brightness.UseVisualStyleBackColor = true;
            // 
            // RB_Saturation
            // 
            this.RB_Saturation.AutoSize = true;
            this.RB_Saturation.Checked = true;
            this.RB_Saturation.Location = new System.Drawing.Point(7, 20);
            this.RB_Saturation.Name = "RB_Saturation";
            this.RB_Saturation.Size = new System.Drawing.Size(73, 17);
            this.RB_Saturation.TabIndex = 0;
            this.RB_Saturation.TabStop = true;
            this.RB_Saturation.Text = "Saturation";
            this.RB_Saturation.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 177);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Number of Comparisons:";
            // 
            // LB_CompNum
            // 
            this.LB_CompNum.AutoSize = true;
            this.LB_CompNum.Location = new System.Drawing.Point(142, 177);
            this.LB_CompNum.Name = "LB_CompNum";
            this.LB_CompNum.Size = new System.Drawing.Size(13, 13);
            this.LB_CompNum.TabIndex = 3;
            this.LB_CompNum.Text = "0";
            // 
            // ICA5_BlockComp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 202);
            this.Controls.Add(this.LB_CompNum);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GB_SortType);
            this.Controls.Add(this.B_Randomize);
            this.Name = "ICA5_BlockComp";
            this.Text = "BlockyComp";
            this.GB_SortType.ResumeLayout(false);
            this.GB_SortType.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button B_Randomize;
        private System.Windows.Forms.GroupBox GB_SortType;
        private System.Windows.Forms.Button B_Sort;
        private System.Windows.Forms.RadioButton RB_Hue;
        private System.Windows.Forms.RadioButton RB_Brightness;
        private System.Windows.Forms.RadioButton RB_Saturation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LB_CompNum;
    }
}

