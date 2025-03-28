using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace LabSoftware1
{
    public class Pagamento
    {
        public int Id { get; set; }
        public DateTime Data { get; set; }
        public string DadoLivre { get; set; }
        public decimal Valor { get; set; }
        public bool Pago { get; set; }
    }
}
