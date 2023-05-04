using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace MaquinaDeDoces
{
    class Produto
    {
        //Definição de variáveis
        private int codigo;
        private string nome;
        private string descricao;
        private double preco;
        private int quantidade;
        private DateTime dtValidade;
        private Boolean situacao;

        //Método construtor
        public Produto()
        {
            ModificarCodigo       = 0;
            ModificarNome         = "";
            ModificarDescricao    = "";
            ModificarPreco        = 0;
            ModificarQuantidade   = 0;
            ModificarDataValidade = new DateTime();//0000/00/00 00:00:00
            ModificarSituacao     = false;
        }//fim do método construtor

        public Produto(int codigo, string nome, string descricao,
            double preco, int quantidade, DateTime dtValidade, Boolean situacao)
        {
            ModificarCodigo       = codigo;
            ModificarNome         = nome;
            ModificarDescricao    = descricao;
            ModificarPreco        = preco;
            ModificarQuantidade   = quantidade;
            ModificarDataValidade = dtValidade;
            ModificarSituacao     = situacao;
        }//fim do método construtor com parâmetros

        //Métodos Get e Set
        //Métodos de acesso e modificação
        public int ModificarCodigo
        {
            get{
                return this.codigo;
            }//fim do get - retornar o código

            set{
                this.codigo = value;
            }//fim do set - modificar o código
        }//fim do ModificarCodigo

        public string ModificarNome
        {
            get { return this.nome; }
            set { this.nome = value; }
        }//fim do ModificarNome

        public string ModificarDescricao
        {
            get { return this.descricao; }
            set { this.descricao = value;}
        }//fim do ModificarDescricao

        public double ModificarPreco
        {
            get { return this.preco; }
            set { this.preco = value; }
        }//fim do ModificarPreco

        public int ModificarQuantidade
        {
            get { return this.quantidade;}
            set { this.quantidade = value;}
        }//fim do ModificarQuantidade

        public DateTime ModificarDataValidade
        {
            get { return this.dtValidade; }
            set { this.dtValidade = value; }
        }//fim do ModificarValidade

        public Boolean ModificarSituacao
        {
            get { return this.situacao; }
            set { this.situacao = value; }
        }//fim do ModificarSituacao

        //Método Cadastrar Produto
        public void CadastrarProduto(int codigo, string nome, string descricao,
        double preco, int quantidade, DateTime dtValidade, Boolean situacao)
        {
            ModificarCodigo       = codigo;
            ModificarNome         = nome;
            ModificarDescricao    = descricao;
            ModificarPreco        = preco; 
            ModificarQuantidade   = quantidade;
            ModificarDataValidade = dtValidade;  
            ModificarSituacao     = situacao;    
        }//fim do método CadastrarProduto

        //Consultar Produto
        public string ConsultarProduto(int codigo)
        {
            string msg = "";//Criando uma variável local

            if(ModificarCodigo == codigo)
            {
                msg = "\nCódigo: "           + ModificarCodigo       +
                      "\nNome: "             + ModificarNome         +
                      "\nDescrição: "        + ModificarDescricao    +
                      "\nPreço: "            + ModificarPreco        +
                      "\nQuantidade: "       + ModificarQuantidade   +
                      "\nData de Validade: " + ModificarDataValidade +
                      "\nSituação: "         + ModificarSituacao;
            }
            else
            {
                msg = "O código digitado não existe!";
            }

            return msg;
        }//fim do método

        //Método atualizar
        public Boolean AtualizarProduto(int codigo, int campo, string novoDado)
        {
            Boolean flag = false;//Variável local

            if(ModificarCodigo == codigo)
            {
                switch (campo)
                {
                    case 1:
                        ModificarNome = novoDado;
                        flag = true;
                        break;
                    case 2:
                        ModificarDescricao = novoDado;
                        flag = true;
                        break;
                    case 3:
                        ModificarPreco = Convert.ToDouble(novoDado);
                        flag = true;
                        break;
                    case 4:
                        ModificarQuantidade = Convert.ToInt32(novoDado);
                        flag = true;
                        break;
                    case 5:
                        ModificarDataValidade = Convert.ToDateTime(novoDado);
                        flag = true;
                        break;
                    case 6:
                        ModificarSituacao = Convert.ToBoolean(novoDado);
                        flag = true;
                        break;
                    default:
                        break;
                }//fim do escolha
                return flag;
            }//fim do if
            return flag;
        }//fim do atualizarProduto

        public Boolean AlterarSituacao(int codigo)
        {
            Boolean flag = false;

            if(ModificarCodigo == codigo)
            {
                if(ModificarSituacao == true)
                {
                    ModificarSituacao = false;
                }
                else
                {
                    ModificarSituacao = true;
                }//fim do modificarSituacao
                flag = true;
            }//fim do modificarCodigo
            return flag;
        }//fim do AlterarSituacao

        //SolicitarProdutos
        public Boolean SolicitarProduto(int codigo)
        {
            if (ModificarCodigo == codigo)
            {
                if (ModificarQuantidade <= 3)
                {
                    return true;
                }
            }//fim do if
            return false;
        }//fim do solicitarProduto

    }//fim da classe
}//fim do projeto
