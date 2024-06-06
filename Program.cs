
List<Pessoa> hospedes = new List<Pessoa>();

Pessoa p1 = new Pessoa(nome: "Hóspede", sobrenome: "1");
Pessoa p2 = new Pessoa(nome: "Hóspede", sobrenome: "2");

hospedes.Add(p1);
hospedes.Add(p2);

Suite suite = new Suite(tiposuite: "Premium", capacidade: 2, valordiaria: 30);

Reserva reserva = new Reserva(diasreservados: 5);
reserva.CadastrarSuite(suite);
reserva.CadastrarHospedes(hospedes);

Console.WriteLine($"Hóspedes: {reserva.ObterQuantidadeHospedes()}");
Console.WriteLine($"Valor diária: {reserva.CalcularValorDiaria()}");