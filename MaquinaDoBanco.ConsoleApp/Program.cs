using System;

namespace MaquinaDoBanco.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] linha1 = new string[40];
            string[] linha2 = new string[40];
            string[] linha3 = new string[40];

            string[] n1 = new string[4];
            n1[0] = "1";
            n1[1] = "    ";
            n1[2] = "   |";
            n1[3] = "   |";

            string[] n2 = new string[4];
            n2[0] = "2";
            n2[1] = " __ ";
            n2[2] = " __|";
            n2[3] = "|__ ";

            string[] n3 = new string[4];
            n3[0] = "3";
            n3[1] = " __ ";
            n3[2] = " __|";
            n3[3] = " __|";

            string[] n4 = new string[4];
            n4[0] = "4";
            n4[1] = "    ";
            n4[2] = "|__|";
            n4[3] = "   |";

            string[] n5 = new string[4];
            n5[0] = "5";
            n5[1] = " __ ";
            n5[2] = "|__ ";
            n5[3] = " __|";
            
            string[] n6 = new string[4];
            n6[0] = "6";
            n6[1] = " __ ";
            n6[2] = "|__ ";
            n6[3] = "|__|";
            
            string[] n7 = new string[4];
            n7[0] = "7";
            n7[1] = " __ ";
            n7[2] = "   |";
            n7[3] = "   |";

            string[] n8 = new string[4];
            n8[0] = "8";
            n8[1] = " __ ";
            n8[2] = "|__|";
            n8[3] = "|__|";

            string[] n9 = new string[4];
            n9[0] = "9";
            n9[1] = " __ ";
            n9[2] = "|__|";
            n9[3] = " __|";

            string[] n0 = new string[4];
            n0[0] = "0";
            n0[1] = " __ ";
            n0[2] = "|  |";
            n0[3] = "|__|";
            
            char opcao = ' ';

            do
            {
                Console.WriteLine("Tecle uma opção: \n\n'1'- Gerar Número: \n'2'- Sair");
                opcao = Console.ReadKey().KeyChar;
                Console.WriteLine("\n");

                if (opcao == '1')
                {

                    Random aleatorio = new Random();

                    int entrada = aleatorio.Next(100000000, 999999999);
                    string entr = entrada.ToString();
                    char[] numeroEntrada = entr.ToCharArray();

                    for (int i = 0; i < entr.Length; i++)
                    {
                        switch (numeroEntrada[i])
                        {
                            case '0':
                                linha1[i] = n0[1];
                                linha2[i] = n0[2];
                                linha3[i] = n0[3];
                                break;
                            case '1':
                                linha1[i] = n1[1];
                                linha2[i] = n1[2];
                                linha3[i] = n1[3];
                                break;
                            case '2':
                                linha1[i] = n2[1];
                                linha2[i] = n2[2];
                                linha3[i] = n2[3];
                                break;
                            case '3':
                                linha1[i] = n3[1];
                                linha2[i] = n3[2];
                                linha3[i] = n3[3];
                                break;
                            case '4':
                                linha1[i] = n4[1];
                                linha2[i] = n4[2];
                                linha3[i] = n4[3];
                                break;
                            case '5':
                                linha1[i] = n5[1];
                                linha2[i] = n5[2];
                                linha3[i] = n5[3];
                                break;
                            case '6':
                                linha1[i] = n6[1];
                                linha2[i] = n6[2];
                                linha3[i] = n6[3];
                                break;
                            case '7':
                                linha1[i] = n7[1];
                                linha2[i] = n7[2];
                                linha3[i] = n7[3];
                                break;
                            case '8':
                                linha1[i] = n8[1];
                                linha2[i] = n8[2];
                                linha3[i] = n8[3];
                                break;
                            case '9':
                                linha1[i] = n9[1];
                                linha2[i] = n9[2];
                                linha3[i] = n9[3];
                                break;
                        }
                    }
                    foreach (string v in linha1)
                    {
                        Console.Write(v + " ");
                    }
                    Console.WriteLine();

                    foreach (string v in linha2)
                    {
                        Console.Write(v + " ");
                    }
                    Console.WriteLine();

                    foreach (string v in linha3)
                    {
                        Console.Write(v + " ");
                    }
                    Console.WriteLine("\n");

                    Console.WriteLine("número da conta: " + entrada + "\n");

                }
                else if (opcao == '2')
                {
                    Console.Clear();
                    Console.WriteLine("Encerrado!");
                    break;
                }
                else if (opcao != '1' && opcao != '2')
                {
                    Console.WriteLine("\nOpção Inválida!\n\n");
                    Console.WriteLine("Tecle uma opção: \n'1'- Gerar Número: \n'2'- Sair");
                    opcao = Console.ReadKey().KeyChar;
                    Console.WriteLine("\n");
                }

            } while (opcao != '2');

            Console.ReadKey();
        }
    }
}
