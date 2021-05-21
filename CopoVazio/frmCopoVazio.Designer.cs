
namespace CopoVazio
{
    partial class frmCopoVazio
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblVida = new System.Windows.Forms.Label();
            this.lblArmadura = new System.Windows.Forms.Label();
            this.lblRaca = new System.Windows.Forms.Label();
            this.lblClasse = new System.Windows.Forms.Label();
            this.lblNivel = new System.Windows.Forms.Label();
            this.lblHP = new System.Windows.Forms.Label();
            this.lblCAH = new System.Windows.Forms.Label();
            this.lblRacaEscolhida = new System.Windows.Forms.Label();
            this.lblClasseEscolhida = new System.Windows.Forms.Label();
            this.lblNivelAtual = new System.Windows.Forms.Label();
            this.gbInventario = new System.Windows.Forms.GroupBox();
            this.gbMissaoPrincipal = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rtxtTextoDoJogo = new System.Windows.Forms.RichTextBox();
            this.cbItemAtual = new System.Windows.Forms.ComboBox();
            this.btnUsar = new System.Windows.Forms.Button();
            this.gbMissaoPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblVida
            // 
            this.lblVida.AutoSize = true;
            this.lblVida.Location = new System.Drawing.Point(12, 9);
            this.lblVida.Name = "lblVida";
            this.lblVida.Size = new System.Drawing.Size(58, 13);
            this.lblVida.TabIndex = 0;
            this.lblVida.Text = "Vida Atual:";
            // 
            // lblArmadura
            // 
            this.lblArmadura.AutoSize = true;
            this.lblArmadura.Location = new System.Drawing.Point(12, 32);
            this.lblArmadura.Name = "lblArmadura";
            this.lblArmadura.Size = new System.Drawing.Size(55, 13);
            this.lblArmadura.TabIndex = 1;
            this.lblArmadura.Text = "Armadura:";
            this.lblArmadura.Click += new System.EventHandler(this.lblArmadura_Click);
            // 
            // lblRaca
            // 
            this.lblRaca.AutoSize = true;
            this.lblRaca.Location = new System.Drawing.Point(12, 55);
            this.lblRaca.Name = "lblRaca";
            this.lblRaca.Size = new System.Drawing.Size(36, 13);
            this.lblRaca.TabIndex = 2;
            this.lblRaca.Text = "Raça:";
            // 
            // lblClasse
            // 
            this.lblClasse.AutoSize = true;
            this.lblClasse.Location = new System.Drawing.Point(12, 77);
            this.lblClasse.Name = "lblClasse";
            this.lblClasse.Size = new System.Drawing.Size(41, 13);
            this.lblClasse.TabIndex = 3;
            this.lblClasse.Text = "Classe:";
            // 
            // lblNivel
            // 
            this.lblNivel.AutoSize = true;
            this.lblNivel.Location = new System.Drawing.Point(12, 101);
            this.lblNivel.Name = "lblNivel";
            this.lblNivel.Size = new System.Drawing.Size(36, 13);
            this.lblNivel.TabIndex = 4;
            this.lblNivel.Text = "Nível:";
            // 
            // lblHP
            // 
            this.lblHP.AutoSize = true;
            this.lblHP.Location = new System.Drawing.Point(76, 9);
            this.lblHP.Name = "lblHP";
            this.lblHP.Size = new System.Drawing.Size(35, 13);
            this.lblHP.TabIndex = 5;
            this.lblHP.Text = "label1";
            this.lblHP.Click += new System.EventHandler(this.lblHP_Click);
            // 
            // lblCAH
            // 
            this.lblCAH.AutoSize = true;
            this.lblCAH.Location = new System.Drawing.Point(73, 32);
            this.lblCAH.Name = "lblCAH";
            this.lblCAH.Size = new System.Drawing.Size(35, 13);
            this.lblCAH.TabIndex = 6;
            this.lblCAH.Text = "label2";
            this.lblCAH.Click += new System.EventHandler(this.lblCAH_Click);
            // 
            // lblRacaEscolhida
            // 
            this.lblRacaEscolhida.AutoSize = true;
            this.lblRacaEscolhida.Location = new System.Drawing.Point(54, 55);
            this.lblRacaEscolhida.Name = "lblRacaEscolhida";
            this.lblRacaEscolhida.Size = new System.Drawing.Size(35, 13);
            this.lblRacaEscolhida.TabIndex = 7;
            this.lblRacaEscolhida.Text = "label3";
            // 
            // lblClasseEscolhida
            // 
            this.lblClasseEscolhida.AutoSize = true;
            this.lblClasseEscolhida.Location = new System.Drawing.Point(59, 77);
            this.lblClasseEscolhida.Name = "lblClasseEscolhida";
            this.lblClasseEscolhida.Size = new System.Drawing.Size(35, 13);
            this.lblClasseEscolhida.TabIndex = 8;
            this.lblClasseEscolhida.Text = "label4";
            this.lblClasseEscolhida.Click += new System.EventHandler(this.lblClasseEscolhida_Click);
            // 
            // lblNivelAtual
            // 
            this.lblNivelAtual.AutoSize = true;
            this.lblNivelAtual.Location = new System.Drawing.Point(54, 101);
            this.lblNivelAtual.Name = "lblNivelAtual";
            this.lblNivelAtual.Size = new System.Drawing.Size(35, 13);
            this.lblNivelAtual.TabIndex = 9;
            this.lblNivelAtual.Text = "label5";
            this.lblNivelAtual.Click += new System.EventHandler(this.lblNivelAtual_Click);
            // 
            // gbInventario
            // 
            this.gbInventario.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.gbInventario.ForeColor = System.Drawing.SystemColors.ControlText;
            this.gbInventario.Location = new System.Drawing.Point(13, 145);
            this.gbInventario.Name = "gbInventario";
            this.gbInventario.Size = new System.Drawing.Size(238, 308);
            this.gbInventario.TabIndex = 10;
            this.gbInventario.TabStop = false;
            this.gbInventario.Text = "Inventário";
            this.gbInventario.Enter += new System.EventHandler(this.gbInventario_Enter);
            // 
            // gbMissaoPrincipal
            // 
            this.gbMissaoPrincipal.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.gbMissaoPrincipal.Controls.Add(this.label1);
            this.gbMissaoPrincipal.Location = new System.Drawing.Point(13, 460);
            this.gbMissaoPrincipal.Name = "gbMissaoPrincipal";
            this.gbMissaoPrincipal.Size = new System.Drawing.Size(238, 87);
            this.gbMissaoPrincipal.TabIndex = 11;
            this.gbMissaoPrincipal.TabStop = false;
            this.gbMissaoPrincipal.Text = "Missão Principal";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pegar o copo para não morrer!";
            // 
            // rtxtTextoDoJogo
            // 
            this.rtxtTextoDoJogo.Location = new System.Drawing.Point(319, 145);
            this.rtxtTextoDoJogo.Name = "rtxtTextoDoJogo";
            this.rtxtTextoDoJogo.Size = new System.Drawing.Size(302, 363);
            this.rtxtTextoDoJogo.TabIndex = 12;
            this.rtxtTextoDoJogo.Text = "";
            // 
            // cbItemAtual
            // 
            this.cbItemAtual.FormattingEnabled = true;
            this.cbItemAtual.Location = new System.Drawing.Point(352, 526);
            this.cbItemAtual.Name = "cbItemAtual";
            this.cbItemAtual.Size = new System.Drawing.Size(151, 21);
            this.cbItemAtual.TabIndex = 13;
            // 
            // btnUsar
            // 
            this.btnUsar.Location = new System.Drawing.Point(526, 524);
            this.btnUsar.Name = "btnUsar";
            this.btnUsar.Size = new System.Drawing.Size(84, 22);
            this.btnUsar.TabIndex = 14;
            this.btnUsar.Text = "Usar";
            this.btnUsar.UseVisualStyleBackColor = true;
            // 
            // frmCopoVazio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 681);
            this.Controls.Add(this.btnUsar);
            this.Controls.Add(this.cbItemAtual);
            this.Controls.Add(this.rtxtTextoDoJogo);
            this.Controls.Add(this.gbMissaoPrincipal);
            this.Controls.Add(this.gbInventario);
            this.Controls.Add(this.lblNivelAtual);
            this.Controls.Add(this.lblClasseEscolhida);
            this.Controls.Add(this.lblRacaEscolhida);
            this.Controls.Add(this.lblCAH);
            this.Controls.Add(this.lblHP);
            this.Controls.Add(this.lblNivel);
            this.Controls.Add(this.lblClasse);
            this.Controls.Add(this.lblRaca);
            this.Controls.Add(this.lblArmadura);
            this.Controls.Add(this.lblVida);
            this.Name = "frmCopoVazio";
            this.Text = "Copo Vazio";
            this.Load += new System.EventHandler(this.frmCopoVazio_Load);
            this.gbMissaoPrincipal.ResumeLayout(false);
            this.gbMissaoPrincipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblVida;
        private System.Windows.Forms.Label lblArmadura;
        private System.Windows.Forms.Label lblRaca;
        private System.Windows.Forms.Label lblClasse;
        private System.Windows.Forms.Label lblNivel;
        private System.Windows.Forms.Label lblHP;
        private System.Windows.Forms.Label lblCAH;
        private System.Windows.Forms.Label lblRacaEscolhida;
        private System.Windows.Forms.Label lblClasseEscolhida;
        private System.Windows.Forms.Label lblNivelAtual;
        private System.Windows.Forms.GroupBox gbInventario;
        private System.Windows.Forms.GroupBox gbMissaoPrincipal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox rtxtTextoDoJogo;
        private System.Windows.Forms.ComboBox cbItemAtual;
        private System.Windows.Forms.Button btnUsar;
    }
}

