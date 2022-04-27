using System.ComponentModel.DataAnnotations;

namespace Odonto.Models;

public class Pessoa
{
    public Pessoa(
    string nome,
    DateTime dataNascimento,
    string cpf,
    string cep,
    string uf,
    string cidade,
    string bairro,
    string logradouro,
    int numeroDaCasa,
    string complemento)
    {
        Nome = nome;
        DataNascimento = dataNascimento;
        Cpf = cpf;
        Cep = cep;
        Uf = uf;
        Cidade = cidade;
        Bairro = bairro;
        Logradouro = logradouro;
        NumeroDaCasa = numeroDaCasa;
        Complemento = complemento;
    }

    [Key]
    [Required]
    public long Id { get; set; }
    [Required(ErrorMessage = "O nome é obrigatorio")]
    public string Nome { get; set; }
    public DateTime DataNascimento { get ; set;}
    [StringLength(11)]
    [Required (ErrorMessage = "O CPF é Obrigatorio")]
    public string Cpf { get; set; }
    [StringLength(8)]
    public string Cep { get; set; }
    [StringLength(2)]
    public string Uf { get; set; }
    [Required]
    public string Cidade { get; set; }
    [Required]
    public string Bairro { get; set; }
    [Required]
    public string Logradouro { get; set; }
    [Required]
    public int NumeroDaCasa { get; set; }
    [Required]
    public string Complemento { get; set; }
}