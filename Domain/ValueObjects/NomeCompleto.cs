namespace Domain.ValueObjects
{
    public class NomeCompleto
    {
        public string Nome { get; set; }       
        public string SobreNome { get; set; }

        public NomeCompleto(string nome, string sobrenome)
        {
            this.Nome = nome;
            this.SobreNome = sobrenome;
        }

        public override string ToString() 
                => $"{this.Nome} {this.SobreNome}".TrimEnd();
    }
}