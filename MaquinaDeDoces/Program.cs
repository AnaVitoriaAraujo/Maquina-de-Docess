using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaquinaDeDoces
{
    class Program// nao vou usar a internal
    {
        static void Main(string[] args)
        {
            //se conecta com a classe control produto
            ControlPagamento controlProd= new ControlPagamento();

            //chamar o metodo principal daquela classe
            controlProd.Operacao();
          
            Console.ReadLine();  //Manter a janela aberta tipo o leia o read line que manter aberto
            //read line mantem o console aberto
        }// fim do metodo
    }// fim da classe
}//fim do projeto
