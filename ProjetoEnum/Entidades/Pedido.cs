using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetoEnum.Entidades.Enums;

namespace ProjetoEnum.Entidades
{
    internal class Pedido
    {
        public int ID { get; set; }
        public DateTime Moment { get; set; }
        public PedidoStatus Status { get; set; }

        public override string ToString()
        {
            return ID + ", " + Moment.ToString() + ", " + Status.ToString();
        }
    }
}
