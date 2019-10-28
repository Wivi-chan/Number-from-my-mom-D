using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Мамено_задание
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите диапазон :");
            var D = int.Parse(Console.ReadLine());
            int[] Mass = new int[D];
            Random ran = new Random();
            List<string> MassSum = new List<string>();
            Console.WriteLine("С какого числа регенирировать рандом :");
            int N = int.Parse(Console.ReadLine());
            Console.WriteLine("Каким числом ограничеть рандом :");
            int K = int.Parse(Console.ReadLine());
            Console.WriteLine("Рандомно сгенерированная последовательность в заданном диапазоне :");
            for (int i = 0; i < D; i++)
            {
                Mass[i] = ran.Next(N, K);
                Console.Write(Mass[i] + " ");

            }
            Console.ReadKey();
            Console.Clear();
            //Console.WriteLine("Числа сумма которых равна 60 :");
            Console.WriteLine("Какое слагаемые какого числа вы хотите найти :");
            int Number= int.Parse(Console.ReadLine());
            for (int i = 0; i < Mass.Length; i++)
            {
                for (int j = i + 1; j < Mass.Length; j++)
                {
                    if (Mass[i] + Mass[j] == Number)
                    {
                        string summ = Convert.ToString($"{Mass[i]}+{Mass[j]}");
                        MassSum.Add(summ);

                    }
                }
            }
            Console.WriteLine("Слагаемые из диапазона для числа :"); //подумать как сделать красиво
            List<string> NewMassSumm = new List<string>(MassSum.Distinct());
            foreach (string El in NewMassSumm)
            {
                Console.Write("{0};", El);
            }

            string AllMassSumm = @"C:\Users\Арина\Desktop\Арина снова прогает\Мамено задание\Мамено задание\CуммаДляЧисла.txt";
            // FileStream FileForAllMassSumm = File.Open(AllMassSumm, FileMode.OpenOrCreate);
            File.WriteAllText(AllMassSumm, NewMassSumm[NewMassSumm.Count-1]); //довести до ума 

            Console.ReadKey();
        }
    }
}
