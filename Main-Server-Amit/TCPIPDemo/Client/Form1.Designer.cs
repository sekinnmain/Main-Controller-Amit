namespace Client
{
    partial class Form1
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
            this.port_Client_txt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.host_client_txt = new System.Windows.Forms.TextBox();
            this.connect_btn = new System.Windows.Forms.Button();
            this.massage_txt = new System.Windows.Forms.TextBox();
            this.send_btn = new System.Windows.Forms.Button();
            this.status_txt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // port_Client_txt
            // 
            this.port_Client_txt.Location = new System.Drawing.Point(403, 36);
            this.port_Client_txt.Multiline = true;
            this.port_Client_txt.Name = "port_Client_txt";
            this.port_Client_txt.Size = new System.Drawing.Size(111, 42);
            this.port_Client_txt.TabIndex = 10;
            this.port_Client_txt.Text = "8910";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(322, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 32);
            this.label2.TabIndex = 9;
            this.label2.Text = "Port:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 32);
            this.label1.TabIndex = 8;
            this.label1.Text = "Host:";
            // 
            // host_client_txt
            // 
            this.host_client_txt.Location = new System.Drawing.Point(120, 36);
            this.host_client_txt.Multiline = true;
            this.host_client_txt.Name = "host_client_txt";
            this.host_client_txt.Size = new System.Drawing.Size(180, 42);
            this.host_client_txt.TabIndex = 7;
            this.host_client_txt.Text = "127.0.0.1";
            this.host_client_txt.TextChanged += new System.EventHandler(this.host_txt_TextChanged);
            // 
            // connect_btn
            // 
            this.connect_btn.Location = new System.Drawing.Point(572, 36);
            this.connect_btn.Name = "connect_btn";
            this.connect_btn.Size = new System.Drawing.Size(194, 48);
            this.connect_btn.TabIndex = 6;
            this.connect_btn.Text = "Connect";
            this.connect_btn.UseVisualStyleBackColor = true;
            this.connect_btn.Click += new System.EventHandler(this.connect_btn_Click);
            // 
            // massage_txt
            // 
            this.massage_txt.Location = new System.Drawing.Point(12, 90);
            this.massage_txt.Multiline = true;
            this.massage_txt.Name = "massage_txt";
            this.massage_txt.Size = new System.Drawing.Size(1107, 142);
            this.massage_txt.TabIndex = 11;
            // 
            // send_btn
            // 
            this.send_btn.Location = new System.Drawing.Point(930, 254);
            this.send_btn.Name = "send_btn";
            this.send_btn.Size = new System.Drawing.Size(175, 55);
            this.send_btn.TabIndex = 12;
            this.send_btn.Text = "Send";
            this.send_btn.UseVisualStyleBackColor = true;
            this.send_btn.Click += new System.EventHandler(this.send_btn_Click);
            // 
            // status_txt
            // 
            this.status_txt.Location = new System.Drawing.Point(12, 315);
            this.status_txt.Multiline = true;
            this.status_txt.Name = "status_txt";
            this.status_txt.Size = new System.Drawing.Size(1093, 293);
            this.status_txt.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1131, 620);
            this.Controls.Add(this.status_txt);
            this.Controls.Add(this.send_btn);
            this.Controls.Add(this.massage_txt);
            this.Controls.Add(this.port_Client_txt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.host_client_txt);
            this.Controls.Add(this.connect_btn);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Client";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox port_Client_txt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox host_client_txt;
        private System.Windows.Forms.Button connect_btn;
        private System.Windows.Forms.TextBox massage_txt;
        private System.Windows.Forms.Button send_btn;
        private System.Windows.Forms.TextBox status_txt;
    }
}

