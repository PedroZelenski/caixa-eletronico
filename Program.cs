using System;

namespace caixa_eletronico
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("INSIRA O VALOR DE SAQUE: ");
            int valor = Convert.ToInt32(Console.ReadLine());

            int qtde100 = 0;
            int qtde50 = 0;
            int qtde20 = 0;
            int qtde10 = 0;
            int qtde5 = 0;
            int qtde2 = 0;

            int saldo = valor;

            while (saldo > 0)
            {
                if ((saldo - 100) >= 0)
                {
                    saldo -= 100;
                    qtde100++;
                    //Console.WriteLine("Sacou R$100,00");
                }
                else
                {
                    if ((saldo - 50) >= 0)
                    {
                        saldo -= 50;
                        qtde50++;
                        //Console.WriteLine("Sacou R$50,00");
                    }
                    else
                    {
                        if ((saldo - 20) >= 0)
                        {
                            saldo -= 20;
                            qtde20++;
                            //Console.WriteLine("Sacou R$20,00");
                        }
                        else
                        {
                            if ((saldo - 10) >= 0)
                            {
                                saldo -= 10;
                                qtde10++;
                                //Console.WriteLine("Sacou R$10,00");
                            }
                            else
                            {
                                if ((saldo - 5) >= 0)
                                {
                                    saldo -= 5;
                                    qtde5++;
                                    //Console.WriteLine("Sacou R$5,00");
                                }
                                else
                                {
                                    if ((saldo - 2) >= 0)
                                    {
                                        saldo -= 2;
                                        qtde2++;
                                        //Console.WriteLine("Sacou R$2,00");
                                    }
                                }
                            }
                        }
                    }
                }
            }
            
            if (qtde100 > 0)
            {
                Console.WriteLine($"{qtde100} x R$100,00");
            }
            if (qtde50 > 0)
            {
                Console.WriteLine($"{qtde50} x R$50,00");
            }
            if (qtde50 > 0)
            {
                Console.WriteLine($"{qtde20} x R$20,00");
            }
            if (qtde50 > 0)
            {
                Console.WriteLine($"{qtde10} x R$10,00");
            }
            if (qtde50 > 0)
            {
                Console.WriteLine($"{qtde5} x R$5,00");
            }
            if (qtde50 > 0)
            {
                Console.WriteLine($"{qtde2} x R$2,00");
            }
        }
    }
}
