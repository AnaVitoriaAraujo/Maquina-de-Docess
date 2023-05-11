using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace MaquinaDeDoces
{
    class Pagamento
    {
        //Definição das variaveis
        private int codigo;
        private string descricao;
        private int valorTotal;
        private string formaDePagamento;
        private DateTime dataHora;
        private int codCartao;
        private string bandeiraCartao;
        private string valor;
        private int dinheiro; 

        public Pagamento()
        {
            ModificarCodigo = 0;
            ModificarDescricao = "";
            ModificarValorTotal = 0;
            ModificarFormaDePagamento = "";
            ModificarDataHora = new DateTime();//0000/00/00 00:00:00
            ModificarCodCartao = 0;
            ModificarBandeiraCartao = "";

        }//fim do metodo contrutor sem parametros

        public Pagamento(int codigo, string descricao, int valorTotal,
            string formaDePagamento, DateTime dataHora, int codCartao, string bandeiraCartao)
        {
            ModificarCodigo = codigo;
            ModificarDescricao = descricao;
            ModificarValorTotal = valorTotal;
            ModificarFormaDePagamento = formaDePagamento;
            ModificarDataHora = dataHora;
            ModificarCodCartao = codCartao;
            ModificarBandeiraCartao = bandeiraCartao;
        }//fim do método construtor com parâmetros


        public int ModificarCodigo
        {
            get { return codigo; }
            set { codigo = value; }
        }

        public string ModificarDescricao
        {
            get { return descricao; }
            set { descricao = value; }
        }

        public int ModificarValorTotal
        {
            get { return valorTotal; }
            set { valorTotal = value; }
        }

        public string ModificarFormaDePagamento
        {
            get { return formaDePagamento; }
            set { formaDePagamento = value; }
        }

        public DateTime ModificarDataHora
        {
            get { return dataHora; }
            set { dataHora = value; }
        }

        public int ModificarCodCartao
        {
            get { return codCartao; }
            set { codCartao = value; }

        }

        public string ModificarBandeiraCartao
        {
            get { return bandeiraCartao; }
            set { bandeiraCartao = value; }
        }
        //fim do encapsulamento

        public void codigoo()
        {

            //aqui fiz uma switch case para o usuario escolher se deseja pagar em dinheiro ou cartao
            switch (codigo)
            {
                case 1:
                    Console.WriteLine("Deseja pagar em dinheiro?: ");
                    int FromadePagamento = Convert.ToInt32 (Console.ReadLine());
                    
                    Console.Clear();

                    Console.WriteLine("Informe a nota que deseja inserir?: ");
                    int valor = Convert.ToInt32 (Console.ReadLine());
                    Console.WriteLine("Seu troco é de");

                    Console.Clear() ;

                    if (valor == 0)

                    {
                        Console.WriteLine("Impossivel realizar o pagamento");
                        
                    }if (valor == valorTotal)
                    {
                        Console.WriteLine("");
                    }


                    Console.WriteLine("     Obrigada pelo sua preferencia     ");
                    break;

                case 2:

                    Console.WriteLine("deseja pagar em cartao: ");
                    Console.WriteLine("Seu cartão foi aprovado");
                    Console.WriteLine("Obrigado pela sua compra");

                    break;

                default:
                    Console.WriteLine("Não poderemos prosseguir com a compra: ");
                    Console.WriteLine("Apenas efetuaos pagamentos com dinheiro e cartão!");

                    break;

            }// fim do switch
            
        }// fim do procedimento

        public void exibir()
        {
            Console.WriteLine("Seus dados: " + codigo + descricao + valorTotal + formaDePagamento + dataHora + codCartao + bandeiraCartao);
            Console.WriteLine("Volte sempre :) ");
        }// fim do void

        public int trocoFinal(int valor)
        {

            int ValorTotal;

            if (valor == valorTotal)
            {
                Console.WriteLine("");
            }
            return valor;
        }
    }//fim da classe

}//fim do projeto
