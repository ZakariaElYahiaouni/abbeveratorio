namespace WA_Abbeveratorio
{
    partial class SinotticoHome
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
            this.txt_postazioni = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_inviaPostazioni = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_postazioni
            // 
            this.txt_postazioni.Location = new System.Drawing.Point(107, 209);
            this.txt_postazioni.Name = "txt_postazioni";
            this.txt_postazioni.Size = new System.Drawing.Size(319, 20);
            this.txt_postazioni.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(102, 179);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(551, 27);
            this.label1.TabIndex = 1;
            this.label1.Text = "Inserisci il numero di postazioni(massimo 3 postazioni)";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btn_inviaPostazioni
            // 
            this.btn_inviaPostazioni.Location = new System.Drawing.Point(458, 207);
            this.btn_inviaPostazioni.Name = "btn_inviaPostazioni";
            this.btn_inviaPostazioni.Size = new System.Drawing.Size(176, 23);
            this.btn_inviaPostazioni.TabIndex = 2;
            this.btn_inviaPostazioni.Text = "Invia";
            this.btn_inviaPostazioni.UseVisualStyleBackColor = true;
            this.btn_inviaPostazioni.Click += new System.EventHandler(this.btn_inviaPostazioni_Click);
            // 
            // SinotticoHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_inviaPostazioni);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_postazioni);
            this.Name = "SinotticoHome";
            this.Text = "SinotticoHome";
            this.Load += new System.EventHandler(this.SinotticoHome_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_postazioni;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_inviaPostazioni;
    }
}