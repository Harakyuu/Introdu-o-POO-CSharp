namespace ExemploPOO.Models
{
    public class Retangulo
    {
        private double Comprimento;
        private double Largura;
        private bool valido;

        public void DefinirMedidas(double comprimento, double largura)
        {
            if (comprimento >0 && largura > 0)
            {
                this.Comprimento = comprimento;
                this.Largura = largura;
                valido = true;
            }
            else
            {
                System.Console.WriteLine("Valores Inválidos!");
            }
        }

        public double ObterArea()
        {
            if (valido)
            {
                return Comprimento * Largura;
            }
            else
            {
                System.Console.WriteLine("Preencha valores válidos!");
                return 0;
            }
        }
    }
} 