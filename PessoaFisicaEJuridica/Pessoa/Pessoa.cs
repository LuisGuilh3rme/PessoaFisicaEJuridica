using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PessoaFisicaEJuridica.Pessoa
{
    internal class Pessoa
    {
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public string Email { get; set; }
        public string TelefoneA { get; set; }
        public string TelefoneB { get; set; }

        public Pessoa(string nome, string endereco, string email, string telefoneA, string telefoneB)
        {
            Nome = nome;
            Endereco = endereco;
            Email = email;
            TelefoneA = telefoneA;
            TelefoneB = telefoneB;
        }

        public override string ToString()
        {
            return $" Nome: {Nome} \n Endereço: {Endereco} | Email: {Email} \n TelA: {TelefoneA} | TelB: {TelefoneB}";
        }
    }
}
