namespace Domain.ValueObjects
{
    private readonly string _senha;
    public Senha(string senha)
    {
        this._senha = senha;
            //Cálculo para validar CPF....
    }

    public override string ToString()
        => this._senha;
}