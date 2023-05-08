using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaquinaDeDoces
{
    class Program// nao vou usat a internal
    {
        static void Main(string[] args)
        {
            //se conecta com a classe control produto
            ControlProduto controlProd= new ControlProduto();

            //chmaar o metodo principal daquela classe
            controlProd.Operacao();


            //write line o console é pra imprimir o return e ler um mensagem
            Console.ReadLine();//Manter a janela aberta tipo o leia o read line que manter aberto
            //read line mantem o console aberto
        }// fim do metodo
    }// fim da classe
}//fim do projeto
