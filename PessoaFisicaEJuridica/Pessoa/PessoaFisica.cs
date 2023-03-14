using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PessoaFisicaEJuridica.Pessoa
{
    internal class PessoaFisica : Pessoa
    {
        public string CPF { get; set; }

        public PessoaFisica(string nome, string endereco, string email, string telefoneA, string telefoneB, string cpf) : base(nome, endereco, email, telefoneA, telefoneB)
        {
            CPF = cpf;
        }

        public override string ToString()
        {
            return $" Nome: {Nome} | CPF: {CPF} \n Endereço: {Endereco} | Email: {Email} \n TelA: {TelefoneA} | TelB: {TelefoneB}";
        }
    }
}
