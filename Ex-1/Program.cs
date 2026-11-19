Fila filaNormal = new Fila();
Fila filaPrioritaria = new Fila();
int operacao = 0;
int numeroSenha = 0;

string GerarNumeroSenha()
{
    numeroSenha += 1;

    return numeroSenha.ToString();
}
int Menu()
{
    Console.Clear();
   
    Console.WriteLine("Informe o que deseja executar:" +
        "\n1-Gerar senha Normal" +
        "\n2-Gerar senha Prioritária" +
        "\n3-Chamar proxima senha");

    return operacao = int.Parse(Console.ReadLine());
}
void Operacoes()
{
    int contadorPrioritario = 0;

    while (true)
    {
        Senha senha = new Senha(GerarNumeroSenha());
        switch (Menu())
        {
            case 1:
                filaNormal.InserirElemento(senha);
                Console.WriteLine($"A sua senha é N{senha.NumeroSenha}");
                Console.ReadKey();
                break;

            case 2:
                filaPrioritaria.InserirElemento(senha);
                Console.WriteLine($"A sua senha é P{senha.NumeroSenha}");
                Console.ReadKey();
                break;
            case 3:
                if (!filaPrioritaria.FilaVazia() && (contadorPrioritario < 2 || filaNormal.FilaVazia()))
                {
                    Console.WriteLine($"Senha P{filaPrioritaria.MostrarSenha()}");
                    filaPrioritaria.RemoverElemento();
                    contadorPrioritario++;
                }
                else if(!filaNormal.FilaVazia()) 
                {
                    Console.WriteLine($"Senha N{filaNormal.MostrarSenha()}");
                    filaNormal.RemoverElemento();
                    contadorPrioritario = 0;
                }
                else 
                {
                    Console.WriteLine("Nenhuma Senha para ser chamada!");
                }
                Console.ReadKey();
                break;

            default:
                Console.WriteLine("Opção inválida!");
                Console.ReadKey();
                break;

        }

    }
}

Operacoes();
