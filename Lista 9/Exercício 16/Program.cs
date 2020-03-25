using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_16
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe sua data de nascimento");
            string data = Console.ReadLine();
            int idadeMeses, idadeAnos;

            Idade(data, out idadeAnos, out idadeMeses);

            Console.WriteLine($"Você tem {idadeAnos} anos e {idadeMeses} meses");
            Console.ReadKey();
        }

        public static void Idade(string nascimento, out int anos, out int meses)
        {
            string[] valores = nascimento.Split('/');
            int diaNascimento = int.Parse(valores[0]), mesNascimento = int.Parse(valores[1]), anoNascimento = int.Parse(valores[2]);

            anos = 0;
            meses = 0;

            if (anoNascimento == 2020 && mesNascimento < 03)
            {
                meses = 03 - mesNascimento;
            }

            else if (anoNascimento < 2020 && mesNascimento == 03)
            {
                anos = 2020 - anoNascimento;
            }

            else if (anoNascimento < 2020 && mesNascimento < 03)
            {
                anos = 2020 - anoNascimento;
                meses = 03 - mesNascimento;
            }

            else if (anoNascimento < 2020 && mesNascimento > 03)
            {
                anos = (2020 - anoNascimento) - 1;
                meses = (12 - mesNascimento) + 03;
            }
        }
    }
}
