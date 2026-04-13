using System.Threading.Channels;

class CuentaBancaria
{
    private double saldo;
    public string Saldo
    {
        get
        {
            if (saldo > 0) return $"Saldo disponible: {saldo}";
            else return "Saldo no disponible";
        }
    }
}