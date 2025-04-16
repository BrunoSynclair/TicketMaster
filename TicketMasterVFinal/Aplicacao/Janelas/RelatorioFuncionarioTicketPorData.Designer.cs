namespace TicketMasterVFinal.Aplicacao.Janelas
{
    partial class RelatorioFuncionarioTicketPorData
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RelatorioFuncionarioTicketPorData));
            pRelatorioFuncionarioTicketPorData = new Panel();
            btnGerarRelatorioFuncTicketPorData = new Button();
            dtFim = new DateTimePicker();
            dtInicio = new DateTimePicker();
            label1 = new Label();
            pRelatorioFuncionarioTicketPorData.SuspendLayout();
            SuspendLayout();
            // 
            // pRelatorioFuncionarioTicketPorData
            // 
            pRelatorioFuncionarioTicketPorData.Controls.Add(btnGerarRelatorioFuncTicketPorData);
            pRelatorioFuncionarioTicketPorData.Controls.Add(dtFim);
            pRelatorioFuncionarioTicketPorData.Controls.Add(dtInicio);
            pRelatorioFuncionarioTicketPorData.Controls.Add(label1);
            pRelatorioFuncionarioTicketPorData.Location = new Point(1, 1);
            pRelatorioFuncionarioTicketPorData.Name = "pRelatorioFuncionarioTicketPorData";
            pRelatorioFuncionarioTicketPorData.Size = new Size(429, 261);
            pRelatorioFuncionarioTicketPorData.TabIndex = 0;
            // 
            // btnGerarRelatorioFuncTicketPorData
            // 
            btnGerarRelatorioFuncTicketPorData.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnGerarRelatorioFuncTicketPorData.Location = new Point(182, 165);
            btnGerarRelatorioFuncTicketPorData.Name = "btnGerarRelatorioFuncTicketPorData";
            btnGerarRelatorioFuncTicketPorData.Size = new Size(174, 36);
            btnGerarRelatorioFuncTicketPorData.TabIndex = 3;
            btnGerarRelatorioFuncTicketPorData.Text = "Gerar Relatório";
            btnGerarRelatorioFuncTicketPorData.UseVisualStyleBackColor = true;
            btnGerarRelatorioFuncTicketPorData.Click += btnGerarRelatorioFuncTicketPorData_Click;
            // 
            // dtFim
            // 
            dtFim.CalendarFont = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtFim.Location = new Point(62, 113);
            dtFim.Name = "dtFim";
            dtFim.Size = new Size(294, 27);
            dtFim.TabIndex = 2;
            // 
            // dtInicio
            // 
            dtInicio.CalendarFont = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtInicio.Location = new Point(62, 80);
            dtInicio.Name = "dtInicio";
            dtInicio.Size = new Size(294, 27);
            dtInicio.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(44, 18);
            label1.Name = "label1";
            label1.Size = new Size(331, 23);
            label1.TabIndex = 0;
            label1.Text = "Relatório de Ticket e Funcionário por Data";
            // 
            // RelatorioFuncionarioTicketPorData
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(430, 260);
            Controls.Add(pRelatorioFuncionarioTicketPorData);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "RelatorioFuncionarioTicketPorData";
            Text = "RelatorioFuncionarioTicketPorData";
            pRelatorioFuncionarioTicketPorData.ResumeLayout(false);
            pRelatorioFuncionarioTicketPorData.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pRelatorioFuncionarioTicketPorData;
        private Label label1;
        private Button btnGerarRelatorioFuncTicketPorData;
        private DateTimePicker dtFim;
        private DateTimePicker dtInicio;
    }
}