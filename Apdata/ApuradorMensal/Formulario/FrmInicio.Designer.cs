
namespace ApuradorMensal
{
    partial class FrmInicio
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.PnlPassoUm = new System.Windows.Forms.Panel();
            this.pnlConexao = new System.Windows.Forms.Panel();
            this.cbxWindowsAut = new System.Windows.Forms.CheckBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.lblUserPass = new System.Windows.Forms.Label();
            this.lblServidor = new System.Windows.Forms.Label();
            this.txtServidor = new System.Windows.Forms.TextBox();
            this.lblConexoes = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rdbAptools = new System.Windows.Forms.RadioButton();
            this.rdbBancoDeDados = new System.Windows.Forms.RadioButton();
            this.pnlTipoCliente = new System.Windows.Forms.Panel();
            this.rdbUnico = new System.Windows.Forms.RadioButton();
            this.rdbMultiTenant = new System.Windows.Forms.RadioButton();
            this.lblModoExtracao = new System.Windows.Forms.Label();
            this.lblTipoCliente = new System.Windows.Forms.Label();
            this.btOkPassoUm = new System.Windows.Forms.Button();
            this.PnlPassoDois = new System.Windows.Forms.Panel();
            this.lblSelecione = new System.Windows.Forms.Label();
            this.dgvInquilinos = new System.Windows.Forms.DataGridView();
            this.lblMultitenant = new System.Windows.Forms.Label();
            this.btVoltarPassoDois = new System.Windows.Forms.Button();
            this.btOkPassoDois = new System.Windows.Forms.Button();
            this.PnlPassoTres = new System.Windows.Forms.Panel();
            this.pnlConexaoAptools = new System.Windows.Forms.Panel();
            this.txtSenhaAptools = new System.Windows.Forms.TextBox();
            this.lblSenhaAptools = new System.Windows.Forms.Label();
            this.lblUsuarioApTools = new System.Windows.Forms.Label();
            this.txtUsuarioAptools = new System.Windows.Forms.TextBox();
            this.txtPortaAptools = new System.Windows.Forms.TextBox();
            this.lblPorta = new System.Windows.Forms.Label();
            this.lblIp = new System.Windows.Forms.Label();
            this.txtIpAptools = new System.Windows.Forms.TextBox();
            this.lblAptools = new System.Windows.Forms.Label();
            this.btVoltarPassoTres = new System.Windows.Forms.Button();
            this.btOkPassoTres = new System.Windows.Forms.Button();
            this.PnlPassoQuatro = new System.Windows.Forms.Panel();
            this.lblFinalizar = new System.Windows.Forms.Label();
            this.btVoltarPassoQuatro = new System.Windows.Forms.Button();
            this.btOkPassoQuatro = new System.Windows.Forms.Button();
            this.txtMesAno = new System.Windows.Forms.MaskedTextBox();
            this.lblMesAnoBase = new System.Windows.Forms.Label();
            this.PnlPassoUm.SuspendLayout();
            this.pnlConexao.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlTipoCliente.SuspendLayout();
            this.PnlPassoDois.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInquilinos)).BeginInit();
            this.PnlPassoTres.SuspendLayout();
            this.pnlConexaoAptools.SuspendLayout();
            this.PnlPassoQuatro.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlPassoUm
            // 
            this.PnlPassoUm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PnlPassoUm.Controls.Add(this.pnlConexao);
            this.PnlPassoUm.Controls.Add(this.lblConexoes);
            this.PnlPassoUm.Controls.Add(this.panel1);
            this.PnlPassoUm.Controls.Add(this.pnlTipoCliente);
            this.PnlPassoUm.Controls.Add(this.lblModoExtracao);
            this.PnlPassoUm.Controls.Add(this.lblTipoCliente);
            this.PnlPassoUm.Controls.Add(this.btOkPassoUm);
            this.PnlPassoUm.Location = new System.Drawing.Point(12, 41);
            this.PnlPassoUm.Name = "PnlPassoUm";
            this.PnlPassoUm.Size = new System.Drawing.Size(325, 210);
            this.PnlPassoUm.TabIndex = 0;
            // 
            // pnlConexao
            // 
            this.pnlConexao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlConexao.Controls.Add(this.cbxWindowsAut);
            this.pnlConexao.Controls.Add(this.txtSenha);
            this.pnlConexao.Controls.Add(this.lblUserPass);
            this.pnlConexao.Controls.Add(this.lblServidor);
            this.pnlConexao.Controls.Add(this.txtServidor);
            this.pnlConexao.Enabled = false;
            this.pnlConexao.Location = new System.Drawing.Point(3, 112);
            this.pnlConexao.Name = "pnlConexao";
            this.pnlConexao.Size = new System.Drawing.Size(244, 93);
            this.pnlConexao.TabIndex = 14;
            // 
            // cbxWindowsAut
            // 
            this.cbxWindowsAut.AutoSize = true;
            this.cbxWindowsAut.Location = new System.Drawing.Point(93, 64);
            this.cbxWindowsAut.Name = "cbxWindowsAut";
            this.cbxWindowsAut.Size = new System.Drawing.Size(146, 19);
            this.cbxWindowsAut.TabIndex = 19;
            this.cbxWindowsAut.Text = "Autenticação windows";
            this.cbxWindowsAut.UseVisualStyleBackColor = true;
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(3, 62);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '●';
            this.txtSenha.Size = new System.Drawing.Size(84, 23);
            this.txtSenha.TabIndex = 17;
            this.txtSenha.UseSystemPasswordChar = true;
            // 
            // lblUserPass
            // 
            this.lblUserPass.AutoSize = true;
            this.lblUserPass.Location = new System.Drawing.Point(4, 44);
            this.lblUserPass.Name = "lblUserPass";
            this.lblUserPass.Size = new System.Drawing.Size(39, 15);
            this.lblUserPass.TabIndex = 16;
            this.lblUserPass.Text = "Senha";
            // 
            // lblServidor
            // 
            this.lblServidor.AutoSize = true;
            this.lblServidor.Location = new System.Drawing.Point(3, 0);
            this.lblServidor.Name = "lblServidor";
            this.lblServidor.Size = new System.Drawing.Size(153, 15);
            this.lblServidor.TabIndex = 15;
            this.lblServidor.Text = "Servidor/Instancia:Database";
            // 
            // txtServidor
            // 
            this.txtServidor.Location = new System.Drawing.Point(3, 18);
            this.txtServidor.Name = "txtServidor";
            this.txtServidor.Size = new System.Drawing.Size(236, 23);
            this.txtServidor.TabIndex = 0;
            // 
            // lblConexoes
            // 
            this.lblConexoes.AutoSize = true;
            this.lblConexoes.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblConexoes.Location = new System.Drawing.Point(-1, -1);
            this.lblConexoes.Name = "lblConexoes";
            this.lblConexoes.Size = new System.Drawing.Size(77, 21);
            this.lblConexoes.TabIndex = 4;
            this.lblConexoes.Text = "Conexões";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.rdbAptools);
            this.panel1.Controls.Add(this.rdbBancoDeDados);
            this.panel1.Location = new System.Drawing.Point(3, 81);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(317, 28);
            this.panel1.TabIndex = 13;
            // 
            // rdbAptools
            // 
            this.rdbAptools.AutoSize = true;
            this.rdbAptools.Checked = true;
            this.rdbAptools.Location = new System.Drawing.Point(67, 3);
            this.rdbAptools.Name = "rdbAptools";
            this.rdbAptools.Size = new System.Drawing.Size(66, 19);
            this.rdbAptools.TabIndex = 0;
            this.rdbAptools.TabStop = true;
            this.rdbAptools.Text = "Aptools";
            this.rdbAptools.UseVisualStyleBackColor = true;
            // 
            // rdbBancoDeDados
            // 
            this.rdbBancoDeDados.AutoSize = true;
            this.rdbBancoDeDados.Location = new System.Drawing.Point(3, 3);
            this.rdbBancoDeDados.Name = "rdbBancoDeDados";
            this.rdbBancoDeDados.Size = new System.Drawing.Size(58, 19);
            this.rdbBancoDeDados.TabIndex = 1;
            this.rdbBancoDeDados.Text = "Banco";
            this.rdbBancoDeDados.UseVisualStyleBackColor = true;
            // 
            // pnlTipoCliente
            // 
            this.pnlTipoCliente.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlTipoCliente.Controls.Add(this.rdbUnico);
            this.pnlTipoCliente.Controls.Add(this.rdbMultiTenant);
            this.pnlTipoCliente.Location = new System.Drawing.Point(3, 38);
            this.pnlTipoCliente.Name = "pnlTipoCliente";
            this.pnlTipoCliente.Size = new System.Drawing.Size(317, 28);
            this.pnlTipoCliente.TabIndex = 12;
            // 
            // rdbUnico
            // 
            this.rdbUnico.AutoSize = true;
            this.rdbUnico.Checked = true;
            this.rdbUnico.Location = new System.Drawing.Point(3, 3);
            this.rdbUnico.Name = "rdbUnico";
            this.rdbUnico.Size = new System.Drawing.Size(56, 19);
            this.rdbUnico.TabIndex = 0;
            this.rdbUnico.TabStop = true;
            this.rdbUnico.Text = "Único";
            this.rdbUnico.UseVisualStyleBackColor = true;
            // 
            // rdbMultiTenant
            // 
            this.rdbMultiTenant.AutoSize = true;
            this.rdbMultiTenant.Location = new System.Drawing.Point(67, 3);
            this.rdbMultiTenant.Name = "rdbMultiTenant";
            this.rdbMultiTenant.Size = new System.Drawing.Size(87, 19);
            this.rdbMultiTenant.TabIndex = 1;
            this.rdbMultiTenant.Text = "Multitenant";
            this.rdbMultiTenant.UseVisualStyleBackColor = true;
            // 
            // lblModoExtracao
            // 
            this.lblModoExtracao.AutoSize = true;
            this.lblModoExtracao.Location = new System.Drawing.Point(3, 66);
            this.lblModoExtracao.Name = "lblModoExtracao";
            this.lblModoExtracao.Size = new System.Drawing.Size(103, 15);
            this.lblModoExtracao.TabIndex = 9;
            this.lblModoExtracao.Text = "Modo de extração";
            // 
            // lblTipoCliente
            // 
            this.lblTipoCliente.AutoSize = true;
            this.lblTipoCliente.Location = new System.Drawing.Point(3, 23);
            this.lblTipoCliente.Name = "lblTipoCliente";
            this.lblTipoCliente.Size = new System.Drawing.Size(85, 15);
            this.lblTipoCliente.TabIndex = 8;
            this.lblTipoCliente.Text = "Tipo do cliente";
            // 
            // btOkPassoUm
            // 
            this.btOkPassoUm.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btOkPassoUm.Location = new System.Drawing.Point(255, 175);
            this.btOkPassoUm.Name = "btOkPassoUm";
            this.btOkPassoUm.Size = new System.Drawing.Size(65, 30);
            this.btOkPassoUm.TabIndex = 5;
            this.btOkPassoUm.Text = "✔";
            this.btOkPassoUm.UseVisualStyleBackColor = true;
            // 
            // PnlPassoDois
            // 
            this.PnlPassoDois.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PnlPassoDois.Controls.Add(this.lblSelecione);
            this.PnlPassoDois.Controls.Add(this.dgvInquilinos);
            this.PnlPassoDois.Controls.Add(this.lblMultitenant);
            this.PnlPassoDois.Controls.Add(this.btVoltarPassoDois);
            this.PnlPassoDois.Controls.Add(this.btOkPassoDois);
            this.PnlPassoDois.Enabled = false;
            this.PnlPassoDois.Location = new System.Drawing.Point(12, 264);
            this.PnlPassoDois.Name = "PnlPassoDois";
            this.PnlPassoDois.Size = new System.Drawing.Size(325, 210);
            this.PnlPassoDois.TabIndex = 1;
            // 
            // lblSelecione
            // 
            this.lblSelecione.AutoSize = true;
            this.lblSelecione.Location = new System.Drawing.Point(3, 172);
            this.lblSelecione.Name = "lblSelecione";
            this.lblSelecione.Size = new System.Drawing.Size(138, 30);
            this.lblSelecione.TabIndex = 22;
            this.lblSelecione.Text = "Selecione os inquilinos\r\nque deseja apurar (CTRL)";
            this.lblSelecione.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dgvInquilinos
            // 
            this.dgvInquilinos.AllowUserToAddRows = false;
            this.dgvInquilinos.AllowUserToDeleteRows = false;
            this.dgvInquilinos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInquilinos.Location = new System.Drawing.Point(3, 23);
            this.dgvInquilinos.Name = "dgvInquilinos";
            this.dgvInquilinos.ReadOnly = true;
            this.dgvInquilinos.RowTemplate.Height = 25;
            this.dgvInquilinos.Size = new System.Drawing.Size(317, 146);
            this.dgvInquilinos.TabIndex = 16;
            // 
            // lblMultitenant
            // 
            this.lblMultitenant.AutoSize = true;
            this.lblMultitenant.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMultitenant.Location = new System.Drawing.Point(-1, -1);
            this.lblMultitenant.Name = "lblMultitenant";
            this.lblMultitenant.Size = new System.Drawing.Size(90, 21);
            this.lblMultitenant.TabIndex = 15;
            this.lblMultitenant.Text = "Multitenant";
            // 
            // btVoltarPassoDois
            // 
            this.btVoltarPassoDois.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btVoltarPassoDois.Location = new System.Drawing.Point(184, 175);
            this.btVoltarPassoDois.Name = "btVoltarPassoDois";
            this.btVoltarPassoDois.Size = new System.Drawing.Size(65, 30);
            this.btVoltarPassoDois.TabIndex = 7;
            this.btVoltarPassoDois.Text = "⬅";
            this.btVoltarPassoDois.UseVisualStyleBackColor = true;
            // 
            // btOkPassoDois
            // 
            this.btOkPassoDois.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btOkPassoDois.Location = new System.Drawing.Point(255, 175);
            this.btOkPassoDois.Name = "btOkPassoDois";
            this.btOkPassoDois.Size = new System.Drawing.Size(65, 30);
            this.btOkPassoDois.TabIndex = 6;
            this.btOkPassoDois.Text = "✔";
            this.btOkPassoDois.UseVisualStyleBackColor = true;
            // 
            // PnlPassoTres
            // 
            this.PnlPassoTres.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PnlPassoTres.Controls.Add(this.pnlConexaoAptools);
            this.PnlPassoTres.Controls.Add(this.lblAptools);
            this.PnlPassoTres.Controls.Add(this.btVoltarPassoTres);
            this.PnlPassoTres.Controls.Add(this.btOkPassoTres);
            this.PnlPassoTres.Enabled = false;
            this.PnlPassoTres.Location = new System.Drawing.Point(347, 41);
            this.PnlPassoTres.Name = "PnlPassoTres";
            this.PnlPassoTres.Size = new System.Drawing.Size(325, 210);
            this.PnlPassoTres.TabIndex = 2;
            // 
            // pnlConexaoAptools
            // 
            this.pnlConexaoAptools.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlConexaoAptools.Controls.Add(this.txtSenhaAptools);
            this.pnlConexaoAptools.Controls.Add(this.lblSenhaAptools);
            this.pnlConexaoAptools.Controls.Add(this.lblUsuarioApTools);
            this.pnlConexaoAptools.Controls.Add(this.txtUsuarioAptools);
            this.pnlConexaoAptools.Controls.Add(this.txtPortaAptools);
            this.pnlConexaoAptools.Controls.Add(this.lblPorta);
            this.pnlConexaoAptools.Controls.Add(this.lblIp);
            this.pnlConexaoAptools.Controls.Add(this.txtIpAptools);
            this.pnlConexaoAptools.Location = new System.Drawing.Point(3, 35);
            this.pnlConexaoAptools.Name = "pnlConexaoAptools";
            this.pnlConexaoAptools.Size = new System.Drawing.Size(317, 134);
            this.pnlConexaoAptools.TabIndex = 20;
            // 
            // txtSenhaAptools
            // 
            this.txtSenhaAptools.Location = new System.Drawing.Point(56, 93);
            this.txtSenhaAptools.Name = "txtSenhaAptools";
            this.txtSenhaAptools.Size = new System.Drawing.Size(110, 23);
            this.txtSenhaAptools.TabIndex = 21;
            // 
            // lblSenhaAptools
            // 
            this.lblSenhaAptools.AutoSize = true;
            this.lblSenhaAptools.Location = new System.Drawing.Point(3, 96);
            this.lblSenhaAptools.Name = "lblSenhaAptools";
            this.lblSenhaAptools.Size = new System.Drawing.Size(39, 15);
            this.lblSenhaAptools.TabIndex = 20;
            this.lblSenhaAptools.Text = "Senha";
            // 
            // lblUsuarioApTools
            // 
            this.lblUsuarioApTools.AutoSize = true;
            this.lblUsuarioApTools.Location = new System.Drawing.Point(3, 67);
            this.lblUsuarioApTools.Name = "lblUsuarioApTools";
            this.lblUsuarioApTools.Size = new System.Drawing.Size(47, 15);
            this.lblUsuarioApTools.TabIndex = 19;
            this.lblUsuarioApTools.Text = "Usuário";
            // 
            // txtUsuarioAptools
            // 
            this.txtUsuarioAptools.Location = new System.Drawing.Point(56, 64);
            this.txtUsuarioAptools.Name = "txtUsuarioAptools";
            this.txtUsuarioAptools.Size = new System.Drawing.Size(110, 23);
            this.txtUsuarioAptools.TabIndex = 18;
            // 
            // txtPortaAptools
            // 
            this.txtPortaAptools.Location = new System.Drawing.Point(56, 35);
            this.txtPortaAptools.Name = "txtPortaAptools";
            this.txtPortaAptools.Size = new System.Drawing.Size(110, 23);
            this.txtPortaAptools.TabIndex = 17;
            // 
            // lblPorta
            // 
            this.lblPorta.AutoSize = true;
            this.lblPorta.Location = new System.Drawing.Point(3, 38);
            this.lblPorta.Name = "lblPorta";
            this.lblPorta.Size = new System.Drawing.Size(35, 15);
            this.lblPorta.TabIndex = 16;
            this.lblPorta.Text = "Porta";
            // 
            // lblIp
            // 
            this.lblIp.AutoSize = true;
            this.lblIp.Location = new System.Drawing.Point(3, 9);
            this.lblIp.Name = "lblIp";
            this.lblIp.Size = new System.Drawing.Size(17, 15);
            this.lblIp.TabIndex = 15;
            this.lblIp.Text = "IP";
            // 
            // txtIpAptools
            // 
            this.txtIpAptools.Location = new System.Drawing.Point(56, 6);
            this.txtIpAptools.Name = "txtIpAptools";
            this.txtIpAptools.Size = new System.Drawing.Size(110, 23);
            this.txtIpAptools.TabIndex = 0;
            // 
            // lblAptools
            // 
            this.lblAptools.AutoSize = true;
            this.lblAptools.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAptools.Location = new System.Drawing.Point(-1, -1);
            this.lblAptools.Name = "lblAptools";
            this.lblAptools.Size = new System.Drawing.Size(63, 21);
            this.lblAptools.TabIndex = 16;
            this.lblAptools.Text = "Aptools";
            // 
            // btVoltarPassoTres
            // 
            this.btVoltarPassoTres.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btVoltarPassoTres.Location = new System.Drawing.Point(184, 175);
            this.btVoltarPassoTres.Name = "btVoltarPassoTres";
            this.btVoltarPassoTres.Size = new System.Drawing.Size(65, 30);
            this.btVoltarPassoTres.TabIndex = 9;
            this.btVoltarPassoTres.Text = "⬅";
            this.btVoltarPassoTres.UseVisualStyleBackColor = true;
            // 
            // btOkPassoTres
            // 
            this.btOkPassoTres.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btOkPassoTres.Location = new System.Drawing.Point(255, 175);
            this.btOkPassoTres.Name = "btOkPassoTres";
            this.btOkPassoTres.Size = new System.Drawing.Size(65, 30);
            this.btOkPassoTres.TabIndex = 8;
            this.btOkPassoTres.Text = "✔";
            this.btOkPassoTres.UseVisualStyleBackColor = true;
            // 
            // PnlPassoQuatro
            // 
            this.PnlPassoQuatro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PnlPassoQuatro.Controls.Add(this.lblFinalizar);
            this.PnlPassoQuatro.Controls.Add(this.btVoltarPassoQuatro);
            this.PnlPassoQuatro.Controls.Add(this.btOkPassoQuatro);
            this.PnlPassoQuatro.Enabled = false;
            this.PnlPassoQuatro.Location = new System.Drawing.Point(347, 264);
            this.PnlPassoQuatro.Name = "PnlPassoQuatro";
            this.PnlPassoQuatro.Size = new System.Drawing.Size(325, 210);
            this.PnlPassoQuatro.TabIndex = 3;
            // 
            // lblFinalizar
            // 
            this.lblFinalizar.AutoSize = true;
            this.lblFinalizar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblFinalizar.Location = new System.Drawing.Point(-1, -1);
            this.lblFinalizar.Name = "lblFinalizar";
            this.lblFinalizar.Size = new System.Drawing.Size(68, 21);
            this.lblFinalizar.TabIndex = 17;
            this.lblFinalizar.Text = "Finalizar";
            // 
            // btVoltarPassoQuatro
            // 
            this.btVoltarPassoQuatro.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btVoltarPassoQuatro.Location = new System.Drawing.Point(184, 175);
            this.btVoltarPassoQuatro.Name = "btVoltarPassoQuatro";
            this.btVoltarPassoQuatro.Size = new System.Drawing.Size(65, 30);
            this.btVoltarPassoQuatro.TabIndex = 11;
            this.btVoltarPassoQuatro.Text = "⬅";
            this.btVoltarPassoQuatro.UseVisualStyleBackColor = true;
            // 
            // btOkPassoQuatro
            // 
            this.btOkPassoQuatro.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btOkPassoQuatro.Location = new System.Drawing.Point(255, 175);
            this.btOkPassoQuatro.Name = "btOkPassoQuatro";
            this.btOkPassoQuatro.Size = new System.Drawing.Size(65, 30);
            this.btOkPassoQuatro.TabIndex = 10;
            this.btOkPassoQuatro.Text = "✔";
            this.btOkPassoQuatro.UseVisualStyleBackColor = true;
            // 
            // txtMesAno
            // 
            this.txtMesAno.Location = new System.Drawing.Point(12, 12);
            this.txtMesAno.Mask = "00/00";
            this.txtMesAno.Name = "txtMesAno";
            this.txtMesAno.Size = new System.Drawing.Size(48, 23);
            this.txtMesAno.TabIndex = 4;
            this.txtMesAno.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtMesAno.ValidatingType = typeof(System.DateTime);
            // 
            // lblMesAnoBase
            // 
            this.lblMesAnoBase.AutoSize = true;
            this.lblMesAnoBase.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMesAnoBase.Location = new System.Drawing.Point(66, 14);
            this.lblMesAnoBase.Name = "lblMesAnoBase";
            this.lblMesAnoBase.Size = new System.Drawing.Size(109, 21);
            this.lblMesAnoBase.TabIndex = 15;
            this.lblMesAnoBase.Text = "Mês/Ano base";
            // 
            // FrmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(684, 486);
            this.Controls.Add(this.lblMesAnoBase);
            this.Controls.Add(this.txtMesAno);
            this.Controls.Add(this.PnlPassoQuatro);
            this.Controls.Add(this.PnlPassoTres);
            this.Controls.Add(this.PnlPassoDois);
            this.Controls.Add(this.PnlPassoUm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "FrmInicio";
            this.Text = "Apuração Mensal";
            this.PnlPassoUm.ResumeLayout(false);
            this.PnlPassoUm.PerformLayout();
            this.pnlConexao.ResumeLayout(false);
            this.pnlConexao.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlTipoCliente.ResumeLayout(false);
            this.pnlTipoCliente.PerformLayout();
            this.PnlPassoDois.ResumeLayout(false);
            this.PnlPassoDois.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInquilinos)).EndInit();
            this.PnlPassoTres.ResumeLayout(false);
            this.PnlPassoTres.PerformLayout();
            this.pnlConexaoAptools.ResumeLayout(false);
            this.pnlConexaoAptools.PerformLayout();
            this.PnlPassoQuatro.ResumeLayout(false);
            this.PnlPassoQuatro.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PnlPassoUm;
        private System.Windows.Forms.Button btOkPassoUm;
        private System.Windows.Forms.RadioButton rdbMultiTenant;
        private System.Windows.Forms.RadioButton rdbUnico;
        private System.Windows.Forms.Panel PnlPassoDois;
        private System.Windows.Forms.Button btVoltarPassoDois;
        private System.Windows.Forms.Button btOkPassoDois;
        private System.Windows.Forms.Panel PnlPassoTres;
        private System.Windows.Forms.Button btVoltarPassoTres;
        private System.Windows.Forms.Button btOkPassoTres;
        private System.Windows.Forms.Panel PnlPassoQuatro;
        private System.Windows.Forms.Button btVoltarPassoQuatro;
        private System.Windows.Forms.Button btOkPassoQuatro;
        private System.Windows.Forms.Panel pnlConexao;
        private System.Windows.Forms.CheckBox cbxWindowsAut;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Label lblUserPass;
        private System.Windows.Forms.Label lblServidor;
        private System.Windows.Forms.TextBox txtServidor;
        private System.Windows.Forms.Label lblConexoes;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rdbAptools;
        private System.Windows.Forms.RadioButton rdbBancoDeDados;
        private System.Windows.Forms.Panel pnlTipoCliente;
        private System.Windows.Forms.Label lblModoExtracao;
        private System.Windows.Forms.Label lblTipoCliente;
        private System.Windows.Forms.Label lblMultitenant;
        private System.Windows.Forms.Panel pnlConexaoAptools;
        private System.Windows.Forms.TextBox txtPortaAptools;
        private System.Windows.Forms.Label lblPorta;
        private System.Windows.Forms.Label lblIp;
        private System.Windows.Forms.TextBox txtIpAptools;
        private System.Windows.Forms.Label lblAptools;
        private System.Windows.Forms.Label lblFinalizar;
        private System.Windows.Forms.DataGridView dgvInquilinos;
        private System.Windows.Forms.MaskedTextBox txtMesAno;
        private System.Windows.Forms.Label lblMesAnoBase;
        private System.Windows.Forms.TextBox txtSenhaAptools;
        private System.Windows.Forms.Label lblSenhaAptools;
        private System.Windows.Forms.Label lblUsuarioApTools;
        private System.Windows.Forms.TextBox txtUsuarioAptools;
        private System.Windows.Forms.Label lblSelecione;
    }
}

