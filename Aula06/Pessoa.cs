public class Pessoa{
    private string nome = string.Empty; //private string? nome; --mesma coisa

    private int nota;

    public Pessoa(string nome, int nota){
        Nome = nome;
        Nota = nota;
    }

    public string Nome{
        get { return nome;}
        set { nome = value; }
    }

    public int Nota{
        get { return Nota; }
        set { Nota = value; }
    }

    public override string ToString()
    {
        return $"Nome: {Nome}, Nota: {Nota}";
    }
}