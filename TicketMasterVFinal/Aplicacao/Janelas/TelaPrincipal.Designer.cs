namespace TicketMasterVFinal.Aplicacao.Janelas
{
    partial class TelaPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaPrincipal));
            menuStrip1 = new MenuStrip();
            cadastrarToolStripMenuItem = new ToolStripMenuItem();
            menuCadFuncionario = new ToolStripMenuItem();
            menuCadTicket = new ToolStripMenuItem();
            editarToolStripMenuItem = new ToolStripMenuItem();
            menuEditFuncionario = new ToolStripMenuItem();
            menuEditTicket = new ToolStripMenuItem();
            relatóriosToolStripMenuItem = new ToolStripMenuItem();
            funcionárioXTicketsToolStripMenuItem = new ToolStripMenuItem();
            pEntrada = new Panel();
            TicketMaster = new Label();
            pCadFuncionario = new Panel();
            btnCadFuncionario = new Button();
            label2 = new Label();
            fCadCPF = new MaskedTextBox();
            asa = new Label();
            tCadNome = new TextBox();
            label1 = new Label();
            pCadTicket = new Panel();
            btnConsultarFuncionarios = new Button();
            tCadQtdeTickets = new TextBox();
            btnCadTicket = new Button();
            label3 = new Label();
            label4 = new Label();
            tCadFuncTicket = new TextBox();
            label5 = new Label();
            pEditFuncionario = new Panel();
            cEditFuncionario = new ComboBox();
            button1 = new Button();
            tEditFuncionario = new TextBox();
            btnEditarFuncionario = new Button();
            label6 = new Label();
            label7 = new Label();
            tEditCPF = new TextBox();
            label8 = new Label();
            pEditTicket = new Panel();
            txtaaa = new Label();
            tEditTicketQuantidade = new TextBox();
            cEditTicketAtivo = new ComboBox();
            btnConsultarTicketEdit = new Button();
            tEditTicketNomeFunc = new TextBox();
            button3 = new Button();
            label9 = new Label();
            label10 = new Label();
            tEditTicketFuncCPF = new TextBox();
            label11 = new Label();
            menuStrip1.SuspendLayout();
            pEntrada.SuspendLayout();
            pCadFuncionario.SuspendLayout();
            pCadTicket.SuspendLayout();
            pEditFuncionario.SuspendLayout();
            pEditTicket.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { cadastrarToolStripMenuItem, editarToolStripMenuItem, relatóriosToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(782, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // cadastrarToolStripMenuItem
            // 
            cadastrarToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { menuCadFuncionario, menuCadTicket });
            cadastrarToolStripMenuItem.Name = "cadastrarToolStripMenuItem";
            cadastrarToolStripMenuItem.Size = new Size(86, 24);
            cadastrarToolStripMenuItem.Text = "Cadastrar";
            // 
            // menuCadFuncionario
            // 
            menuCadFuncionario.Name = "menuCadFuncionario";
            menuCadFuncionario.Size = new Size(169, 26);
            menuCadFuncionario.Text = "Funcionário";
            menuCadFuncionario.Click += menuCadFuncionario_Click;
            // 
            // menuCadTicket
            // 
            menuCadTicket.Name = "menuCadTicket";
            menuCadTicket.Size = new Size(169, 26);
            menuCadTicket.Text = "Ticket";
            menuCadTicket.Click += menuCadTicket_Click;
            // 
            // editarToolStripMenuItem
            // 
            editarToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { menuEditFuncionario, menuEditTicket });
            editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            editarToolStripMenuItem.Size = new Size(62, 24);
            editarToolStripMenuItem.Text = "Editar";
            // 
            // menuEditFuncionario
            // 
            menuEditFuncionario.Name = "menuEditFuncionario";
            menuEditFuncionario.Size = new Size(169, 26);
            menuEditFuncionario.Text = "Funcionário";
            menuEditFuncionario.Click += menuEditFuncionario_Click;
            // 
            // menuEditTicket
            // 
            menuEditTicket.Name = "menuEditTicket";
            menuEditTicket.Size = new Size(169, 26);
            menuEditTicket.Text = "Ticket";
            menuEditTicket.Click += menuEditTicket_Click;
            // 
            // relatóriosToolStripMenuItem
            // 
            relatóriosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { funcionárioXTicketsToolStripMenuItem });
            relatóriosToolStripMenuItem.Name = "relatóriosToolStripMenuItem";
            relatóriosToolStripMenuItem.Size = new Size(90, 24);
            relatóriosToolStripMenuItem.Text = "Relatórios";
            // 
            // funcionárioXTicketsToolStripMenuItem
            // 
            funcionárioXTicketsToolStripMenuItem.Name = "funcionárioXTicketsToolStripMenuItem";
            funcionárioXTicketsToolStripMenuItem.Size = new Size(311, 26);
            funcionárioXTicketsToolStripMenuItem.Text = "Funcionário x Tickets por Período";
            funcionárioXTicketsToolStripMenuItem.Click += funcionárioXTicketsToolStripMenuItem_Click;
            // 
            // pEntrada
            // 
            pEntrada.Controls.Add(TicketMaster);
            pEntrada.Location = new Point(0, 31);
            pEntrada.Name = "pEntrada";
            pEntrada.Size = new Size(782, 524);
            pEntrada.TabIndex = 1;
            // 
            // TicketMaster
            // 
            TicketMaster.AutoSize = true;
            TicketMaster.Font = new Font("Palatino Linotype", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TicketMaster.Location = new Point(387, 433);
            TicketMaster.Name = "TicketMaster";
            TicketMaster.Size = new Size(383, 80);
            TicketMaster.TabIndex = 0;
            TicketMaster.Text = "TicketMaster";
            // 
            // pCadFuncionario
            // 
            pCadFuncionario.Controls.Add(btnCadFuncionario);
            pCadFuncionario.Controls.Add(label2);
            pCadFuncionario.Controls.Add(fCadCPF);
            pCadFuncionario.Controls.Add(asa);
            pCadFuncionario.Controls.Add(tCadNome);
            pCadFuncionario.Controls.Add(label1);
            pCadFuncionario.Location = new Point(0, 31);
            pCadFuncionario.Name = "pCadFuncionario";
            pCadFuncionario.Size = new Size(782, 521);
            pCadFuncionario.TabIndex = 1;
            // 
            // btnCadFuncionario
            // 
            btnCadFuncionario.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCadFuncionario.Location = new Point(393, 380);
            btnCadFuncionario.Name = "btnCadFuncionario";
            btnCadFuncionario.Size = new Size(165, 54);
            btnCadFuncionario.TabIndex = 5;
            btnCadFuncionario.Text = "Cadastrar";
            btnCadFuncionario.UseVisualStyleBackColor = true;
            btnCadFuncionario.Click += btnCadFuncionario_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(222, 261);
            label2.Name = "label2";
            label2.Size = new Size(77, 46);
            label2.TabIndex = 4;
            label2.Text = "CPF";
            // 
            // fCadCPF
            // 
            fCadCPF.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            fCadCPF.Location = new Point(222, 310);
            fCadCPF.Mask = "999,999,999-99";
            fCadCPF.Name = "fCadCPF";
            fCadCPF.Size = new Size(336, 51);
            fCadCPF.TabIndex = 3;
            // 
            // asa
            // 
            asa.AutoSize = true;
            asa.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            asa.Location = new Point(222, 149);
            asa.Name = "asa";
            asa.Size = new Size(112, 46);
            asa.TabIndex = 2;
            asa.Text = "Nome";
            // 
            // tCadNome
            // 
            tCadNome.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tCadNome.Location = new Point(222, 198);
            tCadNome.Name = "tCadNome";
            tCadNome.Size = new Size(336, 51);
            tCadNome.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(174, 64);
            label1.Name = "label1";
            label1.Size = new Size(432, 60);
            label1.TabIndex = 0;
            label1.Text = "Cadastra Funcionário";
            // 
            // pCadTicket
            // 
            pCadTicket.Controls.Add(btnConsultarFuncionarios);
            pCadTicket.Controls.Add(tCadQtdeTickets);
            pCadTicket.Controls.Add(btnCadTicket);
            pCadTicket.Controls.Add(label3);
            pCadTicket.Controls.Add(label4);
            pCadTicket.Controls.Add(tCadFuncTicket);
            pCadTicket.Controls.Add(label5);
            pCadTicket.Location = new Point(0, 31);
            pCadTicket.Name = "pCadTicket";
            pCadTicket.Size = new Size(782, 521);
            pCadTicket.TabIndex = 6;
            // 
            // btnConsultarFuncionarios
            // 
            btnConsultarFuncionarios.Location = new Point(506, 209);
            btnConsultarFuncionarios.Name = "btnConsultarFuncionarios";
            btnConsultarFuncionarios.Size = new Size(53, 53);
            btnConsultarFuncionarios.TabIndex = 13;
            btnConsultarFuncionarios.Text = "...";
            btnConsultarFuncionarios.UseVisualStyleBackColor = true;
            btnConsultarFuncionarios.Click += btnConsultarFuncionarios_Click;
            // 
            // tCadQtdeTickets
            // 
            tCadQtdeTickets.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tCadQtdeTickets.Location = new Point(222, 321);
            tCadQtdeTickets.Name = "tCadQtdeTickets";
            tCadQtdeTickets.Size = new Size(336, 51);
            tCadQtdeTickets.TabIndex = 12;
            // 
            // btnCadTicket
            // 
            btnCadTicket.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCadTicket.Location = new Point(394, 391);
            btnCadTicket.Name = "btnCadTicket";
            btnCadTicket.Size = new Size(165, 54);
            btnCadTicket.TabIndex = 11;
            btnCadTicket.Text = "Cadastrar";
            btnCadTicket.UseVisualStyleBackColor = true;
            btnCadTicket.Click += btnCadTicket_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(222, 277);
            label3.Name = "label3";
            label3.Size = new Size(315, 41);
            label3.TabIndex = 10;
            label3.Text = "Quantidade de Tickets";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(223, 165);
            label4.Name = "label4";
            label4.Size = new Size(232, 41);
            label4.TabIndex = 8;
            label4.Text = "CPF Funcionário";
            // 
            // tCadFuncTicket
            // 
            tCadFuncTicket.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tCadFuncTicket.Location = new Point(223, 209);
            tCadFuncTicket.Name = "tCadFuncTicket";
            tCadFuncTicket.Size = new Size(277, 51);
            tCadFuncTicket.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(235, 75);
            label5.Name = "label5";
            label5.Size = new Size(323, 60);
            label5.TabIndex = 6;
            label5.Text = "Cadastro Ticket";
            // 
            // pEditFuncionario
            // 
            pEditFuncionario.Controls.Add(cEditFuncionario);
            pEditFuncionario.Controls.Add(button1);
            pEditFuncionario.Controls.Add(tEditFuncionario);
            pEditFuncionario.Controls.Add(btnEditarFuncionario);
            pEditFuncionario.Controls.Add(label6);
            pEditFuncionario.Controls.Add(label7);
            pEditFuncionario.Controls.Add(tEditCPF);
            pEditFuncionario.Controls.Add(label8);
            pEditFuncionario.Location = new Point(0, 31);
            pEditFuncionario.Name = "pEditFuncionario";
            pEditFuncionario.Size = new Size(782, 518);
            pEditFuncionario.TabIndex = 14;
            // 
            // cEditFuncionario
            // 
            cEditFuncionario.DropDownStyle = ComboBoxStyle.DropDownList;
            cEditFuncionario.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cEditFuncionario.Items.AddRange(new object[] { "Ativo", "Inativo" });
            cEditFuncionario.Location = new Point(224, 391);
            cEditFuncionario.Name = "cEditFuncionario";
            cEditFuncionario.Size = new Size(151, 53);
            cEditFuncionario.TabIndex = 21;
            // 
            // button1
            // 
            button1.Location = new Point(507, 323);
            button1.Name = "button1";
            button1.Size = new Size(53, 53);
            button1.TabIndex = 20;
            button1.Text = "...";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnConsultarFuncionariosEdit_Click;
            // 
            // tEditFuncionario
            // 
            tEditFuncionario.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tEditFuncionario.Location = new Point(224, 209);
            tEditFuncionario.Name = "tEditFuncionario";
            tEditFuncionario.Size = new Size(336, 51);
            tEditFuncionario.TabIndex = 19;
            // 
            // btnEditarFuncionario
            // 
            btnEditarFuncionario.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEditarFuncionario.Location = new Point(395, 391);
            btnEditarFuncionario.Name = "btnEditarFuncionario";
            btnEditarFuncionario.Size = new Size(165, 53);
            btnEditarFuncionario.TabIndex = 18;
            btnEditarFuncionario.Text = "Editar";
            btnEditarFuncionario.UseVisualStyleBackColor = true;
            btnEditarFuncionario.Click += btnEditarFuncionario_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(224, 165);
            label6.Name = "label6";
            label6.Size = new Size(263, 41);
            label6.TabIndex = 17;
            label6.Text = "Nome Funcionário";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(224, 279);
            label7.Name = "label7";
            label7.Size = new Size(232, 41);
            label7.TabIndex = 16;
            label7.Text = "CPF Funcionário";
            // 
            // tEditCPF
            // 
            tEditCPF.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tEditCPF.Location = new Point(224, 323);
            tEditCPF.Name = "tEditCPF";
            tEditCPF.Size = new Size(277, 51);
            tEditCPF.TabIndex = 15;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(209, 75);
            label8.Name = "label8";
            label8.Size = new Size(375, 60);
            label8.TabIndex = 14;
            label8.Text = "Editar Funcionário";
            // 
            // pEditTicket
            // 
            pEditTicket.Controls.Add(txtaaa);
            pEditTicket.Controls.Add(tEditTicketQuantidade);
            pEditTicket.Controls.Add(cEditTicketAtivo);
            pEditTicket.Controls.Add(btnConsultarTicketEdit);
            pEditTicket.Controls.Add(tEditTicketNomeFunc);
            pEditTicket.Controls.Add(button3);
            pEditTicket.Controls.Add(label9);
            pEditTicket.Controls.Add(label10);
            pEditTicket.Controls.Add(tEditTicketFuncCPF);
            pEditTicket.Controls.Add(label11);
            pEditTicket.Location = new Point(0, 31);
            pEditTicket.Name = "pEditTicket";
            pEditTicket.Size = new Size(779, 518);
            pEditTicket.TabIndex = 22;
            // 
            // txtaaa
            // 
            txtaaa.AutoSize = true;
            txtaaa.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtaaa.Location = new Point(234, 307);
            txtaaa.Name = "txtaaa";
            txtaaa.Size = new Size(315, 41);
            txtaaa.TabIndex = 31;
            txtaaa.Text = "Quantidade de Tickets";
            // 
            // tEditTicketQuantidade
            // 
            tEditTicketQuantidade.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tEditTicketQuantidade.Location = new Point(234, 346);
            tEditTicketQuantidade.Name = "tEditTicketQuantidade";
            tEditTicketQuantidade.Size = new Size(338, 51);
            tEditTicketQuantidade.TabIndex = 30;
            // 
            // cEditTicketAtivo
            // 
            cEditTicketAtivo.DropDownStyle = ComboBoxStyle.DropDownList;
            cEditTicketAtivo.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cEditTicketAtivo.Items.AddRange(new object[] { "Ativo", "Inativo" });
            cEditTicketAtivo.Location = new Point(233, 413);
            cEditTicketAtivo.Name = "cEditTicketAtivo";
            cEditTicketAtivo.Size = new Size(151, 53);
            cEditTicketAtivo.TabIndex = 29;
            // 
            // btnConsultarTicketEdit
            // 
            btnConsultarTicketEdit.Location = new Point(522, 139);
            btnConsultarTicketEdit.Name = "btnConsultarTicketEdit";
            btnConsultarTicketEdit.Size = new Size(53, 53);
            btnConsultarTicketEdit.TabIndex = 28;
            btnConsultarTicketEdit.Text = "...";
            btnConsultarTicketEdit.UseVisualStyleBackColor = true;
            btnConsultarTicketEdit.Click += btnConsultarTicketEdit_Click;
            // 
            // tEditTicketNomeFunc
            // 
            tEditTicketNomeFunc.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tEditTicketNomeFunc.Location = new Point(235, 141);
            tEditTicketNomeFunc.Name = "tEditTicketNomeFunc";
            tEditTicketNomeFunc.Size = new Size(278, 51);
            tEditTicketNomeFunc.TabIndex = 27;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.Location = new Point(410, 413);
            button3.Name = "button3";
            button3.Size = new Size(165, 53);
            button3.TabIndex = 26;
            button3.Text = "Editar";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(233, 97);
            label9.Name = "label9";
            label9.Size = new Size(263, 41);
            label9.TabIndex = 25;
            label9.Text = "Nome Funcionário";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(235, 204);
            label10.Name = "label10";
            label10.Size = new Size(232, 41);
            label10.TabIndex = 24;
            label10.Text = "CPF Funcionário";
            // 
            // tEditTicketFuncCPF
            // 
            tEditTicketFuncCPF.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tEditTicketFuncCPF.Location = new Point(235, 240);
            tEditTicketFuncCPF.Name = "tEditTicketFuncCPF";
            tEditTicketFuncCPF.Size = new Size(338, 51);
            tEditTicketFuncCPF.TabIndex = 23;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.Location = new Point(258, 22);
            label11.Name = "label11";
            label11.Size = new Size(262, 60);
            label11.TabIndex = 22;
            label11.Text = "Editar Ticket";
            // 
            // TelaPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(782, 553);
            Controls.Add(pEditTicket);
            Controls.Add(pEditFuncionario);
            Controls.Add(pCadTicket);
            Controls.Add(pCadFuncionario);
            Controls.Add(pEntrada);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Name = "TelaPrincipal";
            Text = "TelaPrincipal";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            pEntrada.ResumeLayout(false);
            pEntrada.PerformLayout();
            pCadFuncionario.ResumeLayout(false);
            pCadFuncionario.PerformLayout();
            pCadTicket.ResumeLayout(false);
            pCadTicket.PerformLayout();
            pEditFuncionario.ResumeLayout(false);
            pEditFuncionario.PerformLayout();
            pEditTicket.ResumeLayout(false);
            pEditTicket.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem cadastrarToolStripMenuItem;
        private ToolStripMenuItem menuCadFuncionario;
        private ToolStripMenuItem menuCadTicket;
        private ToolStripMenuItem editarToolStripMenuItem;
        private ToolStripMenuItem relatóriosToolStripMenuItem;
        private Panel pEntrada;
        private Label TicketMaster;
        private Panel pCadFuncionario;
        private Label asa;
        private TextBox tCadNome;
        private Label label1;
        private MaskedTextBox fCadCPF;
        private Label label2;
        private Button btnCadFuncionario;
        private Panel pCadTicket;
        private TextBox tCadQtdeTickets;
        private Button btnCadTicket;
        private Label label3;
        private Label label4;
        private TextBox tCadFuncTicket;
        private Label label5;
        private Button btnConsultarFuncionarios;
        private ToolStripMenuItem menuEditFuncionario;
        private ToolStripMenuItem menuEditTicket;
        private ToolStripMenuItem funcionárioXTicketsToolStripMenuItem;
        private Panel pEditFuncionario;
        private Button button1;
        private Button btnEditarFuncionario;
        private Label label7;
        private TextBox tEditCPF;
        private Label label8;
        private TextBox tEditFuncionario;
        private Label label6;
        private ComboBox cEditFuncionario;
        private Panel pEditTicket;
        private Button btnConsultarTicketEdit;
        private TextBox tEditTicketNomeFunc;
        private Button button3;
        private Label label9;
        private Label label10;
        private TextBox tEditTicketFuncCPF;
        private Label label11;
        private ComboBox cEditTicketAtivo;
        private Label txtaaa;
        private TextBox tEditTicketQuantidade;
    }
}