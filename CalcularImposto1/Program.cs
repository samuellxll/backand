
using CalcularImposto1.classes;

PessoaFisica novaPf = new PessoaFisica();

novaPf.nome = "samuel";

novaPf.cpf = "222222220";

novaPf.rendimento = 1500;

float ImpostoPagar = novaPf.CalcularImposto(novaPf.rendimento);

Console.WriteLine($"Nome:{novaPf.nome} - CPF:{novaPf.cpf} resultado {ImpostoPagar}");

PessoaJuridica novaPj = new PessoaJuridica( );

Console.WriteLine(novaPj.CalcularImposto(1500));