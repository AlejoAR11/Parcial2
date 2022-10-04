namespace Segundo_parcial
{
    partial class Frase
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtSoda = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEminem = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBadBunny = new System.Windows.Forms.TextBox();
            this.btnEnd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(402, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Puntos";
            // 
            // txtSoda
            // 
            this.txtSoda.Location = new System.Drawing.Point(173, 66);
            this.txtSoda.Name = "txtSoda";
            this.txtSoda.Size = new System.Drawing.Size(127, 20);
            this.txtSoda.TabIndex = 2;
            this.txtSoda.TextChanged += new System.EventHandler(this.txtSoda_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "No quiero soñar ... mente";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Now this looks ... me";
            // 
            // txtEminem
            // 
            this.txtEminem.Location = new System.Drawing.Point(173, 120);
            this.txtEminem.Name = "txtEminem";
            this.txtEminem.Size = new System.Drawing.Size(127, 20);
            this.txtEminem.TabIndex = 4;
            this.txtEminem.TextChanged += new System.EventHandler(this.txtEminem_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Hoy sí o sí yo me.. mío";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtBadBunny
            // 
            this.txtBadBunny.Location = new System.Drawing.Point(173, 175);
            this.txtBadBunny.Name = "txtBadBunny";
            this.txtBadBunny.Size = new System.Drawing.Size(127, 20);
            this.txtBadBunny.TabIndex = 6;
            this.txtBadBunny.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnEnd
            // 
            this.btnEnd.Location = new System.Drawing.Point(93, 240);
            this.btnEnd.Name = "btnEnd";
            this.btnEnd.Size = new System.Drawing.Size(105, 52);
            this.btnEnd.TabIndex = 8;
            this.btnEnd.Text = "Finalizar";
            this.btnEnd.UseVisualStyleBackColor = true;
            this.btnEnd.Click += new System.EventHandler(this.btnEnd_Click);
            // 
            // Frase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 356);
            this.Controls.Add(this.btnEnd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtBadBunny);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtEminem);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSoda);
            this.Controls.Add(this.label1);
            this.Name = "Frase";
            this.Text = "Completar la frase";
            this.Load += new System.EventHandler(this.Frase_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSoda;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEminem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBadBunny;
        private System.Windows.Forms.Button btnEnd;
    }
}