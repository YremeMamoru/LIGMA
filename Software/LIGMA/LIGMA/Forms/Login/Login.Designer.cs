﻿namespace LIGMA
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lnkEsqueceuSenha = new System.Windows.Forms.LinkLabel();
            this.lblSlogan = new System.Windows.Forms.Label();
            this.cmbUsuario = new System.Windows.Forms.ComboBox();
            this.pnlFormBorder = new System.Windows.Forms.Panel();
            this.lblLIGMA = new System.Windows.Forms.Label();
            this.pcbIcone = new System.Windows.Forms.PictureBox();
            this.btnMinimizar = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.pcbLogo = new System.Windows.Forms.PictureBox();
            this.pnlFormBorder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbIcone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // txtLogin
            // 
            this.txtLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtLogin.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLogin.Location = new System.Drawing.Point(44, 208);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(167, 22);
            this.txtLogin.TabIndex = 1;
            this.txtLogin.Enter += new System.EventHandler(this.txtLogin_Enter);
            this.txtLogin.Leave += new System.EventHandler(this.txtLogin_Leave);
            // 
            // txtSenha
            // 
            this.txtSenha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSenha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSenha.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenha.Location = new System.Drawing.Point(44, 264);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(167, 22);
            this.txtSenha.TabIndex = 2;
            this.txtSenha.Enter += new System.EventHandler(this.txtSenha_Enter);
            this.txtSenha.Leave += new System.EventHandler(this.txtSenha_Leave);
            // 
            // btnLogin
            // 
            this.btnLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLogin.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnLogin.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(13)))), ((int)(((byte)(136)))));
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLogin.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(86, 322);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(68, 25);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lnkEsqueceuSenha
            // 
            this.lnkEsqueceuSenha.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(13)))), ((int)(((byte)(136)))));
            this.lnkEsqueceuSenha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lnkEsqueceuSenha.AutoSize = true;
            this.lnkEsqueceuSenha.DisabledLinkColor = System.Drawing.Color.RoyalBlue;
            this.lnkEsqueceuSenha.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkEsqueceuSenha.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lnkEsqueceuSenha.LinkColor = System.Drawing.Color.RoyalBlue;
            this.lnkEsqueceuSenha.Location = new System.Drawing.Point(70, 367);
            this.lnkEsqueceuSenha.Name = "lnkEsqueceuSenha";
            this.lnkEsqueceuSenha.Size = new System.Drawing.Size(106, 14);
            this.lnkEsqueceuSenha.TabIndex = 7;
            this.lnkEsqueceuSenha.TabStop = true;
            this.lnkEsqueceuSenha.Text = "Esqueceu a Senha";
            this.lnkEsqueceuSenha.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(11)))), ((int)(((byte)(147)))));
            // 
            // lblSlogan
            // 
            this.lblSlogan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSlogan.AutoSize = true;
            this.lblSlogan.BackColor = System.Drawing.Color.Transparent;
            this.lblSlogan.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSlogan.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblSlogan.Location = new System.Drawing.Point(51, 106);
            this.lblSlogan.Name = "lblSlogan";
            this.lblSlogan.Size = new System.Drawing.Size(156, 14);
            this.lblSlogan.TabIndex = 8;
            this.lblSlogan.Text = "Aprenda a usar essa língua";
            // 
            // cmbUsuario
            // 
            this.cmbUsuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbUsuario.FormattingEnabled = true;
            this.cmbUsuario.Items.AddRange(new object[] {
            "Professor",
            "Aluno",
            "Administração"});
            this.cmbUsuario.Location = new System.Drawing.Point(44, 150);
            this.cmbUsuario.Name = "cmbUsuario";
            this.cmbUsuario.Size = new System.Drawing.Size(167, 22);
            this.cmbUsuario.TabIndex = 0;
            // 
            // pnlFormBorder
            // 
            this.pnlFormBorder.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlFormBorder.BackColor = System.Drawing.Color.RoyalBlue;
            this.pnlFormBorder.Controls.Add(this.lblLIGMA);
            this.pnlFormBorder.Controls.Add(this.pcbIcone);
            this.pnlFormBorder.Controls.Add(this.btnMinimizar);
            this.pnlFormBorder.Controls.Add(this.btnFechar);
            this.pnlFormBorder.Location = new System.Drawing.Point(0, 0);
            this.pnlFormBorder.Name = "pnlFormBorder";
            this.pnlFormBorder.Size = new System.Drawing.Size(260, 29);
            this.pnlFormBorder.TabIndex = 9;
            // 
            // lblLIGMA
            // 
            this.lblLIGMA.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblLIGMA.AutoSize = true;
            this.lblLIGMA.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLIGMA.ForeColor = System.Drawing.Color.White;
            this.lblLIGMA.Location = new System.Drawing.Point(30, 5);
            this.lblLIGMA.Name = "lblLIGMA";
            this.lblLIGMA.Size = new System.Drawing.Size(48, 18);
            this.lblLIGMA.TabIndex = 11;
            this.lblLIGMA.Text = "LIGMA";
            // 
            // pcbIcone
            // 
            this.pcbIcone.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pcbIcone.BackColor = System.Drawing.Color.Transparent;
            this.pcbIcone.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pcbIcone.ErrorImage = global::LIGMA.Properties.Resources.logo;
            this.pcbIcone.Image = global::LIGMA.Properties.Resources._12133tongue_109560;
            this.pcbIcone.InitialImage = global::LIGMA.Properties.Resources.logo;
            this.pcbIcone.Location = new System.Drawing.Point(3, 4);
            this.pcbIcone.Name = "pcbIcone";
            this.pcbIcone.Size = new System.Drawing.Size(21, 22);
            this.pcbIcone.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbIcone.TabIndex = 10;
            this.pcbIcone.TabStop = false;
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizar.BackColor = System.Drawing.Color.Transparent;
            this.btnMinimizar.BackgroundImage = global::LIGMA.Properties.Resources.MinimizarJanela;
            this.btnMinimizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimizar.Location = new System.Drawing.Point(205, 0);
            this.btnMinimizar.Margin = new System.Windows.Forms.Padding(5);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Padding = new System.Windows.Forms.Padding(3);
            this.btnMinimizar.Size = new System.Drawing.Size(25, 26);
            this.btnMinimizar.TabIndex = 10;
            this.btnMinimizar.UseVisualStyleBackColor = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFechar.BackColor = System.Drawing.Color.Transparent;
            this.btnFechar.BackgroundImage = global::LIGMA.Properties.Resources.FecharJanela;
            this.btnFechar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechar.Location = new System.Drawing.Point(232, 0);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(25, 26);
            this.btnFechar.TabIndex = 0;
            this.btnFechar.UseVisualStyleBackColor = false;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // pcbLogo
            // 
            this.pcbLogo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pcbLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.pcbLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pcbLogo.ErrorImage = global::LIGMA.Properties.Resources.logo;
            this.pcbLogo.Image = global::LIGMA.Properties.Resources.logo;
            this.pcbLogo.InitialImage = global::LIGMA.Properties.Resources.logo;
            this.pcbLogo.Location = new System.Drawing.Point(27, 35);
            this.pcbLogo.Name = "pcbLogo";
            this.pcbLogo.Size = new System.Drawing.Size(200, 68);
            this.pcbLogo.TabIndex = 0;
            this.pcbLogo.TabStop = false;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(259, 394);
            this.Controls.Add(this.pnlFormBorder);
            this.Controls.Add(this.cmbUsuario);
            this.Controls.Add(this.lblSlogan);
            this.Controls.Add(this.lnkEsqueceuSenha);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.txtLogin);
            this.Controls.Add(this.pcbLogo);
            this.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(11)))), ((int)(((byte)(147)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.Hiragana;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(259, 394);
            this.MinimumSize = new System.Drawing.Size(259, 394);
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LIGMA";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlFormBorder.ResumeLayout(false);
            this.pnlFormBorder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbIcone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pcbLogo;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.LinkLabel lnkEsqueceuSenha;
        private System.Windows.Forms.Label lblSlogan;
        private System.Windows.Forms.ComboBox cmbUsuario;
        private System.Windows.Forms.Panel pnlFormBorder;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Label lblLIGMA;
        private System.Windows.Forms.PictureBox pcbIcone;
        private System.Windows.Forms.Button btnMinimizar;
    }
}

