namespace formSimulator
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.regexdata = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // regexdata
            // 
            this.regexdata.Location = new System.Drawing.Point(-2, 0);
            this.regexdata.Name = "regexdata";
            this.regexdata.Size = new System.Drawing.Size(489, 479);
            this.regexdata.TabIndex = 0;
            this.regexdata.Text = "";
            this.regexdata.TextChanged += new System.EventHandler(this.regexdata_TextChanged);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 479);
            this.Controls.Add(this.regexdata);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(501, 518);
            this.MinimumSize = new System.Drawing.Size(501, 518);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox regexdata;
    }
}