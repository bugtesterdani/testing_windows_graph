namespace testing_windows_graph
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tBox_dPath = new TextBox();
            label1 = new Label();
            label2 = new Label();
            tBox_fPath = new TextBox();
            label3 = new Label();
            tBox_cID = new TextBox();
            btn_Request = new Button();
            label4 = new Label();
            lbl_Status = new Label();
            SuspendLayout();
            // 
            // tBox_dPath
            // 
            tBox_dPath.Location = new Point(97, 12);
            tBox_dPath.Name = "tBox_dPath";
            tBox_dPath.Size = new Size(360, 23);
            tBox_dPath.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 15);
            label1.Name = "label1";
            label1.Size = new Size(79, 15);
            label1.TabIndex = 1;
            label1.Text = "Domain Pfad:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 44);
            label2.Name = "label2";
            label2.Size = new Size(55, 15);
            label2.TabIndex = 2;
            label2.Text = "File Path:";
            // 
            // tBox_fPath
            // 
            tBox_fPath.Location = new Point(97, 41);
            tBox_fPath.Name = "tBox_fPath";
            tBox_fPath.Size = new Size(360, 23);
            tBox_fPath.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 73);
            label3.Name = "label3";
            label3.Size = new Size(55, 15);
            label3.TabIndex = 4;
            label3.Text = "Client ID:";
            // 
            // tBox_cID
            // 
            tBox_cID.Location = new Point(97, 70);
            tBox_cID.Name = "tBox_cID";
            tBox_cID.Size = new Size(360, 23);
            tBox_cID.TabIndex = 5;
            // 
            // btn_Request
            // 
            btn_Request.Location = new Point(382, 99);
            btn_Request.Name = "btn_Request";
            btn_Request.Size = new Size(75, 44);
            btn_Request.TabIndex = 6;
            btn_Request.Text = "Send Request";
            btn_Request.UseVisualStyleBackColor = true;
            btn_Request.Click += btn_Request_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 114);
            label4.Name = "label4";
            label4.Size = new Size(42, 15);
            label4.TabIndex = 7;
            label4.Text = "Status:";
            // 
            // lbl_Status
            // 
            lbl_Status.AutoSize = true;
            lbl_Status.Location = new Point(97, 114);
            lbl_Status.Name = "lbl_Status";
            lbl_Status.Size = new Size(72, 15);
            lbl_Status.TabIndex = 8;
            lbl_Status.Text = "Not running";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(468, 158);
            Controls.Add(lbl_Status);
            Controls.Add(label4);
            Controls.Add(btn_Request);
            Controls.Add(tBox_cID);
            Controls.Add(label3);
            Controls.Add(tBox_fPath);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tBox_dPath);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tBox_dPath;
        private Label label1;
        private Label label2;
        private TextBox tBox_fPath;
        private Label label3;
        private TextBox tBox_cID;
        private Button btn_Request;
        private Label label4;
        private Label lbl_Status;
    }
}
