namespace ExemploPOO.Models
{
    public class Corrente : Conta
    {
        public override void Creditar(double valor)
        {
            this.Saldo = valor;
        }
    }
}