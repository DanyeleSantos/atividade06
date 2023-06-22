using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace primeirocursofim_
{
    class Program
    {
        static void Main(string[] args)

        {
            string periodo;
          int dia;
          int mes;
             
            Console.WriteLine("Bem-vindo ao decolando!");
            Console.WriteLine("escolha um mês para sua viagem ");
            Console.WriteLine($"\n AGOSTO 8\n SETEMBRO 9\n OUTUBRO 10\n ");
          mes =  int.Parse(Console.ReadLine());

            if (mes > 7 && mes < 11)
            {
                Console.WriteLine("MÊS VÁLIDO!");
            }
            else
            { 
                Console.WriteLine("MêS INVÁLIDO!");   
            }

           Console.WriteLine("\nEscolha um dia para sua viagem entre os dias 6 ao dia 21\n");
           dia = int.Parse(Console.ReadLine());

            if (dia > 5 && dia < 21)
            {
                Console.WriteLine("DATA MARCADA!");
            }
            else
            {
                Console.WriteLine("DIA INVÁLIDO!");
            }
            Console.WriteLine("\nEscolha o período para sua viagem:\n MANHÃ \n TARDE \n NOITE\n");
            periodo = Console.ReadLine();

            Console.WriteLine("\n PARABÉNS!!! \n SUA PASSAGEM FOI COMPRADA COM SUCESSO!\n\n ");
            Console.WriteLine($"\nVIAGEM MARCADA PARA O DIA {dia} MÊS DE {mes} PERÍODO  {periodo}! ");
            


           

             Console.ReadKey();









        }
    }
}
