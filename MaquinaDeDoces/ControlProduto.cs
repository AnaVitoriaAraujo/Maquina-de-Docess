using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaquinaDeDoces
{
    class ControlProduto//ela dara o controle das acoes para o usuario
    {
        Produto prod;
        private int opcao;

        public ControlProduto()
        {
            prod = new Produto();
            ModificarOpcao= -1;
        }//fim do contrutor

        //metodo get set

        public int ModificarOpcao
        {
            get { return opcao; }
            set { opcao = value; }
        }

        public void Menu()
        {
            
            Console.WriteLine("Escolha uma das opções abaixo: \n" +
                "0. Sair" +
                "1. Cadastrar Produto" +
                "2. Consultar Produto: \n " +
                "3. Atualizar Produto: \n" +
                "4. Mudar Situacao: \n");
            ModificarOpcao = Convert.ToInt32(Console.ReadLine());


        }//fim do menu

        //REalizar a operacao

        public void Operacao()
        {
            do
            {
                Menu();//mostrando o menu na tela
                switch (ModificarOpcao)
                {
                    case 0:
                        Console.WriteLine("Obrigado!");
                        break;

                    case 1:
                        ColetarDados();

                        break;
                    case 2:
                        Consultar();
                        break;
                    case 3:
                        Atualizar();
                        break;
                    case 4:
                        AlterarSituacao();
                        break;
                    default:
                        Console.WriteLine("Opcao escolhida não pé valida!: ");
                        break;



                }//fim do switch case
            } while (ModificarOpcao != 0);

        }//fim do metodo operacao

        //criar um metodo de solicitação de dados
        public void ColetarDados()
        {
            //coletar dados e cadastrando

            Console.WriteLine("Informe um codigo: ");
            int codigo = Convert.ToInt32(Console.ReadLine());//o reed line so converte para texto

            Console.WriteLine("Informe o nome do produto: ");
            string nome = Console.ReadLine();

            Console.WriteLine("Faca uma breve descricão do produto");
            string descricao = Console.ReadLine();

            Console.WriteLine("Informe o preço do produto: ");
            double preco = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Informe a quantidae de produtos em estoque: ");
            int quantidade = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Informe a data de validad4e do produto: ");
            DateTime data = Convert.ToDateTime(Console.ReadLine());

            Console.WriteLine("Informe a situacao: true - atvio / False - inativo");
            Boolean situacao = Convert.ToBoolean(Console.ReadLine());

            //cadastrar produto
            prod.CadastrarProduto(codigo, nome, descricao,preco , quantidade, data, situacao);
            Console.WriteLine("Dado Registrado!");

        }//fim do coletar

           // consultar

            public void Consultar()
            {
                //Consultar os dados do produto
                Console.WriteLine("\n\n\n Informe o codigo que deseja consultar");
                int codigo = Convert.ToInt32(Console.ReadLine());
                //escrever o resultado da pesquisa

                Console.WriteLine("Os dados do produto escolhido são: \n\n\n" + prod.ConsultarProduto(codigo));
                
            }//fim do metodo


    
         public void Atualizar()
            {
                Console.WriteLine("\n\nInforme o código do produto que deseja atualizar: ");
                int codigo = Convert.ToInt32(Console.ReadLine());
            short campo = 0;

            do//do while é o repita até
            {
                Console.WriteLine("Informe o campo que deseja atualizar de acordo com a regra abaixo: \n" +
                "1. Nome\n" +
                "2. Descrição\n" +
                "3. Preço\n" +
                "4. quantidade\n" +
                "5. Data de validade\n" +
                "6. Situação");
                campo = Convert.ToInt16(Console.ReadLine());
                //avisar o ususario
                if((campo <1) || (campo >6))
                {

                    Console.WriteLine("Erro , escolha um codigo entre 1 e 6");
                }//fim do if
            } while ((campo < 1) || (campo > 6));


               Console.WriteLine(" Informe o dado para a atualização: ");
               string novoDado = Console.ReadLine();



               // Chamando o metodo de atualização
               prod.AtualizarProduto(codigo, campo, novoDado);
               Console.WriteLine("Atualizado !");
          }//fim do metodo atualizar
            
        public void AlterarSituacao()
        {
            Console.WriteLine("Informe o codigo do produto que deseja alterar");
            int codigo = Convert.ToInt32(Console.ReadLine());

            //chamar alteracao do sistema 

            prod.AlterarSituacao(codigo);
            Console.WriteLine("Alterar!");

        }//fim do alterar
       
}//fim da classe
}//fim do projeto
