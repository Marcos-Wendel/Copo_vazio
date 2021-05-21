
namespace CopoVazio
{
    partial class frmCriarPersonagem
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
            this.lblRacas = new System.Windows.Forms.Label();
            this.lblClasses = new System.Windows.Forms.Label();
            this.cbRacas = new System.Windows.Forms.ComboBox();
            this.cbClasse = new System.Windows.Forms.ComboBox();
            this.btnConfirmarIniciar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblRacas
            // 
            this.lblRacas.AutoSize = true;
            this.lblRacas.Location = new System.Drawing.Point(13, 13);
            this.lblRacas.Name = "lblRacas";
            this.lblRacas.Size = new System.Drawing.Size(41, 13);
            this.lblRacas.TabIndex = 0;
            this.lblRacas.Text = "Raças:";
            // 
            // lblClasses
            // 
            this.lblClasses.AutoSize = true;
            this.lblClasses.Location = new System.Drawing.Point(13, 41);
            this.lblClasses.Name = "lblClasses";
            this.lblClasses.Size = new System.Drawing.Size(46, 13);
            this.lblClasses.TabIndex = 1;
            this.lblClasses.Text = "Classes:";
            // 
            // cbRacas
            // 
            this.cbRacas.FormattingEnabled = true;
            this.cbRacas.Items.AddRange(new object[] {
            "Humano",
            "Elfo",
            "Anão",
            "Orc"});
            this.cbRacas.Location = new System.Drawing.Point(65, 10);
            this.cbRacas.Name = "cbRacas";
            this.cbRacas.Size = new System.Drawing.Size(132, 21);
            this.cbRacas.TabIndex = 2;
            // 
            // cbClasse
            // 
            this.cbClasse.FormattingEnabled = true;
            this.cbClasse.Items.AddRange(new object[] {
            "Guerreiro",
            "Monge",
            "Barbáro",
            "Mago",
            "Arqueiro",
            "Ladino",
            ""});
            this.cbClasse.Location = new System.Drawing.Point(65, 38);
            this.cbClasse.Name = "cbClasse";
            this.cbClasse.Size = new System.Drawing.Size(132, 21);
            this.cbClasse.TabIndex = 3;
            // 
            // btnConfirmarIniciar
            // 
            this.btnConfirmarIniciar.Location = new System.Drawing.Point(101, 118);
            this.btnConfirmarIniciar.Name = "btnConfirmarIniciar";
            this.btnConfirmarIniciar.Size = new System.Drawing.Size(134, 23);
            this.btnConfirmarIniciar.TabIndex = 4;
            this.btnConfirmarIniciar.Text = "Confirmar e Inicar Jogo";
            this.btnConfirmarIniciar.UseVisualStyleBackColor = true;
            this.btnConfirmarIniciar.Click += new System.EventHandler(this.btnConfirmarIniciar_Click);
            // 
            // frmCriarPersonagem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 200);
            this.Controls.Add(this.btnConfirmarIniciar);
            this.Controls.Add(this.cbClasse);
            this.Controls.Add(this.cbRacas);
            this.Controls.Add(this.lblClasses);
            this.Controls.Add(this.lblRacas);
            this.Name = "frmCriarPersonagem";
            this.Text = "Criar Personagem";
            this.Load += new System.EventHandler(this.frmCriarPersonagem_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRacas;
        private System.Windows.Forms.Label lblClasses;
        private System.Windows.Forms.ComboBox cbRacas;
        private System.Windows.Forms.ComboBox cbClasse;
        private System.Windows.Forms.Button btnConfirmarIniciar;
    }
}