namespace WA_Abbeveratorio
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
            this.components = new System.ComponentModel.Container();
            this.btn_preallarme_cibo = new System.Windows.Forms.Button();
            this.btn_allarme_cibo = new System.Windows.Forms.Button();
            this.btn_preallarme_acqua = new System.Windows.Forms.Button();
            this.btn_allarme_acqua = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.btn_sms = new System.Windows.Forms.Button();
            this.lbl_notifica = new System.Windows.Forms.Label();
            this.timer_notifica = new System.Windows.Forms.Timer(this.components);
            this.rb_sim1 = new System.Windows.Forms.RadioButton();
            this.rb_sim2 = new System.Windows.Forms.RadioButton();
            this.rb_sim3 = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_preallarme_cibo
            // 
            this.btn_preallarme_cibo.Location = new System.Drawing.Point(117, 102);
            this.btn_preallarme_cibo.Name = "btn_preallarme_cibo";
            this.btn_preallarme_cibo.Size = new System.Drawing.Size(75, 46);
            this.btn_preallarme_cibo.TabIndex = 0;
            this.btn_preallarme_cibo.Text = "Preallarme";
            this.btn_preallarme_cibo.UseVisualStyleBackColor = true;
            this.btn_preallarme_cibo.Click += new System.EventHandler(this.btn_pre1_Click);
            // 
            // btn_allarme_cibo
            // 
            this.btn_allarme_cibo.Location = new System.Drawing.Point(117, 172);
            this.btn_allarme_cibo.Name = "btn_allarme_cibo";
            this.btn_allarme_cibo.Size = new System.Drawing.Size(75, 46);
            this.btn_allarme_cibo.TabIndex = 1;
            this.btn_allarme_cibo.Text = "Allarme";
            this.btn_allarme_cibo.UseVisualStyleBackColor = true;
            this.btn_allarme_cibo.Click += new System.EventHandler(this.btn_allarme_Click);
            // 
            // btn_preallarme_acqua
            // 
            this.btn_preallarme_acqua.Location = new System.Drawing.Point(290, 102);
            this.btn_preallarme_acqua.Name = "btn_preallarme_acqua";
            this.btn_preallarme_acqua.Size = new System.Drawing.Size(75, 46);
            this.btn_preallarme_acqua.TabIndex = 2;
            this.btn_preallarme_acqua.Text = "Preallarme";
            this.btn_preallarme_acqua.UseVisualStyleBackColor = true;
            this.btn_preallarme_acqua.Click += new System.EventHandler(this.button3_Click);
            // 
            // btn_allarme_acqua
            // 
            this.btn_allarme_acqua.Location = new System.Drawing.Point(290, 172);
            this.btn_allarme_acqua.Name = "btn_allarme_acqua";
            this.btn_allarme_acqua.Size = new System.Drawing.Size(75, 46);
            this.btn_allarme_acqua.TabIndex = 3;
            this.btn_allarme_acqua.Text = "Allarme";
            this.btn_allarme_acqua.UseVisualStyleBackColor = true;
            this.btn_allarme_acqua.Click += new System.EventHandler(this.button4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(128, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 21);
            this.label1.TabIndex = 4;
            this.label1.Text = "Client Preallarme/allarme";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(114, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Cibo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(287, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Acqua";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(117, 353);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 49);
            this.button5.TabIndex = 7;
            this.button5.Text = "Keep Alive";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // btn_sms
            // 
            this.btn_sms.Location = new System.Drawing.Point(290, 353);
            this.btn_sms.Name = "btn_sms";
            this.btn_sms.Size = new System.Drawing.Size(75, 49);
            this.btn_sms.TabIndex = 8;
            this.btn_sms.Text = "Send sms";
            this.btn_sms.UseVisualStyleBackColor = true;
            this.btn_sms.Click += new System.EventHandler(this.btn_sms_Click);
            // 
            // lbl_notifica
            // 
            this.lbl_notifica.AutoSize = true;
            this.lbl_notifica.Font = new System.Drawing.Font("Yu Gothic", 15.75F);
            this.lbl_notifica.Location = new System.Drawing.Point(127, 30);
            this.lbl_notifica.Name = "lbl_notifica";
            this.lbl_notifica.Size = new System.Drawing.Size(217, 27);
            this.lbl_notifica.TabIndex = 10;
            this.lbl_notifica.Text = "Notifica: SMS Inviato";
            this.lbl_notifica.Visible = false;
            // 
            // timer_notifica
            // 
            this.timer_notifica.Interval = 1;
            this.timer_notifica.Tick += new System.EventHandler(this.timer_notifica_Tick);
            // 
            // rb_sim1
            // 
            this.rb_sim1.AutoSize = true;
            this.rb_sim1.Location = new System.Drawing.Point(132, 286);
            this.rb_sim1.Name = "rb_sim1";
            this.rb_sim1.Size = new System.Drawing.Size(103, 17);
            this.rb_sim1.TabIndex = 11;
            this.rb_sim1.TabStop = true;
            this.rb_sim1.Text = "+393517221757";
            this.rb_sim1.UseVisualStyleBackColor = true;
            // 
            // rb_sim2
            // 
            this.rb_sim2.AutoSize = true;
            this.rb_sim2.Location = new System.Drawing.Point(241, 286);
            this.rb_sim2.Name = "rb_sim2";
            this.rb_sim2.Size = new System.Drawing.Size(103, 17);
            this.rb_sim2.TabIndex = 12;
            this.rb_sim2.TabStop = true;
            this.rb_sim2.Text = "+393405030840";
            this.rb_sim2.UseVisualStyleBackColor = true;
            // 
            // rb_sim3
            // 
            this.rb_sim3.AutoSize = true;
            this.rb_sim3.Location = new System.Drawing.Point(189, 309);
            this.rb_sim3.Name = "rb_sim3";
            this.rb_sim3.Size = new System.Drawing.Size(103, 17);
            this.rb_sim3.TabIndex = 13;
            this.rb_sim3.TabStop = true;
            this.rb_sim3.Text = "+393337728453";
            this.rb_sim3.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(145, 252);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(180, 21);
            this.label4.TabIndex = 14;
            this.label4.Text = "Scegliere la postazione";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WA_Abbeveratorio.Properties.Resources._120_1207490_pear_logo_png_transparent_pear_phone_logo_png;
            this.pictureBox1.Location = new System.Drawing.Point(397, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.rb_sim3);
            this.Controls.Add(this.rb_sim2);
            this.Controls.Add(this.rb_sim1);
            this.Controls.Add(this.lbl_notifica);
            this.Controls.Add(this.btn_sms);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_allarme_acqua);
            this.Controls.Add(this.btn_preallarme_acqua);
            this.Controls.Add(this.btn_allarme_cibo);
            this.Controls.Add(this.btn_preallarme_cibo);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_preallarme_cibo;
        private System.Windows.Forms.Button btn_preallarme_acqua;
        private System.Windows.Forms.Button btn_allarme_acqua;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button btn_allarme_cibo;
        private System.Windows.Forms.Button btn_sms;
        private System.Windows.Forms.Label lbl_notifica;
        private System.Windows.Forms.Timer timer_notifica;
        private System.Windows.Forms.RadioButton rb_sim1;
        private System.Windows.Forms.RadioButton rb_sim2;
        private System.Windows.Forms.RadioButton rb_sim3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

