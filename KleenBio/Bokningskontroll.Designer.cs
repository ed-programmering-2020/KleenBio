namespace KleenBio
{
    partial class Bokningskontroll
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
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxTelefon = new System.Windows.Forms.TextBox();
            this.tbxEpost = new System.Windows.Forms.TextBox();
            this.tbxNamn = new System.Windows.Forms.TextBox();
            this.btnBokaplats = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(56, 249);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Välj film:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(175, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Telefon-nummer";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(175, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Epost:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(175, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Namn:";
            // 
            // tbxTelefon
            // 
            this.tbxTelefon.Location = new System.Drawing.Point(172, 225);
            this.tbxTelefon.Name = "tbxTelefon";
            this.tbxTelefon.Size = new System.Drawing.Size(114, 20);
            this.tbxTelefon.TabIndex = 14;
            // 
            // tbxEpost
            // 
            this.tbxEpost.Location = new System.Drawing.Point(172, 160);
            this.tbxEpost.Name = "tbxEpost";
            this.tbxEpost.Size = new System.Drawing.Size(114, 20);
            this.tbxEpost.TabIndex = 13;
            // 
            // tbxNamn
            // 
            this.tbxNamn.Location = new System.Drawing.Point(172, 91);
            this.tbxNamn.Name = "tbxNamn";
            this.tbxNamn.Size = new System.Drawing.Size(114, 20);
            this.tbxNamn.TabIndex = 12;
            // 
            // btnBokaplats
            // 
            this.btnBokaplats.Location = new System.Drawing.Point(172, 269);
            this.btnBokaplats.Name = "btnBokaplats";
            this.btnBokaplats.Size = new System.Drawing.Size(114, 23);
            this.btnBokaplats.TabIndex = 20;
            this.btnBokaplats.Text = "Boka din plats";
            this.btnBokaplats.UseVisualStyleBackColor = true;
            this.btnBokaplats.Click += new System.EventHandler(this.btnBokaplats_Click);
            // 
            // Bokingskontroll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 398);
            this.Controls.Add(this.btnBokaplats);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbxTelefon);
            this.Controls.Add(this.tbxEpost);
            this.Controls.Add(this.tbxNamn);
            this.Name = "Bokingskontroll";
            this.Text = "Bokingskontroll";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxTelefon;
        private System.Windows.Forms.TextBox tbxEpost;
        private System.Windows.Forms.TextBox tbxNamn;
        private System.Windows.Forms.Button btnBokaplats;
    }
}