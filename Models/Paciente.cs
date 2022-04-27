using System.ComponentModel.DataAnnotations;

namespace Odonto.JS.Models;

public class Paciente : Pessoa
{
    public Paciente(string nome, DateTime dataNascimento, string cpf, string cep, string uf, string cidade,
    string bairro, string logradouro, int numeroDaCasa, string complemento) :
    base(nome, dataNascimento, cpf, cep, uf, cidade, bairro, logradouro, numeroDaCasa, complemento)
    {
    }
}