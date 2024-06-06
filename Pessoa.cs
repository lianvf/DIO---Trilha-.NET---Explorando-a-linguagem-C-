public class Pessoa
{
    public Pessoa(string nome, string sobrenome)
    {
        Nome = nome;
        Sobrenome = sobrenome;
    }

    private string _nome;
    public string Nome
    {
        get => Nome.ToUpper();
        set
        {
            if (value == "")
            {
                throw new ArgumentException("Nome não pode ser vazio.");
            }
            _nome = value;
        }
    }
    private string _sobrenome;
    public string Sobrenome
    {
        get => Sobrenome.ToUpper();
        set
        {
            if (value == "")
            {
                throw new ArgumentException("Nome não pode ser vazio.");
            }
            _sobrenome = value;
        }
    }

}