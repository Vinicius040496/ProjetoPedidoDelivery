using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetoEnum.Entidades;
using ProjetoEnum.Entidades.Enums;

namespace ProjetoEnum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pedido pedido = new Pedido
            { ID = 1080, Moment = DateTime.Now, Status = PedidoStatus.PagamentoPendente };

            Console.WriteLine(pedido);

            // convertendo o pagamneto pedente int 0, para string.
            string Txt = PedidoStatus.PagamentoPendente.ToString();

            Console.WriteLine(Txt);

            // convertendo string para tipo enumerado.
            // a string precisa ter exatamente o mesmo nome na classe pedido status, caso contrario falha
            PedidoStatus os = (PedidoStatus)Enum.Parse(typeof(PedidoStatus), "Entregue");

            Console.WriteLine(os);
            Console.ReadLine();
        }
    }
}
