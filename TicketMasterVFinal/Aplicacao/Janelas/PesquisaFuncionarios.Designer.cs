namespace TicketMasterVFinal.Aplicacao.Janelas
{
    partial class PesquisaFuncionarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PesquisaFuncionarios));
            panel1 = new Panel();
            btnBuscarPesquisaFuncionario = new Button();
            label2 = new Label();
            tPesquisaFuncionariosTela = new TextBox();
            dataGridFuncionarios = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridFuncionarios).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnBuscarPesquisaFuncionario);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(tPesquisaFuncionariosTela);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(216, 529);
            panel1.TabIndex = 0;
            // 
            // btnBuscarPesquisaFuncionario
            // 
            btnBuscarPesquisaFuncionario.Location = new Point(3, 79);
            btnBuscarPesquisaFuncionario.Name = "btnBuscarPesquisaFuncionario";
            btnBuscarPesquisaFuncionario.Size = new Size(210, 30);
            btnBuscarPesquisaFuncionario.TabIndex = 5;
            btnBuscarPesquisaFuncionario.Text = "Buscar";
            btnBuscarPesquisaFuncionario.UseVisualStyleBackColor = true;
            btnBuscarPesquisaFuncionario.Click += btnBuscarPesquisaFuncionario_Click_1;
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
            dataGridFuncionarios.Location = new Point(234, 12);
            dataGridFuncionarios.MultiSelect = false;
            dataGridFuncionarios.Name = "dataGridFuncionarios";
            dataGridFuncionarios.ReadOnly = true;
            dataGridFuncionarios.RightToLeft = RightToLeft.No;
            dataGridFuncionarios.RowHeadersWidth = 51;
            dataGridFuncionarios.Size = new Size(727, 529);
            dataGridFuncionarios.TabIndex = 1;
            dataGridFuncionarios.CellContentClick += dataGridFuncionarios_CellContentClick;
            dataGridFuncionarios.CellContentDoubleClick += dataGridFuncionarios_CellDoubleClick;
            // 
            // PesquisaFuncionarios
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(973, 553);
            Controls.Add(dataGridFuncionarios);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "PesquisaFuncionarios";
            Text = "PesquisaFuncionarios";
            Load += PesquisaFuncionarios_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridFuncionarios).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private DataGridView dataGridFuncionarios;
        private Button btnBuscarPesquisaFuncionario;
        private Label label2;
        private TextBox tPesquisaFuncionariosTela;
    }
}