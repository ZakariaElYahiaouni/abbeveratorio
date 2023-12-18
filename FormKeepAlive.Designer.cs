namespace WA_Abbeveratorio
{
    partial class FormKeepAlive
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
            this.btn_keepAlive = new System.Windows.Forms.Button();
            this.lbl_header = new System.Windows.Forms.Label();
            this.btn_back = new System.Windows.Forms.Button();
            this.timerInvio = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // btn_keepAlive
            // 
            this.btn_keepAlive.Location = new System.Drawing.Point(23, 35);
            this.btn_keepAlive.Name = "btn_keepAlive";
            this.btn_keepAlive.Size = new System.Drawing.Size(181, 97);
            this.btn_keepAlive.TabIndex = 0;
            this.btn_keepAlive.Text = "Send Keep Alive";
            this.btn_keepAlive.UseVisualStyleBackColor = true;
            this.btn_keepAlive.Click += new System.EventHandler(this.btn_keepAlive_Click);
            // 
            // lbl_header
            // 
            this.lbl_header.AutoSize = true;
            this.lbl_header.Font = new System.Drawing.Font("Yu Gothic", 15.75F);
            this.lbl_header.Location = new System.Drawing.Point(50, 5);
            this.lbl_header.Name = "lbl_header";
            this.lbl_header.Size = new System.Drawing.Size(132, 27);
            this.lbl_header.TabIndex = 1;
            this.lbl_header.Text = "Postazione1";
            this.lbl_header.Click += new System.EventHandler(this.lbl_header_Click);
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(23, 157);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(89, 35);
            this.btn_back.TabIndex = 2;
            this.btn_back.Text = "Go Back";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // timerInvio
            // 
            this.timerInvio.Enabled = true;
            this.timerInvio.Interval = 60000;
            this.timerInvio.Tick += new System.EventHandler(this.timerInvio_Tick);
            // 
            // FormKeepAlive
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(231, 204);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.lbl_header);
            this.Controls.Add(this.btn_keepAlive);
            this.Name = "FormKeepAlive";
            this.Text = "FormKeepAlive";
            this.Load += new System.EventHandler(this.FormKeepAlive_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_keepAlive;
        private System.Windows.Forms.Label lbl_header;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Timer timerInvio;
    }
}