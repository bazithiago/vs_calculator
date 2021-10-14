using System;

namespace calculadora_dotnet
{
    class Program
    {
        static void Main(string[] args)
        {
            int option;
            double n1;
            double n2;
            double result;
            bool validate = true;
            Program program = new Program();

            Console.WriteLine("Sejam bem vindos a calculadora DOTNET");

            do
            {
                Console.WriteLine("\nQual operação desejada?");
                Console.WriteLine("(1) Soma");
                Console.WriteLine("(2) Subtração");
                Console.WriteLine("(3) Multiplicação");
                Console.WriteLine("(4) Divisão");
                Console.WriteLine("(5) Sair");


                Console.WriteLine("\nDigite sua opção: ");
                option = Convert.ToInt32(Console.ReadLine());


                switch (option)
                {
                    case 1:
                        Console.WriteLine("Digite o primeiro número: ");
                        n1 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Digite o segundo número: ");
                        n2 = Convert.ToDouble(Console.ReadLine());

                        result = program.Sum(n1, n2);
                        Console.WriteLine("Seu resultado é = {0}", result);

                        break;

                    case 2:
                        Console.WriteLine("Digite o primeiro número: ");
                        n1 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Digite o segundo número: ");
                        n2 = Convert.ToDouble(Console.ReadLine());

                        result = program.Sub(n1, n2);
                        Console.WriteLine("Seu resultado é = {0}", result);

                        break;

                    case 3:
                        Console.WriteLine("Digite o primeiro número: ");
                        n1 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Digite o segundo número: ");
                        n2 = Convert.ToDouble(Console.ReadLine());

                        result = program.Mult(n1, n2);
                        Console.WriteLine("Seu resultado é = {0}", result);

                        break;

                    case 4:
                        Console.WriteLine("Digite o primeiro número: ");
                        n1 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Digite o segundo número: ");
                        n2 = Convert.ToDouble(Console.ReadLine());

                        result = program.Div(n1, n2);
                        Console.WriteLine("Seu resultado é = {0}", result);

                        break;

                    case 5:
                        validate = false;
                        break;

                    default:
                        Console.WriteLine("Opção inválida");

                        break;
                }


                Console.WriteLine("\nAperte ENTER para continuar");
                Console.ReadLine();
                Console.Clear();


            } while (validate);       

        }


        public double Sum(double n1, double n2)
        {
            return n1 + n2;
        }

        public double Sub(double n1, double n2)
        {
            return n1 - n2;
        }

        public double Mult(double n1, double n2)
        {
            return n1 * n2;
        }

        public double Div(double n1, double n2)
        {
            return n1 / n2;
        }
    }
}
