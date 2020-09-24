namespace View
{
    partial class FrmPrincipal
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
            this.components = new System.ComponentModel.Container();
            this.menuPrincipal = new System.Windows.Forms.MenuStrip();
            this.mniCadastro = new System.Windows.Forms.ToolStripMenuItem();
            this.mniNovo = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mniListarPessoas = new System.Windows.Forms.ToolStripMenuItem();
            this.mniConfig = new System.Windows.Forms.ToolStripMenuItem();
            this.mniLogotipo = new System.Windows.Forms.ToolStripMenuItem();
            this.barraTarefas = new System.Windows.Forms.ToolStrip();
            this.barraStatus = new System.Windows.Forms.StatusStrip();
            this.bsiDataHora = new System.Windows.Forms.ToolStripStatusLabel();
            this.relogio = new System.Windows.Forms.Timer(this.components);
            this.lblDadosUsuario = new System.Windows.Forms.Label();
            this.pcbLogoPrincipal = new System.Windows.Forms.PictureBox();
            this.btiNovo = new System.Windows.Forms.ToolStripButton();
            this.btiLogo = new System.Windows.Forms.ToolStripButton();
            this.menuPrincipal.SuspendLayout();
            this.barraTarefas.SuspendLayout();
            this.barraStatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLogoPrincipal)).BeginInit();
            this.SuspendLayout();
            // 
            // menuPrincipal
            // 
            this.menuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniCadastro,
            this.mniConfig});
            this.menuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.menuPrincipal.Name = "menuPrincipal";
            this.menuPrincipal.Size = new System.Drawing.Size(1143, 24);
            this.menuPrincipal.TabIndex = 0;
            this.menuPrincipal.Text = "menuStrip1";
            // 
            // mniCadastro
            // 
            this.mniCadastro.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniNovo,
            this.toolStripSeparator1,
            this.mniListarPessoas});
            this.mniCadastro.Name = "mniCadastro";
            this.mniCadastro.Size = new System.Drawing.Size(66, 20);
            this.mniCadastro.Text = "&Cadastro";
            this.mniCadastro.ToolTipText = "Nesse item é possível realizar operações de cadastro de Pessoas!";
            // 
            // mniNovo
            // 
            this.mniNovo.Name = "mniNovo";
            this.mniNovo.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.mniNovo.Size = new System.Drawing.Size(186, 22);
            this.mniNovo.Text = "Novo";
            this.mniNovo.Click += new System.EventHandler(this.abrir_janela_novo);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(183, 6);
            // 
            // mniListarPessoas
            // 
            this.mniListarPessoas.Name = "mniListarPessoas";
            this.mniListarPessoas.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.L)));
            this.mniListarPessoas.Size = new System.Drawing.Size(186, 22);
            this.mniListarPessoas.Text = "Listar Pessoas";
            this.mniListarPessoas.Click += new System.EventHandler(this.mniListarPessoas_Click);
            // 
            // mniConfig
            // 
            this.mniConfig.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniLogotipo});
            this.mniConfig.Name = "mniConfig";
            this.mniConfig.Size = new System.Drawing.Size(91, 20);
            this.mniConfig.Text = "Con&figuração";
            // 
            // mniLogotipo
            // 
            this.mniLogotipo.Name = "mniLogotipo";
            this.mniLogotipo.Size = new System.Drawing.Size(180, 22);
            this.mniLogotipo.Text = "Logotipo";
            this.mniLogotipo.Click += new System.EventHandler(this.mniLogotipo_Click);
            // 
            // barraTarefas
            // 
            this.barraTarefas.Dock = System.Windows.Forms.DockStyle.Left;
            this.barraTarefas.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.barraTarefas.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btiNovo,
            this.btiLogo});
            this.barraTarefas.Location = new System.Drawing.Point(0, 24);
            this.barraTarefas.Name = "barraTarefas";
            this.barraTarefas.Size = new System.Drawing.Size(45, 529);
            this.barraTarefas.TabIndex = 1;
            this.barraTarefas.Text = "toolStrip1";
            // 
            // barraStatus
            // 
            this.barraStatus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bsiDataHora});
            this.barraStatus.Location = new System.Drawing.Point(45, 531);
            this.barraStatus.Name = "barraStatus";
            this.barraStatus.Size = new System.Drawing.Size(1098, 22);
            this.barraStatus.TabIndex = 2;
            this.barraStatus.Text = "statusStrip1";
            // 
            // bsiDataHora
            // 
            this.bsiDataHora.Name = "bsiDataHora";
            this.bsiDataHora.Size = new System.Drawing.Size(95, 17);
            this.bsiDataHora.Text = "01/01/1999 01:00";
            // 
            // relogio
            // 
            this.relogio.Interval = 1000;
            this.relogio.Tick += new System.EventHandler(this.relogio_Tick);
            // 
            // lblDadosUsuario
            // 
            this.lblDadosUsuario.AutoSize = true;
            this.lblDadosUsuario.Location = new System.Drawing.Point(981, 534);
            this.lblDadosUsuario.Name = "lblDadosUsuario";
            this.lblDadosUsuario.Size = new System.Drawing.Size(16, 13);
            this.lblDadosUsuario.TabIndex = 4;
            this.lblDadosUsuario.Text = "...";
            // 
            // pcbLogoPrincipal
            // 
            this.pcbLogoPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pcbLogoPrincipal.Image = global::View.Properties.Resources.logo_lasalle;
            this.pcbLogoPrincipal.Location = new System.Drawing.Point(45, 24);
            this.pcbLogoPrincipal.Name = "pcbLogoPrincipal";
            this.pcbLogoPrincipal.Size = new System.Drawing.Size(1098, 507);
            this.pcbLogoPrincipal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pcbLogoPrincipal.TabIndex = 3;
            this.pcbLogoPrincipal.TabStop = false;
            // 
            // btiNovo
            // 
            this.btiNovo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btiNovo.Image = global::View.Properties.Resources.cad_novo;
            this.btiNovo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btiNovo.Name = "btiNovo";
            this.btiNovo.Size = new System.Drawing.Size(42, 44);
            this.btiNovo.Text = "Novo";
            this.btiNovo.ToolTipText = "Adicionar novo cadastro de Pessoas";
            this.btiNovo.Click += new System.EventHandler(this.abrir_janela_novo);
            // 
            // btiLogo
            // 
            this.btiLogo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btiLogo.Image = global::View.Properties.Resources.configs;
            this.btiLogo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btiLogo.Name = "btiLogo";
            this.btiLogo.Size = new System.Drawing.Size(42, 44);
            this.btiLogo.Text = "Alterar Logo";
            this.btiLogo.ToolTipText = "Alteração da logo do sistema";
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1143, 553);
            this.Controls.Add(this.lblDadosUsuario);
            this.Controls.Add(this.pcbLogoPrincipal);
            this.Controls.Add(this.barraStatus);
            this.Controls.Add(this.barraTarefas);
            this.Controls.Add(this.menuPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.menuPrincipal;
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Aplicação de Exemplo de aula de Contrução de Projetos";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.menuPrincipal.ResumeLayout(false);
            this.menuPrincipal.PerformLayout();
            this.barraTarefas.ResumeLayout(false);
            this.barraTarefas.PerformLayout();
            this.barraStatus.ResumeLayout(false);
            this.barraStatus.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLogoPrincipal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuPrincipal;
        private System.Windows.Forms.ToolStripMenuItem mniCadastro;
        private System.Windows.Forms.ToolStripMenuItem mniNovo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem mniListarPessoas;
        private System.Windows.Forms.ToolStripMenuItem mniConfig;
        private System.Windows.Forms.ToolStripMenuItem mniLogotipo;
        private System.Windows.Forms.ToolStrip barraTarefas;
        private System.Windows.Forms.ToolStripButton btiNovo;
        private System.Windows.Forms.ToolStripButton btiLogo;
        private System.Windows.Forms.StatusStrip barraStatus;
        private System.Windows.Forms.ToolStripStatusLabel bsiDataHora;
        private System.Windows.Forms.PictureBox pcbLogoPrincipal;
        private System.Windows.Forms.Timer relogio;
        private System.Windows.Forms.Label lblDadosUsuario;
    }
}

