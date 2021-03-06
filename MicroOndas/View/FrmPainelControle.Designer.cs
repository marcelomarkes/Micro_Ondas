﻿namespace View
{
    partial class FrmPainelControle
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnlpainel = new System.Windows.Forms.Panel();
            this.txtTempo = new System.Windows.Forms.MaskedTextBox();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDois = new System.Windows.Forms.Button();
            this.btnUm = new System.Windows.Forms.Button();
            this.btnZero = new System.Windows.Forms.Button();
            this.btnSete = new System.Windows.Forms.Button();
            this.btnTres = new System.Windows.Forms.Button();
            this.btnCinco = new System.Windows.Forms.Button();
            this.btnQuatro = new System.Windows.Forms.Button();
            this.btnOito = new System.Windows.Forms.Button();
            this.btnNove = new System.Windows.Forms.Button();
            this.btnSeis = new System.Windows.Forms.Button();
            this.btnCarne = new System.Windows.Forms.Button();
            this.btnFeijao = new System.Windows.Forms.Button();
            this.btnBolo = new System.Windows.Forms.Button();
            this.btnArroz = new System.Windows.Forms.Button();
            this.btnPipoca = new System.Windows.Forms.Button();
            this.pnlTela = new System.Windows.Forms.Panel();
            this.lbAquecido = new System.Windows.Forms.Label();
            this.lbTimer = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.pnlpainel.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.pnlTela.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pnlpainel);
            this.panel2.Controls.Add(this.btnIniciar);
            this.panel2.Controls.Add(this.btnCancelar);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Location = new System.Drawing.Point(648, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(287, 516);
            this.panel2.TabIndex = 8;
            // 
            // pnlpainel
            // 
            this.pnlpainel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pnlpainel.Controls.Add(this.lbTimer);
            this.pnlpainel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.pnlpainel.Location = new System.Drawing.Point(11, 7);
            this.pnlpainel.Name = "pnlpainel";
            this.pnlpainel.Size = new System.Drawing.Size(264, 100);
            this.pnlpainel.TabIndex = 17;
            // 
            // txtTempo
            // 
            this.txtTempo.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtTempo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTempo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTempo.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtTempo.Location = new System.Drawing.Point(206, 286);
            this.txtTempo.Mask = "00:00";
            this.txtTempo.Name = "txtTempo";
            this.txtTempo.PromptChar = ' ';
            this.txtTempo.Size = new System.Drawing.Size(34, 15);
            this.txtTempo.TabIndex = 15;
            this.txtTempo.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.txtTempo.ValidatingType = typeof(System.DateTime);
            this.txtTempo.Visible = false;
            // 
            // btnIniciar
            // 
            this.btnIniciar.BackColor = System.Drawing.Color.Green;
            this.btnIniciar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnIniciar.Location = new System.Drawing.Point(149, 452);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(119, 55);
            this.btnIniciar.TabIndex = 16;
            this.btnIniciar.Text = "Iniciar";
            this.btnIniciar.UseVisualStyleBackColor = false;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Red;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCancelar.Location = new System.Drawing.Point(19, 452);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(112, 55);
            this.btnCancelar.TabIndex = 15;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.txtTempo);
            this.groupBox1.Controls.Add(this.btnDois);
            this.groupBox1.Controls.Add(this.btnUm);
            this.groupBox1.Controls.Add(this.btnZero);
            this.groupBox1.Controls.Add(this.btnSete);
            this.groupBox1.Controls.Add(this.btnTres);
            this.groupBox1.Controls.Add(this.btnCinco);
            this.groupBox1.Controls.Add(this.btnQuatro);
            this.groupBox1.Controls.Add(this.btnOito);
            this.groupBox1.Controls.Add(this.btnNove);
            this.groupBox1.Controls.Add(this.btnSeis);
            this.groupBox1.Controls.Add(this.btnCarne);
            this.groupBox1.Controls.Add(this.btnFeijao);
            this.groupBox1.Controls.Add(this.btnBolo);
            this.groupBox1.Controls.Add(this.btnArroz);
            this.groupBox1.Controls.Add(this.btnPipoca);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(11, 113);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(264, 321);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipo de Alimentos";
            // 
            // btnDois
            // 
            this.btnDois.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDois.Location = new System.Drawing.Point(8, 211);
            this.btnDois.Name = "btnDois";
            this.btnDois.Size = new System.Drawing.Size(51, 43);
            this.btnDois.TabIndex = 14;
            this.btnDois.Text = "2";
            this.btnDois.UseVisualStyleBackColor = true;
            this.btnDois.Click += new System.EventHandler(this.btnDois_Click);
            // 
            // btnUm
            // 
            this.btnUm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUm.Location = new System.Drawing.Point(138, 272);
            this.btnUm.Name = "btnUm";
            this.btnUm.Size = new System.Drawing.Size(51, 43);
            this.btnUm.TabIndex = 8;
            this.btnUm.Text = "1";
            this.btnUm.UseVisualStyleBackColor = true;
            this.btnUm.Click += new System.EventHandler(this.btnUm_Click);
            // 
            // btnZero
            // 
            this.btnZero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnZero.Location = new System.Drawing.Point(72, 272);
            this.btnZero.Name = "btnZero";
            this.btnZero.Size = new System.Drawing.Size(51, 43);
            this.btnZero.TabIndex = 13;
            this.btnZero.Text = "0";
            this.btnZero.UseVisualStyleBackColor = true;
            this.btnZero.Click += new System.EventHandler(this.btnZero_Click);
            // 
            // btnSete
            // 
            this.btnSete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSete.Location = new System.Drawing.Point(72, 157);
            this.btnSete.Name = "btnSete";
            this.btnSete.Size = new System.Drawing.Size(51, 43);
            this.btnSete.TabIndex = 12;
            this.btnSete.Text = "7";
            this.btnSete.UseVisualStyleBackColor = true;
            this.btnSete.Click += new System.EventHandler(this.btnSete_Click);
            // 
            // btnTres
            // 
            this.btnTres.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTres.Location = new System.Drawing.Point(72, 211);
            this.btnTres.Name = "btnTres";
            this.btnTres.Size = new System.Drawing.Size(51, 43);
            this.btnTres.TabIndex = 11;
            this.btnTres.Text = "3";
            this.btnTres.UseVisualStyleBackColor = true;
            this.btnTres.Click += new System.EventHandler(this.btnTres_Click);
            // 
            // btnCinco
            // 
            this.btnCinco.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCinco.Location = new System.Drawing.Point(206, 211);
            this.btnCinco.Name = "btnCinco";
            this.btnCinco.Size = new System.Drawing.Size(51, 43);
            this.btnCinco.TabIndex = 10;
            this.btnCinco.Text = "5";
            this.btnCinco.UseVisualStyleBackColor = true;
            this.btnCinco.Click += new System.EventHandler(this.btnCinco_Click);
            // 
            // btnQuatro
            // 
            this.btnQuatro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuatro.Location = new System.Drawing.Point(138, 211);
            this.btnQuatro.Name = "btnQuatro";
            this.btnQuatro.Size = new System.Drawing.Size(51, 43);
            this.btnQuatro.TabIndex = 9;
            this.btnQuatro.Text = "4";
            this.btnQuatro.UseVisualStyleBackColor = true;
            this.btnQuatro.Click += new System.EventHandler(this.btnQuatro_Click);
            // 
            // btnOito
            // 
            this.btnOito.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOito.Location = new System.Drawing.Point(138, 157);
            this.btnOito.Name = "btnOito";
            this.btnOito.Size = new System.Drawing.Size(51, 43);
            this.btnOito.TabIndex = 7;
            this.btnOito.Text = "8";
            this.btnOito.UseVisualStyleBackColor = true;
            this.btnOito.Click += new System.EventHandler(this.btnOito_Click);
            // 
            // btnNove
            // 
            this.btnNove.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNove.Location = new System.Drawing.Point(206, 157);
            this.btnNove.Name = "btnNove";
            this.btnNove.Size = new System.Drawing.Size(51, 43);
            this.btnNove.TabIndex = 6;
            this.btnNove.Text = "9";
            this.btnNove.UseVisualStyleBackColor = true;
            this.btnNove.Click += new System.EventHandler(this.btnNove_Click);
            // 
            // btnSeis
            // 
            this.btnSeis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeis.Location = new System.Drawing.Point(8, 157);
            this.btnSeis.Name = "btnSeis";
            this.btnSeis.Size = new System.Drawing.Size(51, 43);
            this.btnSeis.TabIndex = 5;
            this.btnSeis.Text = "6";
            this.btnSeis.UseVisualStyleBackColor = true;
            this.btnSeis.Click += new System.EventHandler(this.btnSeis_Click);
            // 
            // btnCarne
            // 
            this.btnCarne.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnCarne.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCarne.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCarne.Location = new System.Drawing.Point(138, 86);
            this.btnCarne.Name = "btnCarne";
            this.btnCarne.Size = new System.Drawing.Size(80, 55);
            this.btnCarne.TabIndex = 4;
            this.btnCarne.Text = "Carne";
            this.btnCarne.UseVisualStyleBackColor = false;
            // 
            // btnFeijao
            // 
            this.btnFeijao.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnFeijao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFeijao.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnFeijao.Location = new System.Drawing.Point(52, 86);
            this.btnFeijao.Name = "btnFeijao";
            this.btnFeijao.Size = new System.Drawing.Size(80, 55);
            this.btnFeijao.TabIndex = 3;
            this.btnFeijao.Text = "Feijão";
            this.btnFeijao.UseVisualStyleBackColor = false;
            // 
            // btnBolo
            // 
            this.btnBolo.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnBolo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBolo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnBolo.Location = new System.Drawing.Point(181, 25);
            this.btnBolo.Name = "btnBolo";
            this.btnBolo.Size = new System.Drawing.Size(80, 55);
            this.btnBolo.TabIndex = 2;
            this.btnBolo.Text = "Bolo";
            this.btnBolo.UseVisualStyleBackColor = false;
            // 
            // btnArroz
            // 
            this.btnArroz.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnArroz.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnArroz.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnArroz.Location = new System.Drawing.Point(95, 25);
            this.btnArroz.Name = "btnArroz";
            this.btnArroz.Size = new System.Drawing.Size(80, 55);
            this.btnArroz.TabIndex = 1;
            this.btnArroz.Text = "Arroz";
            this.btnArroz.UseVisualStyleBackColor = false;
            // 
            // btnPipoca
            // 
            this.btnPipoca.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnPipoca.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPipoca.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnPipoca.Location = new System.Drawing.Point(8, 25);
            this.btnPipoca.Name = "btnPipoca";
            this.btnPipoca.Size = new System.Drawing.Size(80, 55);
            this.btnPipoca.TabIndex = 0;
            this.btnPipoca.Text = "Pipoca";
            this.btnPipoca.UseVisualStyleBackColor = false;
            // 
            // pnlTela
            // 
            this.pnlTela.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pnlTela.Controls.Add(this.lbAquecido);
            this.pnlTela.Location = new System.Drawing.Point(2, 3);
            this.pnlTela.Name = "pnlTela";
            this.pnlTela.Size = new System.Drawing.Size(640, 516);
            this.pnlTela.TabIndex = 7;
            // 
            // lbAquecido
            // 
            this.lbAquecido.AutoSize = true;
            this.lbAquecido.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAquecido.Location = new System.Drawing.Point(139, 223);
            this.lbAquecido.Name = "lbAquecido";
            this.lbAquecido.Size = new System.Drawing.Size(309, 73);
            this.lbAquecido.TabIndex = 0;
            this.lbAquecido.Text = "Aquecido";
            // 
            // lbTimer
            // 
            this.lbTimer.AutoSize = true;
            this.lbTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTimer.Location = new System.Drawing.Point(39, 14);
            this.lbTimer.Name = "lbTimer";
            this.lbTimer.Size = new System.Drawing.Size(199, 73);
            this.lbTimer.TabIndex = 0;
            this.lbTimer.Text = "00:00";
            // 
            // FrmPainelControle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(947, 522);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnlTela);
            this.Name = "FrmPainelControle";
            this.Text = "Micro-Ondas Digital";
            this.Load += new System.EventHandler(this.FrmPainelControle_Load);
            this.panel2.ResumeLayout(false);
            this.pnlpainel.ResumeLayout(false);
            this.pnlpainel.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.pnlTela.ResumeLayout(false);
            this.pnlTela.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel pnlpainel;
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnDois;
        private System.Windows.Forms.Button btnUm;
        private System.Windows.Forms.Button btnZero;
        private System.Windows.Forms.Button btnSete;
        private System.Windows.Forms.Button btnTres;
        private System.Windows.Forms.Button btnCinco;
        private System.Windows.Forms.Button btnQuatro;
        private System.Windows.Forms.Button btnOito;
        private System.Windows.Forms.Button btnNove;
        private System.Windows.Forms.Button btnSeis;
        private System.Windows.Forms.Button btnCarne;
        private System.Windows.Forms.Button btnFeijao;
        private System.Windows.Forms.Button btnBolo;
        private System.Windows.Forms.Button btnArroz;
        private System.Windows.Forms.Button btnPipoca;
        private System.Windows.Forms.Panel pnlTela;
        private System.Windows.Forms.MaskedTextBox txtTempo;
        private System.Windows.Forms.Label lbAquecido;
        private System.Windows.Forms.Label lbTimer;
    }
}