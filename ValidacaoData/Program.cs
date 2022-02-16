using System;

namespace ValidacaoData
{
    class Program
    {
        static void Main(string[] args)
        {
            int dia;
            int mes;
            int ano;

            Console.WriteLine("Verificação de Data");

            Console.Write("Insira a data: ");
            dia = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");
            Console.Write("Insira a mês: ");
            mes = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");
            Console.Write("Insira a ano: ");
            ano = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");

            if (Convert.ToString(ano).Length != 4)
            {
                Console.WriteLine("Ops! Ano inserido errado - " + ano);
            }
            else if (Convert.ToString(ano).Length == 4)
            {
                if (mes > 12)
                {
                    Console.WriteLine("Ops! O mês informado não existe - " + mes);
                }
                else if (mes <= 12)
                {
                    if (dia <= 31)
                    {
                        Console.WriteLine("Data inserida foi - " + dia +"/"+ mes + "/" + ano);
                    }
                    else
                    {
                        Console.WriteLine("Ops! O dia informado não existe - " + dia);
                    }
                }
            }

        }
    }
}
