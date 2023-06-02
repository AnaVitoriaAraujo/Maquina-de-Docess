using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaquinaDeDoces
{
    class Pagamento
    {
        private int codigo;
        private double valorTotal;
        private short formaDePagamento;
        private DateTime dataHora;
        private int codCartao;
        private short bandeiraCartao;
        private double trocoMaquina;
        private double troco;

        //Criação do construtor
        public Pagamento()
        {
            ModificarCodigo = 0;
            ModificarValorTotal = 0;
            ModificarFormaPagamento = 0;
            ModificarDataHora = new DateTime();
            ModificarCodigoCartao = 0;
            ModificarBandeiraCartao = 0;
            ModificarTrocoMaquina = 100;
            ModificarTroco = 0;
        }//fim do construtor

        //Métodos Gets e Sets

        public double ModificarTroco
        {
            get { return troco; }
            set { this.troco = value; }
        }//fim do método Troco        

        public int ModificarCodigo
        {
            get { return this.codigo; }
            set { this.codigo = value; }
        }//fim do ModificarCodigo

        public double ModificarValorTotal
        {
            get { return this.valorTotal; }
            set { this.valorTotal = value; }
        }//fim do ModificarCodigo

        public short ModificarFormaPagamento
        {
            get { return this.formaDePagamento; }
            set { this.formaDePagamento = value; }
        }//fim do ModificarCodigo

        public DateTime ModificarDataHora
        {
            get { return this.dataHora; }
            set { this.dataHora = value; }
        }//fim do ModificarCodigo

        public int ModificarCodigoCartao
        {
            get { return this.codCartao; }
            set { this.codCartao = value; }
        }//fim do ModificarCodigo

        public short ModificarBandeiraCartao
        {
            get { return this.bandeiraCartao; }
            set { this.bandeiraCartao = value; }
        }//fim do ModificarCodigo

        public double ModificarTrocoMaquina
        {
            get { return this.trocoMaquina; }
            set { this.trocoMaquina = value; }
        }//fim do método modificarTrocoMaquina

        //Método do modelo de negócio
        public string VerificarNotas(double entradaDinheiro, double valorProduto)
        {
            if (entradaDinheiro >= valorProduto)
            {
                return "OK";
            }
            else
            {
                return "NOK";
            }
        }//fim do verificarNotas 

        public Boolean ExisteTroco(double entradaDinheiro, double valorProduto)
        {
            if (entradaDinheiro > valorProduto)
            {
                return true;
            }
            return false;
        }//fim do existeTroco

        public void VerificarTroco(double entradaDinheiro, double valorProduto)
        {
            Boolean respTroco = false;
            respTroco = ExisteTroco(entradaDinheiro, valorProduto);
            if (respTroco == true)
            {
                ModificarTroco = entradaDinheiro - valorProduto;
            }
            else
            {
                ModificarTroco = 0;
            }
        }//fim do verificarTroco

        public string MenuFormaDePagamento()
        {
            return "Escolha uma das opções abaixo: " + "\n1. Dinheiro \n2. Cartão";
        }//fim do método

        public void ColetarFormaDePagamento(short opcao)
        {
            ModificarFormaPagamento = opcao;
        }//fim do coletar

        public void EfetuarPagamentoDinheiro(double entradaPagamento, double valorProduto)
        {
            string resp = "";
            resp = VerificarNotas(entradaPagamento, valorProduto);

            if (resp == "OK")
            {
                ModificarCodigo++;
                ModificarValorTotal = valorProduto;
                ModificarFormaPagamento = 1;
                ModificarDataHora = DateTime.Now;//Pegar a data e hora da transação
                ModificarTrocoMaquina += valorProduto;
                VerificarTroco(entradaPagamento, valorProduto);
                imprimir();
            }
        }//fim do método Efetuar Pagamento

        public void EfetuarPagamentoCartao(double entradaPagamento, double valorProduto, int codCartao, short bandeiraCartao)
        {
            ModificarCodigo++;
            ModificarValorTotal = valorProduto;
            ModificarFormaPagamento = 2;
            ModificarDataHora = DateTime.Now;//Pegar a data e hora da transação
            ModificarBandeiraCartao = bandeiraCartao;
            ModificarCodigoCartao = codCartao;
            imprimir();
        }//fim do efetuarPagamento Cartão

        //Método Imprimir
        public string imprimir()
        {
            return "Código: " + ModificarCodigo +
                   "\nValor Total: R$ " + ModificarValorTotal +
                   "\nTroco: R$ " + ModificarTroco +
                   "\nForma de Pagamento: " + ModificarFormaPagamento +
                   "\nData e Hora: " + ModificarDataHora;
        }//fim do método Imprimir
    }//Fim da Classe
}//fimDoProjeto