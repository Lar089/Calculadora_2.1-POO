using System;
using System.Collections.Generic;

namespace Calculadora_POO
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Calculadora> lista_calculadora = new List<Calculadora>();
            String op = null, str_continuar = null;
            double x = -33333, y = -33333, resultado, continuar = -33333;
            Console.WriteLine("Calculadora 2.1");
            do
            {
                op = Menu();
                if (op.Equals("4"))
                {
                    Console.Clear();
                    Console.WriteLine("\nSegundo valor não pode ser zero!");
                    do
                    {
                        if (continuar == -33333) {
                            MenuValores(ref x, ref y);
                        }
                        else
                        {
                            Console.WriteLine("Digite o segundo valor: ");
                            y = Convert.ToDouble(Console.ReadLine());
                            x = continuar;
                            if (y != -33333 && y != 0)
                            {
                                continuar = -33333;
                            }
                        }
                    } while (y == 0);
                }
                else if (op.Equals("1") || op.Equals("2") || op.Equals("3"))
                {
                    do
                    {
                        if (continuar == -33333)
                        {
                            MenuValores(ref x, ref y);
                        }
                        else
                        {
                            Console.WriteLine("Digite o segundo valor: ");
                            y = Convert.ToDouble(Console.ReadLine());
                            x = continuar;
                            if (y != -33333) {
                                continuar = -33333;
                            } else
                            {
                                Console.WriteLine("\nERRO: Os valores são inválidos.\n");
                            }
                        }
                    } while (x == -33333 && y == -33333);
                }

                switch (op)
                {
                    case "1":
                        Console.Clear();
                        resultado = Calcular.Adicao(x, y);
                        if (str_continuar != null) {
                            Console.WriteLine($"{str_continuar}" + " + " + $"{y}" + " = " + $"{resultado}");
                        }
                        else
                        {
                            Console.WriteLine($"{x}" + " + " + $"{y}" + " = " + $"{resultado}");
                        }
                        lista_calculadora.Add(new Calculadora(x, y, resultado, "+"));
                        if (MenuContinuar())
                        {
                            Console.WriteLine($"{resultado}");
                            continuar = resultado;
                            if (str_continuar == null) {
                                str_continuar = $"{x}" + " + " + $"{y}" + " = " + $"{resultado}";
                            }
                            else
                            {
                                str_continuar = str_continuar + " + " + $"{y}" + " = " + $"{resultado}";
                            }
                        }
                        else
                        {
                            continuar = -33333;
                            str_continuar = null;
                        }
                        break;
                    case "2":
                        Console.Clear();
                        resultado = Calcular.Subtracao(x, y);
                        if (str_continuar != null)
                        {
                            Console.WriteLine($"{str_continuar}" + " - " + $"{y}" + " = " + $"{resultado}");
                        }
                        else
                        {
                            Console.WriteLine($"{x}" + " - " + $"{y}" + " = " + $"{resultado}");
                        }
                        lista_calculadora.Add(new Calculadora(x, y, resultado, "-"));
                        if (MenuContinuar())
                        {
                            Console.WriteLine($"{resultado}");
                            continuar = resultado;
                            if (str_continuar == null)
                            {
                                str_continuar = $"{x}" + " - " + $"{y}" + " = " + $"{resultado}";
                            }
                            else
                            {
                                str_continuar = str_continuar + " - " + $"{y}" + " = " + $"{resultado}";
                            }
                        }
                        else
                        {
                            continuar = -33333;
                            str_continuar = null;
                        }
                        break;
                    case "3":
                        Console.Clear();
                        resultado = Calcular.Multiplicacao(x, y);
                        if (str_continuar != null)
                        {
                            Console.WriteLine($"{str_continuar}" + " * " + $"{y}" + " = " + $"{resultado}");
                        }
                        else
                        {
                            Console.WriteLine($"{x}" + " * " + $"{y}" + " = " + $"{resultado}");
                        }
                        lista_calculadora.Add(new Calculadora(x, y, resultado, "*"));
                        if (MenuContinuar())
                        {
                            Console.WriteLine($"{resultado}");
                            continuar = resultado;
                            if (str_continuar == null)
                            {
                                str_continuar = $"{x}" + " * " + $"{y}" + " = " + $"{resultado}";
                            }
                            else
                            {
                                str_continuar = str_continuar + " * " + $"{y}" + " = " + $"{resultado}";
                            }
                        }
                        else
                        {
                            continuar = -33333;
                            str_continuar = null;
                        }
                        break;
                    case "4":
                        Console.Clear();
                        resultado = Calcular.Divisao(x, y);
                        if (str_continuar != null)
                        {
                            Console.WriteLine($"{str_continuar}" + " / " + $"{y}" + " = " + $"{resultado}");
                        }
                        else
                        {
                            Console.WriteLine($"{x}" + " / " + $"{y}" + " = " + $"{resultado}");
                        }
                        lista_calculadora.Add(new Calculadora(x, y, resultado, "/"));
                        if (MenuContinuar())
                        {
                            Console.WriteLine($"{resultado}");
                            continuar = resultado;
                            if (str_continuar == null)
                            {
                                str_continuar = $"{x}" + " / " + $"{y}" + " = " + $"{resultado}";
                            }
                            else
                            {
                                str_continuar = str_continuar + " / " + $"{y}" + " = " + $"{resultado}";
                            }
                        }
                        else
                        {
                            continuar = -33333;
                            str_continuar = null;
                        }
                        break;
                    case "5":
                        Console.Clear();
                        if (lista_calculadora.Count != 0)
                        {
                            Console.WriteLine("\nRESULTADOS");
                            foreach (Calculadora calc in lista_calculadora)
                            {
                                Console.WriteLine($"{calc.X}" + $" {calc.Operacao} " + $"{calc.Y}" + " = " + $"{calc.Resultado}");
                            }
                        } else
                        {
                            Console.WriteLine("\nERRO: Não possui resultados!\n");
                        }
                            break;
                    case "S":
                        Console.WriteLine("\nFinalizando o sistema....");
                        break;
                    default:
                        Console.WriteLine("\nERRO: Digite uma opção válida.\n");
                        break;
                }
            } while (op != "S");
        }

        public static string Menu()
        {
            Console.WriteLine("Digite 1 para somar");
            Console.WriteLine("Digite 2 para subtrair");
            Console.WriteLine("Digite 3 para multiplicação");
            Console.WriteLine("Digite 4 para divisão");
            Console.WriteLine("Digite 5 para visualizar as operações realizadas");
            Console.WriteLine("Digite S para sair");

            string op = Console.ReadLine().ToUpper();
            return op;
        }

        public static void MenuValores(ref double x, ref double y)
        {
            try
            {
                Console.WriteLine("Digite o primeiro valor: ");
                x = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Digite o segundo valor: ");
                y = Convert.ToDouble(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("ERRO: Os valores são inválidos.");
            }
        }

        public static bool MenuContinuar()
        {
            String resultado;
            do
            {
                Console.WriteLine("Deseja continuar a calcular o valor atual: S/N");
                resultado = Console.ReadLine().ToUpper();
                if (resultado.Equals("S"))
                {
                    return true;
                }
                else if (!resultado.Equals("N"))
                {
                    Console.WriteLine("ERRO: Digite uma opção válida.");
                }
            } while (!resultado.Equals("N"));
            Console.Clear();
            return false;
        }
    }
}
