using System.Text;
using DesafioProjetoHospedagem.Models;

Console.OutputEncoding = Encoding.UTF8;

List<Pessoa> hospedes = new List<Pessoa>();

Pessoa p1 = new Pessoa(nome: "Hóspede 1");
Pessoa p2 = new Pessoa(nome: "Hóspede 2");

hospedes.Add(p1);
hospedes.Add(p2);

Suite suite = new Suite(tipoSuite: "Premium", capacidade: 2, valorDiaria: 30);

Reserva reserva = new Reserva(diasReservados: 5);
reserva.CadastrarSuite(suite);
reserva.CadastrarHospedes(hospedes);

Console.WriteLine($"Hóspedes: {reserva.ObterQuantidadeHospedes()}");
Console.WriteLine($"Valor diária: {reserva.CalcularValorDiaria()}");

Console.WriteLine("\n--- Teste com desconto (10 dias ou mais) ---");

Reserva reserva2 = new Reserva(diasReservados: 10);
reserva2.CadastrarSuite(suite);
reserva2.CadastrarHospedes(hospedes);

Console.WriteLine($"Hóspedes: {reserva2.ObterQuantidadeHospedes()}");
Console.WriteLine($"Valor diária: {reserva2.CalcularValorDiaria()}");

Console.WriteLine("\n--- Teste de Exception (capacidade excedida) ---");

try
{
    Pessoa p3 = new Pessoa(nome: "Hóspede 3");
    hospedes.Add(p3);
    
    Reserva reserva3 = new Reserva(diasReservados: 5);
    reserva3.CadastrarSuite(suite);
    reserva3.CadastrarHospedes(hospedes);
}
catch (Exception ex)
{
    Console.WriteLine($"Erro: {ex.Message}");
}