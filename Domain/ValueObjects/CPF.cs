public class CPF
{
    private readonly string _cpf;
    public CPF(string cpf)
    {
        this._cpf = cpf;
            //Cálculo para validar CPF....
    }

    public override string ToString()
        => this._cpf;

}