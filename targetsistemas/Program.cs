namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Q1();
            Q2();
            Q3();
            Q5();

        }

        private static void Q1()
        {
            Console.WriteLine("Questão 1");

            var indice = 13;
            var soma = 0;
            var contador = 0;

            while (contador < indice)
            {
                contador++;
                soma += contador;
            }

            Console.WriteLine($"Soma: {soma}\n");
        }

        private static void Q2()
        {
            Console.WriteLine("Questão 2");

            var numero = 610;
            var list = new List<int>();
            for(int i = 0, element = 0; element <= numero * 2; i++)
            {
                list.Add(element);
                element++;

                if(i > 0)
                {
                    element = list[i] + list[i - 1];
                }
            }

            foreach(var e in list)
            {
                Console.Write($"{e} ");

                if(e == list.LastOrDefault())
                {
                    Console.Write("...");
                }
            }

            if (list.Contains(numero))
            {
                Console.WriteLine($"\nO número {numero} pertence a sequência de Fibonacci");
            }
            else
            {
                Console.WriteLine($"\nO número {numero} não pertence a sequência de Fibonacci");
            }
        }

        private static void Q3()
        {
            Console.WriteLine("\nQuestão 3");
            Console.Write("a) ");
            for(int e = 1, i = 0; i < 5; i++)
            {
                Console.Write($"{e} ");
                e += 2;
            }

            Console.Write("\n\nb) ");
            for (int e = 2, i = 0; i <= 7; i++)
            {
                Console.Write($"{e} ");
                e *= 2;
            }

            Console.Write("\n\nc) ");
            Console.Write("0 ");
            for (int e = 1, i = 0, last = 0, value; i <= 6;i++)
            {
                value = e + last;
                Console.Write($"{value} ");
                e += 2;
                last = value;
            }

            Console.Write("\n\nd) ");
            for (int i = 0, value = 4, plus = 12; i < 5; i++)
            {
                Console.Write($"{value} ");
                value += plus;
                plus += 8;
            }

            Console.Write("\n\ne) ");
            var list = new List<int>();
            for (int i = 0, element = 0; i <= 7; i++)
            {
                list.Add(element);
                element++;

                if (i > 0)
                {
                    element = list[i] + list[i - 1];
                }
            }

            foreach (var e in list)
            {
                if(e != list.FirstOrDefault())
                {
                    Console.Write($"{e} ");
                }
            }
        }

        private static void Q5()
        {
            Console.WriteLine("\n\nQuestão 5");

            var frase = "Teste Target Sistemas";
            
            Console.WriteLine($"Frase: {frase}");
            Console.Write($"Inversa: ");


            for (var i = frase.Length - 1; i >= 0 ; i--)
            {
                Console.Write(frase[i]);
            }

            Console.WriteLine();
        }
    }
}