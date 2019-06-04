namespace TCPIPDemo
{
    partial class Server
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
            this.stop_btn = new System.Windows.Forms.Button();
            this.start_btn = new System.Windows.Forms.Button();
            this.host_txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.port_txt = new System.Windows.Forms.TextBox();
            this.status_txt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // stop_btn
            // 
            this.stop_btn.Location = new System.Drawing.Point(847, 60);
            this.stop_btn.Name = "stop_btn";
            this.stop_btn.Size = new System.Drawing.Size(194, 48);
            this.stop_btn.TabIndex = 0;
            this.stop_btn.Text = "Stop";
            this.stop_btn.UseVisualStyleBackColor = true;
            this.stop_btn.Click += new System.EventHandler(this.stop_btn_Click);
            // 
            // start_btn
            // 
            this.start_btn.Location = new System.Drawing.Point(609, 60);
            this.start_btn.Name = "start_btn";
            this.start_btn.Size = new System.Drawing.Size(194, 48);
            this.start_btn.TabIndex = 1;
            this.start_btn.Text = "Start";
            this.start_btn.UseVisualStyleBackColor = true;
            this.start_btn.Click += new System.EventHandler(this.start_btn_Click);
            // 
            // host_txt
            // 
            this.host_txt.Location = new System.Drawing.Point(99, 66);
            this.host_txt.Multiline = true;
            this.host_txt.Name = "host_txt";
            this.host_txt.Size = new System.Drawing.Size(180, 42);
            this.host_txt.TabIndex = 2;
            this.host_txt.Text = "127.0.0.1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 32);
            this.label1.TabIndex = 3;
            this.label1.Text = "Host:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(301, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 32);
            this.label2.TabIndex = 4;
            this.label2.Text = "Port:";
            // 
            // port_txt
            // 
            this.port_txt.Location = new System.Drawing.Point(382, 66);
            this.port_txt.Multiline = true;
            this.port_txt.Name = "port_txt";
            this.port_txt.Size = new System.Drawing.Size(111, 42);
            this.port_txt.TabIndex = 5;
            this.port_txt.Text = "8910";
            // 
            // status_txt
            // 
            this.status_txt.Location = new System.Drawing.Point(18, 133);
            this.status_txt.Multiline = true;
            this.status_txt.Name = "status_txt";
            this.status_txt.Size = new System.Drawing.Size(1015, 305);
            this.status_txt.TabIndex = 6;
            // 
            // Server
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 450);
            this.Controls.Add(this.status_txt);
            this.Controls.Add(this.port_txt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.host_txt);
            this.Controls.Add(this.start_btn);
            this.Controls.Add(this.stop_btn);
            this.Name = "Server";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Server_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button stop_btn;
        private System.Windows.Forms.Button start_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox port_txt;
        private System.Windows.Forms.TextBox status_txt;
        public System.Windows.Forms.TextBox host_txt;
    }
}

