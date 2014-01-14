namespace formSimulator
{
    partial class mainform
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
            this.inputName = new System.Windows.Forms.TextBox();
            this.inputData = new System.Windows.Forms.TextBox();
            this.Name = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.url = new System.Windows.Forms.TextBox();
            this.query = new System.Windows.Forms.TextBox();
            this.logrtb = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.response = new System.Windows.Forms.RichTextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.pb = new System.Windows.Forms.ProgressBar();
            this.sendButton = new System.Windows.Forms.Button();
            this.clearbutton = new System.Windows.Forms.Button();
            this.requester = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // inputName
            // 
            this.inputName.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputName.Location = new System.Drawing.Point(72, 12);
            this.inputName.Name = "inputName";
            this.inputName.Size = new System.Drawing.Size(201, 31);
            this.inputName.TabIndex = 0;
            // 
            // inputData
            // 
            this.inputData.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputData.Location = new System.Drawing.Point(72, 49);
            this.inputData.Name = "inputData";
            this.inputData.Size = new System.Drawing.Size(201, 31);
            this.inputData.TabIndex = 1;
            // 
            // Name
            // 
            this.Name.AutoSize = true;
            this.Name.BackColor = System.Drawing.Color.LightCoral;
            this.Name.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Name.Location = new System.Drawing.Point(11, 15);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(55, 23);
            this.Name.TabIndex = 2;
            this.Name.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.IndianRed;
            this.label1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(11, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Data  ";
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(1000, 15);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 4;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.LightCoral;
            this.label2.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(285, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 23);
            this.label2.TabIndex = 5;
            this.label2.Text = " URL    ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.IndianRed;
            this.label3.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(283, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 23);
            this.label3.TabIndex = 6;
            this.label3.Text = "QUERY";
            // 
            // url
            // 
            this.url.AutoCompleteCustomSource.AddRange(new string[] {
            "http://localhost/",
            "http://",
            ""});
            this.url.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.url.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.url.Location = new System.Drawing.Point(351, 12);
            this.url.Name = "url";
            this.url.Size = new System.Drawing.Size(510, 31);
            this.url.TabIndex = 7;
            this.url.Text = "http://localhost";
            // 
            // query
            // 
            this.query.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.query.Location = new System.Drawing.Point(351, 49);
            this.query.Name = "query";
            this.query.Size = new System.Drawing.Size(643, 31);
            this.query.TabIndex = 8;
            // 
            // logrtb
            // 
            this.logrtb.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logrtb.Location = new System.Drawing.Point(634, 112);
            this.logrtb.Name = "logrtb";
            this.logrtb.Size = new System.Drawing.Size(440, 342);
            this.logrtb.TabIndex = 9;
            this.logrtb.Text = "Logs";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.IndianRed;
            this.label4.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(635, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 23);
            this.label4.TabIndex = 10;
            this.label4.Text = "Logs";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.IndianRed;
            this.label5.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(13, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 23);
            this.label5.TabIndex = 12;
            this.label5.Text = "Response";
            // 
            // response
            // 
            this.response.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.response.Location = new System.Drawing.Point(12, 112);
            this.response.Name = "response";
            this.response.Size = new System.Drawing.Size(616, 342);
            this.response.TabIndex = 11;
            this.response.Text = "";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "GET",
            "POST"});
            this.comboBox1.Location = new System.Drawing.Point(873, 17);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 13;
            // 
            // pb
            // 
            this.pb.Location = new System.Drawing.Point(104, 86);
            this.pb.Name = "pb";
            this.pb.Size = new System.Drawing.Size(524, 23);
            this.pb.TabIndex = 14;
            this.pb.Visible = false;
            // 
            // sendButton
            // 
            this.sendButton.Location = new System.Drawing.Point(1000, 52);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(75, 23);
            this.sendButton.TabIndex = 15;
            this.sendButton.Text = "Send";
            this.sendButton.UseVisualStyleBackColor = true;
            this.sendButton.Click += new System.EventHandler(this.sendButton_Click);
            // 
            // clearbutton
            // 
            this.clearbutton.Location = new System.Drawing.Point(999, 81);
            this.clearbutton.Name = "clearbutton";
            this.clearbutton.Size = new System.Drawing.Size(75, 23);
            this.clearbutton.TabIndex = 16;
            this.clearbutton.Text = "Clear all";
            this.clearbutton.UseVisualStyleBackColor = true;
            this.clearbutton.Click += new System.EventHandler(this.clearbutton_Click);
            // 
            // requester
            // 
            this.requester.WorkerReportsProgress = true;
            this.requester.WorkerSupportsCancellation = true;
            this.requester.DoWork += new System.ComponentModel.DoWorkEventHandler(this.requester_DoWork);
            this.requester.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.requester_ProgressChanged);
            this.requester.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.requester_RunWorkerCompleted);
            // 
            // mainform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1086, 466);
            this.Controls.Add(this.clearbutton);
            this.Controls.Add(this.sendButton);
            this.Controls.Add(this.pb);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.response);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.logrtb);
            this.Controls.Add(this.query);
            this.Controls.Add(this.url);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Name);
            this.Controls.Add(this.inputData);
            this.Controls.Add(this.inputName);
            this.MaximumSize = new System.Drawing.Size(1102, 505);
            this.MinimumSize = new System.Drawing.Size(1102, 505);
//this.Name = "mainform";
            this.Text = "Form Simulator from Cistoner";
            this.Load += new System.EventHandler(this.main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox inputName;
        private System.Windows.Forms.TextBox inputData;
        private System.Windows.Forms.Label Name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox url;
        private System.Windows.Forms.TextBox query;
        private System.Windows.Forms.RichTextBox logrtb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox response;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ProgressBar pb;
        private System.Windows.Forms.Button sendButton;
        private System.Windows.Forms.Button clearbutton;
        private System.ComponentModel.BackgroundWorker requester;
    }
}

