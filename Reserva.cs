public class Reserva
{
    public Reserva(int diasreservados)
    {
        DiasReservados = diasreservados;
     }


    public List<Pessoa> Hospedes = new List<Pessoa>();
    public Suite Suite { get; set; }
    public int DiasReservados { get; }

    public void CadastrarHospedes(List<Pessoa> hospedes)
    {
        foreach (Pessoa p in hospedes)
        {
            Hospedes.Add(p);
        }
    }

    public void CadastrarSuite(Suite suite)
    {
        Suite = suite;
    }

    public int ObterQuantidadeHospedes()
    {
        return Hospedes.Count;
    }

    public decimal CalcularValorDiaria()
    {
        return Suite.ValorDiaria * DiasReservados;
    }
}