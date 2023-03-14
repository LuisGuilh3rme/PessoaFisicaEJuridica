using PessoaFisicaEJuridica.Pessoa;

Pessoa pessoa = new("Guilherme", "Rua 1234", "Guilherme@gmail.com", "12345-6789", "9876-54321");
PessoaFisica pf = new("Manuela", "Rua 1234", "manU3la@gmail.com", "12345-6789", "9876-54321", "123.456.789-0");
PessoaJuridica pj = new("José Ninguém", "Rua 1234", "zeninguem@gmail.com", "12345-6789", "9876-54321", "Zé", "123.456.789-076");

Console.WriteLine(pessoa);
Console.WriteLine();

Console.WriteLine(pf);
Console.WriteLine();

Console.WriteLine(pj);
Console.WriteLine();