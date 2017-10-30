public class NomeCompleto
{
    public string Nome { get; set; }       
    public string SobreNome { get; set; }

    public NomeCompleto(string nome, string sobrenome)
    {
        this.Nome = nome;
        this.Sobrenome = sobrenome;
    }

    public override string ToString() 
            => $"{this.Nome} {this.Sobrenome}".TrimEnd();
}