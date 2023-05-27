
namespace notepad
{
    partial class fontfoam
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
            this.lblfont = new System.Windows.Forms.Label();
            this.lblstyle = new System.Windows.Forms.Label();
            this.lblsize = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.fontcombo = new System.Windows.Forms.ComboBox();
            this.stylecombo = new System.Windows.Forms.ComboBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblfont
            // 
            this.lblfont.AutoSize = true;
            this.lblfont.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfont.Location = new System.Drawing.Point(30, 138);
            this.lblfont.Name = "lblfont";
            this.lblfont.Size = new System.Drawing.Size(46, 20);
            this.lblfont.TabIndex = 0;
            this.lblfont.Text = "Font";
            this.lblfont.Click += new System.EventHandler(this.lblfont_Click);
            // 
            // lblstyle
            // 
            this.lblstyle.AutoSize = true;
            this.lblstyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblstyle.Location = new System.Drawing.Point(183, 138);
            this.lblstyle.Name = "lblstyle";
            this.lblstyle.Size = new System.Drawing.Size(92, 20);
            this.lblstyle.TabIndex = 1;
            this.lblstyle.Text = "Font style";
            // 
            // lblsize
            // 
            this.lblsize.AutoSize = true;
            this.lblsize.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsize.Location = new System.Drawing.Point(374, 138);
            this.lblsize.Name = "lblsize";
            this.lblsize.Size = new System.Drawing.Size(46, 20);
            this.lblsize.TabIndex = 2;
            this.lblsize.Text = "Size";
            // 
            // btnOk
            // 
            this.btnOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOk.Location = new System.Drawing.Point(220, 472);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(100, 39);
            this.btnOk.TabIndex = 3;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(349, 472);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(98, 41);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // fontcombo
            // 
            this.fontcombo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.fontcombo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.fontcombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fontcombo.FormattingEnabled = true;
            this.fontcombo.Location = new System.Drawing.Point(22, 181);
            this.fontcombo.Name = "fontcombo";
            this.fontcombo.Size = new System.Drawing.Size(149, 28);
            this.fontcombo.TabIndex = 5;
            this.fontcombo.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // stylecombo
            // 
            this.stylecombo.AutoCompleteCustomSource.AddRange(new string[] {
            "Regular",
            "Italic",
            "Bold",
            "Bold Italic"});
            this.stylecombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stylecombo.FormattingEnabled = true;
            this.stylecombo.Items.AddRange(new object[] {
            "Regular",
            "Italic",
            "Bold",
            "Bold Italic"});
            this.stylecombo.Location = new System.Drawing.Point(186, 181);
            this.stylecombo.Name = "stylecombo";
            this.stylecombo.Size = new System.Drawing.Size(162, 28);
            this.stylecombo.TabIndex = 6;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(378, 187);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(65, 22);
            this.numericUpDown1.TabIndex = 7;
            // 
            // fontfoam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 602);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.stylecombo);
            this.Controls.Add(this.fontcombo);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.lblsize);
            this.Controls.Add(this.lblstyle);
            this.Controls.Add(this.lblfont);
            this.MaximumSize = new System.Drawing.Size(520, 649);
            this.MinimumSize = new System.Drawing.Size(520, 649);
            this.Name = "fontfoam";
            this.Text = "fontfoam";
            this.Load += new System.EventHandler(this.fontfoam_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblfont;
        private System.Windows.Forms.Label lblstyle;
        private System.Windows.Forms.Label lblsize;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ComboBox fontcombo;
        private System.Windows.Forms.ComboBox stylecombo;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
    }
}