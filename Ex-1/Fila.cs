public class Fila
{
    public Senha Head;
    public Senha Tail;
    public int Contador;

    public Fila()
    {
        Head = Tail = null;
        Contador = 0;
    }

    public bool FilaVazia()
    {
        if (Head == null)
            return true;
        return false;
    }

    public void InserirElemento(Senha aux)
    {
        if (FilaVazia())
        {
            Head = aux;
            Tail = aux;
        }
        else
        {
            Tail.Proximo = aux;
            Tail = aux;
        }
        Contador++;
    }

    public int GetContador()
    {
        return Contador;
    }

    public void RemoverElemento()
    {
        if (!FilaVazia())
        {
            Head = Head.Proximo;
            Contador--;
        }
    }

    public string MostrarSenha()
    {
        return Head.NumeroSenha;
    }
}