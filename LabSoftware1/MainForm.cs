using System.Globalization;
using System.Numerics;

namespace LabSoftware1
{
    public partial class MainForm : Form
    {
        public List<Cliente> clientes { get; set; }
        public List<Pagamento> pagamentos { get; set; }


        public MainForm()
        {
            InitializeComponent();
        }

        private void btnArqClientes_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "C:\\"; // Diretório inicial
                openFileDialog.Filter = "Todos os arquivos (*.*)|*.*|Arquivos de texto (*.txt)|*.txt";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Mostra o caminho do arquivo no TextBox
                    txtArqCliente.Text = openFileDialog.FileName;
                }
            }
        }

        private void btnArqPgtos_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "C:\\"; // Diretório inicial
                openFileDialog.Filter = "Todos os arquivos (*.*)|*.*|Arquivos de texto (*.txt)|*.txt";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Mostra o caminho do arquivo no TextBox
                    txtArqPagamento.Text = openFileDialog.FileName;
                }
            }
        }

        private void btnImpClientes_Click(object sender, EventArgs e)
        {
            var caminho = txtArqCliente.Text;

            if (!File.Exists(caminho))
            {
                MessageBox.Show("Arquivo não encontrado!");
                return;
            }

            clientes = File.ReadLines(caminho)
                       .Select(linha => linha.Split(';'))
                       .Select(dados => new Cliente
                       {
                           Id = int.Parse(dados[0]),
                           CPF = dados[1],
                           CEP = dados[2],
                           Telefone = dados[3],
                           Nome = dados[4]
                       })
                       .ToList();
            dgvClientes.DataSource = clientes;

            MessageBox.Show("Arquivo importado com sucesso!");
        }

        private void btnImpPgtos_Click(object sender, EventArgs e)
        {
            var caminho = txtArqPagamento.Text;

            if (!File.Exists(caminho))
            {
                MessageBox.Show("Arquivo não encontrado!");
                return;
            }

            pagamentos = File.ReadLines(caminho)
                       .Select(linha => linha.Split(';'))
                       .Select(dados => new Pagamento()
                       {
                           Id = int.Parse(dados[0]),
                           Data = RetornarDataArquivo(dados[1]),
                           DadoLivre = dados[2],
                           Valor = decimal.Parse(dados[3], CultureInfo.InvariantCulture),
                           Pago = dados[4] == "t"
                       }).ToList();
            dgvPagamentos.DataSource = pagamentos;

            MessageBox.Show("Arquivo importado com sucesso!");

            if (clientes.Count > 0 && pagamentos.Count > 0) 
            {
                GerarRelatorios();
            }
        }
        private DateTime RetornarDataArquivo(string data)
        {
            if (data.Length < 8)
            {
                data = $"0{data}";
            }
            return DateTime.ParseExact(data, "ddMMyyyy", CultureInfo.InvariantCulture);
        }
        private void GerarRelatorios()
        {
            GerarRelatorioValorDevido();
            GerarRelatorioTotaisPorData();
        }
        private void GerarRelatorioValorDevido()
        {
            var valoresDevidos = new List<ValorDevidoReport>();

            foreach (var cliente in clientes)
            {
                decimal totalPago = 0;
                decimal totalDevido = 0;

                foreach (var pagamento in pagamentos.Where(x => x.Id == cliente.Id))
                { 
                    if (pagamento.Pago)
                    {

                        totalPago += pagamento.Valor;
                    }
                    else
                    {
                        totalDevido += pagamento.Valor;
                    }
                }

                valoresDevidos.Add(new ValorDevidoReport()
                {
                    Cliente = cliente.Nome,
                    ValorDevido = totalDevido,
                    ValorPago = totalPago
                });
            }

            dgvValorDevidoReport.DataSource = valoresDevidos;
        }
        private void GerarRelatorioTotaisPorData()
        {
            var totaisPorData = new List<TotaisPorDataReport>();

            pagamentos = pagamentos.OrderBy(x => x.Data).ToList();

            totaisPorData.AddRange(pagamentos.GroupBy(x => x.Data).Select(g => new TotaisPorDataReport()
            {
                Data = g.Key.Date,
                ValorAReceber = g.Sum(y => y.Valor),
                ValorRecebido = g.Where(y => y.Pago).Sum(y => y.Valor)
            }));

            dgvTotaisPorDiaReport.DataSource = totaisPorData;
        }
    }
}
