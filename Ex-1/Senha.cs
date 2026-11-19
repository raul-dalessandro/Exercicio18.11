public class Senha
{
    public string NumeroSenha { get; set; }
    public Senha? Proximo;

    public Senha(string numeroSenha)
    {
        NumeroSenha = numeroSenha;
        Proximo = null;
    }
}