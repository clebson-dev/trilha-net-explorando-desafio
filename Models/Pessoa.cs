namespace DesafioProjetoHospedagem.Models;

public class Pessoa
{
    public Pessoa() { }

    public Pessoa(string nome)
    {
        Nome = nome;
    }

    public Pessoa(string nome, string sobrenome)
    {
        Nome = nome;
        Sobrenome = sobrenome;
    }

    private string _nome;

    public string Nome
    { 
        get => _nome;

            set 
            {
                if (value == "")
                {
                    throw new ArgumentException("O nome não pode ser vazio");
                }

                _nome = value;
            } 
    }

    private string _sobrenome;
    
    public string Sobrenome
    {
         get => _sobrenome;

            set
            {
                if (value == "")
                {
                    throw new ArgumentException("O sobrenome não pode ser vazio");
                }

                _sobrenome = value;
            }
    }
    public string NomeCompleto => $"{Nome} {Sobrenome}".ToUpper();
}