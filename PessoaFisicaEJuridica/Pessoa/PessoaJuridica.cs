using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PessoaFisicaEJuridica.Pessoa
{
    internal class PessoaJuridica : Pessoa
    {
        public string NomeFantasia { get; set; }
        public string CNPJ { get; set; }

        public PessoaJuridica(string nome, string endereco, string email, string telefoneA, string telefoneB, string nomeFantasia, string cnpj) : base(nome, endereco, email, telefoneA, telefoneB)
        {
            NomeFantasia = nomeFantasia;
            CNPJ = cnpj;
        }
        public override string ToString()
        {
            return $" Nome: {Nome} | NomeFantasia: {NomeFantasia} | CNPJ: {CNPJ} \n Endereço: {Endereco} | Email: {Email} \n TelA: {TelefoneA} | TelB: {TelefoneB}";
        }
    }
}
