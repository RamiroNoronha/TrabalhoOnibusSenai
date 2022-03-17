using System;
using EmpresaOnibus;
using UsuarioOnibus;


namespace TrabalhoOnibus
{
    public static class Program
    {
        static void Main(string[] args)
        {
            Onibus onibus = null;
            int opcao;
            Menu.MenuFuncionario();
            opcao = int.Parse(Console.ReadLine());
            switch (opcao)
            {
                case 1:
                    Menu.MenuAtendente();
                    int opcaoAtendente = int.Parse(Console.ReadLine());
                    if(opcaoAtendente == 1)
                    {
                        Console.Write("Digite o nome do motorista: ");
                        string motorista = Console.ReadLine();
                        Console.Write("Digite o valor da taxa do ônibus");
                        float taxa = float.Parse(Console.ReadLine());
                        onibus = new Onibus(motorista, taxa);
                    }
                    else if(opcaoAtendente == 2)
                    {
                        Menu.MenuCadastroPassageiro();
                        int opcaoPassageiro = int.Parse(Console.ReadLine());
                        Console.Write("Digite o nome do passageiro: ");
                        string nomePassageiro = Console.ReadLine();
                        do
                        {

                            if (opcaoPassageiro == 1)
                            {
                                Passageiro passageiro = new Passageiro(nomePassageiro);
                            }
                            else if (opcaoPassageiro == 2)
                            {
                                Console.Write("Digite o RA: ");
                                string ra = Console.ReadLine();
                                Estudante estudante = new Estudante(nomePassageiro, ra);
                            }
                            else if (opcaoPassageiro == 3)
                            {
                                Console.Write("Digite o RG: ");
                                string rg = Console.ReadLine();
                                Aposentado aposentado = new Aposentado(nomePassageiro, rg);
                            }
                            else
                            {
                                Console.WriteLine("Opcao inválida");
                                Menu.MenuCadastroPassageiro();
                                opcaoPassageiro = int.Parse(Console.ReadLine());
                                Console.Write("Digite o nome do passageiro: ");
                                nomePassageiro = Console.ReadLine();
                            }
                        } while (opcaoPassageiro > 3 && opcaoPassageiro < 1);
                        }
                    break;
                case 2:
                    break;
            }
        }
    }
}