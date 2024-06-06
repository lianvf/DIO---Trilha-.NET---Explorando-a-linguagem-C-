public class Suite
{
    public Suite(string tiposuite, int capacidade, decimal valordiaria)
    {
        TipoSuite = tiposuite;
        Capacidade = capacidade;
        ValorDiaria = valordiaria;
    }

    public string TipoSuite { get;}
    public int Capacidade { get;}
    public decimal ValorDiaria { get;}
}