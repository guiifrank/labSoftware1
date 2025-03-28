namespace LabSoftware1
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            tabControl1 = new TabControl();
            tabImportacao = new TabPage();
            btnImpPgtos = new Button();
            btnImpClientes = new Button();
            txtArqPagamento = new TextBox();
            btnArqPgtos = new Button();
            label2 = new Label();
            btnArqClientes = new Button();
            txtArqCliente = new TextBox();
            label3 = new Label();
            tabPage2 = new TabPage();
            dgvClientes = new DataGridView();
            tabPage1 = new TabPage();
            dgvPagamentos = new DataGridView();
            tabPage3 = new TabPage();
            dgvTotaisPorDiaReport = new DataGridView();
            dgvValorDevidoReport = new DataGridView();
            label4 = new Label();
            label1 = new Label();
            tabControl1.SuspendLayout();
            tabImportacao.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).BeginInit();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPagamentos).BeginInit();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTotaisPorDiaReport).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvValorDevidoReport).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabImportacao);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Location = new Point(12, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(583, 426);
            tabControl1.TabIndex = 0;
            // 
            // tabImportacao
            // 
            tabImportacao.Controls.Add(btnImpPgtos);
            tabImportacao.Controls.Add(btnImpClientes);
            tabImportacao.Controls.Add(txtArqPagamento);
            tabImportacao.Controls.Add(btnArqPgtos);
            tabImportacao.Controls.Add(label2);
            tabImportacao.Controls.Add(btnArqClientes);
            tabImportacao.Controls.Add(txtArqCliente);
            tabImportacao.Controls.Add(label3);
            tabImportacao.Location = new Point(4, 24);
            tabImportacao.Name = "tabImportacao";
            tabImportacao.Padding = new Padding(3);
            tabImportacao.Size = new Size(575, 398);
            tabImportacao.TabIndex = 0;
            tabImportacao.Text = "Importação";
            tabImportacao.UseVisualStyleBackColor = true;
            // 
            // btnImpPgtos
            // 
            btnImpPgtos.Location = new Point(469, 44);
            btnImpPgtos.Name = "btnImpPgtos";
            btnImpPgtos.Size = new Size(75, 23);
            btnImpPgtos.TabIndex = 21;
            btnImpPgtos.Text = "Importar";
            btnImpPgtos.UseVisualStyleBackColor = true;
            btnImpPgtos.Click += btnImpPgtos_Click;
            // 
            // btnImpClientes
            // 
            btnImpClientes.Location = new Point(469, 14);
            btnImpClientes.Name = "btnImpClientes";
            btnImpClientes.Size = new Size(75, 23);
            btnImpClientes.TabIndex = 20;
            btnImpClientes.Text = "Importar";
            btnImpClientes.UseVisualStyleBackColor = true;
            btnImpClientes.Click += btnImpClientes_Click;
            // 
            // txtArqPagamento
            // 
            txtArqPagamento.Location = new Point(136, 41);
            txtArqPagamento.Name = "txtArqPagamento";
            txtArqPagamento.Size = new Size(278, 23);
            txtArqPagamento.TabIndex = 18;
            // 
            // btnArqPgtos
            // 
            btnArqPgtos.Image = (Image)resources.GetObject("btnArqPgtos.Image");
            btnArqPgtos.Location = new Point(420, 44);
            btnArqPgtos.Name = "btnArqPgtos";
            btnArqPgtos.Size = new Size(33, 23);
            btnArqPgtos.TabIndex = 19;
            btnArqPgtos.UseVisualStyleBackColor = true;
            btnArqPgtos.Click += btnArqPgtos_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(9, 44);
            label2.Name = "label2";
            label2.Size = new Size(121, 15);
            label2.TabIndex = 17;
            label2.Text = "Arquivo Pagamentos:";
            // 
            // btnArqClientes
            // 
            btnArqClientes.Image = (Image)resources.GetObject("btnArqClientes.Image");
            btnArqClientes.Location = new Point(420, 12);
            btnArqClientes.Name = "btnArqClientes";
            btnArqClientes.Size = new Size(33, 23);
            btnArqClientes.TabIndex = 16;
            btnArqClientes.UseVisualStyleBackColor = true;
            btnArqClientes.Click += btnArqClientes_Click;
            // 
            // txtArqCliente
            // 
            txtArqCliente.Location = new Point(136, 12);
            txtArqCliente.Name = "txtArqCliente";
            txtArqCliente.Size = new Size(278, 23);
            txtArqCliente.TabIndex = 15;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(9, 16);
            label3.Name = "label3";
            label3.Size = new Size(97, 15);
            label3.TabIndex = 14;
            label3.Text = "Arquivo Clientes:";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(dgvClientes);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(575, 398);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Clientes";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgvClientes
            // 
            dgvClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClientes.Location = new Point(6, 6);
            dgvClientes.Name = "dgvClientes";
            dgvClientes.ReadOnly = true;
            dgvClientes.RowHeadersVisible = false;
            dgvClientes.Size = new Size(563, 386);
            dgvClientes.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(dgvPagamentos);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(575, 398);
            tabPage1.TabIndex = 2;
            tabPage1.Text = "Pagamentos";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgvPagamentos
            // 
            dgvPagamentos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPagamentos.Location = new Point(6, 6);
            dgvPagamentos.Name = "dgvPagamentos";
            dgvPagamentos.ReadOnly = true;
            dgvPagamentos.RowHeadersVisible = false;
            dgvPagamentos.Size = new Size(563, 386);
            dgvPagamentos.TabIndex = 1;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(dgvTotaisPorDiaReport);
            tabPage3.Controls.Add(dgvValorDevidoReport);
            tabPage3.Controls.Add(label4);
            tabPage3.Controls.Add(label1);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(575, 398);
            tabPage3.TabIndex = 3;
            tabPage3.Text = "Relatórios";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // dgvTotaisPorDiaReport
            // 
            dgvTotaisPorDiaReport.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTotaisPorDiaReport.Location = new Point(21, 227);
            dgvTotaisPorDiaReport.Name = "dgvTotaisPorDiaReport";
            dgvTotaisPorDiaReport.RowHeadersVisible = false;
            dgvTotaisPorDiaReport.Size = new Size(535, 150);
            dgvTotaisPorDiaReport.TabIndex = 3;
            // 
            // dgvValorDevidoReport
            // 
            dgvValorDevidoReport.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvValorDevidoReport.Location = new Point(21, 38);
            dgvValorDevidoReport.Name = "dgvValorDevidoReport";
            dgvValorDevidoReport.RowHeadersVisible = false;
            dgvValorDevidoReport.Size = new Size(535, 150);
            dgvValorDevidoReport.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(21, 198);
            label4.Name = "label4";
            label4.Size = new Size(92, 15);
            label4.TabIndex = 1;
            label4.Text = "Valores por Data";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 20);
            label1.Name = "label1";
            label1.Size = new Size(73, 15);
            label1.TabIndex = 0;
            label1.Text = "Valor Devido";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(611, 450);
            Controls.Add(tabControl1);
            Name = "MainForm";
            Text = "Sistema de Pagamentos";
            tabControl1.ResumeLayout(false);
            tabImportacao.ResumeLayout(false);
            tabImportacao.PerformLayout();
            tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvClientes).EndInit();
            tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvPagamentos).EndInit();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTotaisPorDiaReport).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvValorDevidoReport).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabImportacao;
        private TabPage tabPage2;
        private Button btnImpPgtos;
        private Button btnImpClientes;
        private TextBox txtArqPagamento;
        private Button btnArqPgtos;
        private Label label2;
        private Button btnArqClientes;
        private TextBox txtArqCliente;
        private Label label3;
        private DataGridView dgvClientes;
        private TabPage tabPage1;
        private DataGridView dgvPagamentos;
        private TabPage tabPage3;
        private Label label1;
        private Label label4;
        private DataGridView dgvTotaisPorDiaReport;
        private DataGridView dgvValorDevidoReport;
    }
}
