namespace Herancas1;

public class Pessoa
{
    public string Nome { get; set; }
    public string Endereco { get; set; }
    private string _telefone;

    public string Telefone
    {
        get
        {
            return _telefone;
        }
        set{
            if(value.Length != 9){

            }
            _telefone = value;
        }
    }

    public Pessoa(string nome, string endereco, string telefone)
    {
        Nome = nome;
        Endereco = endereco;
        Telefone = telefone;
        
    }
}
