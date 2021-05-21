
namespace CopoVazio
{
    partial class frmLoreECriacao
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
            this.lblLore = new System.Windows.Forms.Label();
            this.lblLore2 = new System.Windows.Forms.Label();
            this.lblLore3 = new System.Windows.Forms.Label();
            this.lblLore4 = new System.Windows.Forms.Label();
            this.btnCriarPersonagem = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblLore
            // 
            this.lblLore.AutoEllipsis = true;
            this.lblLore.AutoSize = true;
            this.lblLore.Location = new System.Drawing.Point(12, 9);
            this.lblLore.Name = "lblLore";
            this.lblLore.Size = new System.Drawing.Size(380, 13);
            this.lblLore.TabIndex = 0;
            this.lblLore.Text = "Você esta em uma taverna para pagar as suas dividas com o taverneiro, porém";
            this.lblLore.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblLore.Click += new System.EventHandler(this.lblLore_Click);
            // 
            // lblLore2
            // 
            this.lblLore2.AutoSize = true;
            this.lblLore2.Location = new System.Drawing.Point(12, 32);
            this.lblLore2.Name = "lblLore2";
            this.lblLore2.Size = new System.Drawing.Size(372, 13);
            this.lblLore2.TabIndex = 1;
            this.lblLore2.Text = "percebe que foi roubado e tenta convecer o taverneiro que aquilo é verdade,";
            // 
            // lblLore3
            // 
            this.lblLore3.AutoSize = true;
            this.lblLore3.Location = new System.Drawing.Point(12, 54);
            this.lblLore3.Name = "lblLore3";
            this.lblLore3.Size = new System.Drawing.Size(370, 13);
            this.lblLore3.TabIndex = 2;
            this.lblLore3.Text = "mas ele não acredita, então ele lhe dá duas opções, morrer na guilhotinha ou";
            // 
            // lblLore4
            // 
            this.lblLore4.AutoSize = true;
            this.lblLore4.Location = new System.Drawing.Point(12, 78);
            this.lblLore4.Name = "lblLore4";
            this.lblLore4.Size = new System.Drawing.Size(331, 13);
            this.lblLore4.TabIndex = 3;
            this.lblLore4.Text = "ou entrar em uma masmora e pegar O Copo Que Sempre Está Cheio.";
            // 
            // btnCriarPersonagem
            // 
            this.btnCriarPersonagem.Location = new System.Drawing.Point(110, 116);
            this.btnCriarPersonagem.Name = "btnCriarPersonagem";
            this.btnCriarPersonagem.Size = new System.Drawing.Size(157, 23);
            this.btnCriarPersonagem.TabIndex = 4;
            this.btnCriarPersonagem.Text = "Criar Personagem";
            this.btnCriarPersonagem.UseVisualStyleBackColor = true;
            this.btnCriarPersonagem.Click += new System.EventHandler(this.btnCriarPersonagem_Click);
            // 
            // frmLoreECriacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 190);
            this.Controls.Add(this.btnCriarPersonagem);
            this.Controls.Add(this.lblLore4);
            this.Controls.Add(this.lblLore3);
            this.Controls.Add(this.lblLore2);
            this.Controls.Add(this.lblLore);
            this.Name = "frmLoreECriacao";
            this.Text = "Lore E Criacao de Pesonaem";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLore;
        private System.Windows.Forms.Label lblLore2;
        private System.Windows.Forms.Label lblLore3;
        private System.Windows.Forms.Label lblLore4;
        private System.Windows.Forms.Button btnCriarPersonagem;
    }
}