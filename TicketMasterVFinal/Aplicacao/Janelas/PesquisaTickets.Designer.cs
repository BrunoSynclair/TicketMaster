namespace TicketMasterVFinal.Aplicacao.Janelas
{
    partial class PesquisaTickets
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PesquisaTickets));
            panel1 = new Panel();
            tPesquisaCPF = new Button();
            label2 = new Label();
            tPesquisaFuncionariosTela = new TextBox();
            dataGridFuncionarios = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridFuncionarios).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(tPesquisaCPF);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(tPesquisaFuncionariosTela);
            panel1.Location = new Point(2, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(216, 529);
            panel1.TabIndex = 2;
            // 
            // tPesquisaCPF
            // 
            tPesquisaCPF.Location = new Point(3, 79);
            tPesquisaCPF.Name = "tPesquisaCPF";
            tPesquisaCPF.Size = new Size(210, 30);
            tPesquisaCPF.TabIndex = 5;
            tPesquisaCPF.Text = "Buscar";
            tPesquisaCPF.UseVisualStyleBackColor = true;
            tPesquisaCPF.Click += btnBuscarPesquisaFuncionario_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(24, 8);
            label2.Name = "label2";
            label2.Size = new Size(169, 28);
            label2.TabIndex = 4;
            label2.Text = "Consultar por CPF";
            // 
            // tPesquisaFuncionariosTela
            // 
            tPesquisaFuncionariosTela.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tPesquisaFuncionariosTela.Location = new Point(3, 39);
            tPesquisaFuncionariosTela.Name = "tPesquisaFuncionariosTela";
            tPesquisaFuncionariosTela.Size = new Size(210, 34);
            tPesquisaFuncionariosTela.TabIndex = 3;
            // 
            // dataGridFuncionarios
            // 
            dataGridFuncionarios.AllowUserToAddRows = false;
            dataGridFuncionarios.AllowUserToDeleteRows = false;
            dataGridFuncionarios.AllowUserToResizeRows = false;
            dataGridFuncionarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridFuncionarios.Location = new Point(224, 2);
            dataGridFuncionarios.MultiSelect = false;
            dataGridFuncionarios.Name = "dataGridFuncionarios";
            dataGridFuncionarios.ReadOnly = true;
            dataGridFuncionarios.RightToLeft = RightToLeft.No;
            dataGridFuncionarios.RowHeadersWidth = 51;
            dataGridFuncionarios.Size = new Size(646, 529);
            dataGridFuncionarios.TabIndex = 3;
            dataGridFuncionarios.CellContentClick += dataGridFuncionarios_CellContentClick;
            dataGridFuncionarios.CellContentDoubleClick += dataGridFuncionarios_CellDoubleClick;
            // 
            // PesquisaTickets
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(882, 553);
            Controls.Add(panel1);
            Controls.Add(dataGridFuncionarios);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "PesquisaTickets";
            Text = "PesquisaTickets";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridFuncionarios).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button tPesquisaCPF;
        private Label label2;
        private TextBox tPesquisaFuncionariosTela;
        private DataGridView dataGridFuncionarios;
    }
}