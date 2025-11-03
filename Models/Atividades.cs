using System;

namespace psc_lista_08_2025.Models
{
    public static class Atividades
    {
        public static void Atividade1()
        {
            Console.Write("Informe n (inteiro positivo): ");
            if (!int.TryParse(Console.ReadLine(), out int n) || n <= 0)
            {
                Console.WriteLine("Entrada inválida. Deve ser um inteiro positivo.");
                return;
            }

            for (int i = 1; i <= n; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write(i + (j < i - 1 ? " " : ""));
                }
                Console.WriteLine();
            }
        }

        public static void Atividade2()
        {
            Console.Write("Informe n (inteiro positivo): ");
            if (!int.TryParse(Console.ReadLine(), out int n) || n <= 0)
            {
                Console.WriteLine("Entrada inválida. Deve ser um inteiro positivo.");
                return;
            }

            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j + (j < i ? " " : ""));
                }
                Console.WriteLine();
            }
        }

        public static void Atividade3()
        {
            Console.WriteLine("Informe três números (podem ser com ponto):");
            if (!TryReadDouble("1º número: ", out double a)) return;
            if (!TryReadDouble("2º número: ", out double b)) return;
            if (!TryReadDouble("3º número: ", out double c)) return;

            double soma = SumThreeNumbers(a, b, c);
            Console.WriteLine($"Soma: {soma}");
        }

        public static double SumThreeNumbers(double x, double y, double z)
            => x + y + z;

        public static void Atividade4()
        {
            if (!TryReadDouble("Informe um número: ", out double x)) return;
            char resultado = SignChar(x);
            Console.WriteLine($"Resultado: '{resultado}'");
        }

        public static char SignChar(double x)
            => x > 0 ? 'P' : 'N';

        public static void Atividade5()
        {
            Console.Write("Informe o custo do item (ex: 100.50): ");
            if (!decimal.TryParse(Console.ReadLine(), out decimal custo))
            {
                Console.WriteLine("Entrada inválida para custo.");
                return;
            }
            Console.Write("Informe a taxa de imposto (porcentagem, ex: 7.5): ");
            if (!decimal.TryParse(Console.ReadLine(), out decimal taxa))
            {
                Console.WriteLine("Entrada inválida para taxa.");
                return;
            }

            decimal novo = SomaImposto(taxa, ref custo);
            Console.WriteLine($"Custo com imposto: {novo:C}");
        }

        public static decimal SomaImposto(decimal taxaImpostoPercentual, ref decimal custo)
        {
            if (taxaImpostoPercentual < 0) taxaImpostoPercentual = 0;
            custo = custo + (custo * taxaImpostoPercentual / 100m);
            return custo;
        }

        public static void Atividade6()
        {
            while (true)
            {
                Console.Write("Informe a hora (0-23): ");
                if (!int.TryParse(Console.ReadLine(), out int h) || h < 0 || h > 23)
                {
                    Console.WriteLine("Hora inválida. Deve ser entre 0 e 23.");
                    return;
                }
                Console.Write("Informe os minutos (0-59): ");
                if (!int.TryParse(Console.ReadLine(), out int m) || m < 0 || m > 59)
                {
                    Console.WriteLine("Minuto inválido. Deve ser entre 0 e 59.");
                    return;
                }

                Convert24To12(h, m, out int hour12, out char ampm);
                string ampmStr = ampm == 'A' ? "A.M." : "P.M.";
                Console.WriteLine($"Resultado: {hour12}:{m:D2} {ampmStr}");

                Console.Write("Deseja converter outro horário? (S/N): ");
                string? resp = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(resp)) break;
                char c = char.ToUpper(resp.Trim()[0]);
                if (c != 'S') break;
            }
        }

        public static void Convert24To12(int hour24, int minute, out int hour12, out char ampm)
        {
            if (hour24 == 0)
            {
                hour12 = 12; // 00:xx -> 12:xx AM
                ampm = 'A';
            }
            else if (hour24 < 12)
            {
                hour12 = hour24;
                ampm = 'A';
            }
            else if (hour24 == 12)
            {
                hour12 = 12;
                ampm = 'P';
            }
            else
            {
                hour12 = hour24 - 12;
                ampm = 'P';
            }
        }

 
        private static bool TryReadDouble(string prompt, out double value)
        {
            Console.Write(prompt);
            value = 0;
            string? s = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(s)) return false;
            return double.TryParse(s.Trim(), System.Globalization.CultureInfo.InvariantCulture, out value);
        }
    }
}