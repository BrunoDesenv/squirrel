public class Email
{
    public readonly string _email { get; set; }   

    public Email(string email)
    {
        this._email = email;
        //Cálculo mágico para validar EMAIL....
    }

    public override string ToString()
        => this._email;  
}