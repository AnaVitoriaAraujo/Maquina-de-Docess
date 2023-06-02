using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaquinaDeDoces
{
    class ControlPagamento
    {       
        Pagamento pgto;
        private short opcao;

        public ControlPagamento()
        {
            pgto = new Pagamento();
        }//fim do construtor

        //get set
        public short ModificarOpcao
        {
            get { return opcao; }
            set { opcao = value; }
        }

        public void EscolherFormaDePagamento()
        {
            Console.WriteLine(pgto.MenuFormaDePagamento());
            ModificarOpcao = Convert.ToInt16(Console.ReadLine());            

        }//fim do registrar pagamento

        public void Operacao()
        {
            EscolherFormaDePagamento();

            switch (ModificarOpcao)
            {
                case 1:
                    Console.WriteLine("Pagamento com dinheiro\n\n");
                    Console.WriteLine("Valor inserido na maquina");
                    double valorInserido = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("\nValor do produto");
                    double valorProduto = Convert.ToDouble(Console.ReadLine());

                    //Utilizar metodo efetuar pagamento
                    pgto.EfetuarPagamentoDinheiro(valorInserido, valorProduto);
                    Console.WriteLine(pgto.imprimir());//chave para acessar classe pagamento

                    break;//chamando o metodo imprimir no pagamento
                case 2:

                    Console.WriteLine("Pagamento com cartão\n\n");
                    Console.WriteLine("Valor do produto");
                    valorProduto= Convert.ToDouble(Console.ReadLine());
                  

                    Console.WriteLine("\ncodigo cartao ");
                    int codCartao = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("bandeira cartao\n 1.Visa\n 2.Mastercad\n 3.Elo");
                    short bandeiraCartao = Convert.ToInt16(Console.ReadLine());

                    //Utilizar metodo efetuar pagamento
                    pgto.EfetuarPagamentoCartao(valorProduto, codCartao, bandeiraCartao);
                    Console.WriteLine(pgto.imprimir());
                    break;

                default:
                    Console.WriteLine("Impossivel ralizar este pagamento tente novamente");
                    break;
            }//fim do metodo

        }//fim do operacao
  
    }//fim da classe
}//fim do método