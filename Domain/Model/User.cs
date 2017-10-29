public class User : ModelBase
{
    public NomeCompleto Nome { get; private set; }
    public CPF CPF { get; private set; }
    public Email Email { get; private set; }
    public Senha Senha { get; set; }

    private List<Endereco> _enderecos;
    public IReadOnlyCollection<Endereco> Enderecos => _enderecos;

    public Pessoa(Guid id, NomeCompleto nome, CPF cpf, Email email)
    {
        this.Id = id;
        this.Nome = nome;
        this.CPF = cpf;
        this.Email = email;

        this._enderecos = new List<Endereco>();
    }

    public User(NomeCompleto nome, CPF cpf, Email email) : this(Guid.NewGuid(), nome, cpf, email)
    {
    }

    public void MudaEmail(Email novoEmail)
    {
        this.Email = novoEmail;
    }

    public void AdicionarEnderecos(IReadOnlyCollection<Endereco> enderecos)
        => this._enderecos.AddRange(enderecos);

    public void AdicionarEndereco(Endereco endereco)
        => this._enderecos.Add(endereco);
}