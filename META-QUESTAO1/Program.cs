using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace META_QUESTAO1
{
    class Program
    {
        static void Main(string[] args)
        {
            #region META - QUESTAO 01
            /*Dado um array de números inteiros, 
             * retorne os índices dos dois números de forma que eles se somem a um alvo específico.
               Você pode assumir que cada entrada teria exatamente uma solução, 
               e você não pode usar o mesmo elemento duas vezes.
            Exemplo: Dado nums = [2, 7, 11, 15], alvo = 9, Como nums[0] + nums[1] = 2 + 7 = 9, return [0, 1].
            #endregion*/

            int num1, num2, num3, num4, alvo;

            Console.WriteLine("Digite os 4 numeros do array: ");
            string[] linha = Console.ReadLine().Split(' ');
            num1 = int.Parse(linha[0]);
            num2 = int.Parse(linha[1]);
            num3 = int.Parse(linha[2]);
            num4 = int.Parse(linha[3]);
            Console.Write("Digite o numero alvo: ");
            alvo = int.Parse(Console.ReadLine());
          
            var soma12 = num1 + num2;
            var soma13 = num1 + num3;
            var soma14 = num1 + num4;
            var soma23 = num2 + num3;
            var soma24 = num2 + num4;
            var soma34 = num3 + num4;

            if (soma12 == alvo)
            {
                Console.WriteLine("Resultado positivo, pois " + soma12 + " é igual a " + alvo);

            }
            else if (soma13 == alvo)
            {
                Console.WriteLine("Resultado positivo, pois " + soma13 + " é igual a " + alvo);
            }
            else if (soma14 == alvo)
            {
                Console.WriteLine("Resultado positivo, pois " + soma14 + " é igual a " + alvo);
            }
            else if (soma23 == alvo)
            {
                Console.WriteLine("Resultado positivo, pois " + soma23 + " é igual a " + alvo);
            }
            else if (soma24 == alvo)
            {
                Console.WriteLine("Resultado positivo, pois " + soma24 + " é igual a " + alvo);
            }
            else if (soma34 == alvo)
            {
                Console.WriteLine("Resultado positivo, pois " + soma34 + " é igual a " + alvo);
            }

            else
            {
                Console.WriteLine("Resultado negativo, a soma dos elementos do array nao encontrou nenhum numero igual a " + alvo);
            }

            #endregion
        }
    }
}
