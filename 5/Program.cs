class Usuario
{
    private string password;
    public string Password
    {
        get
        {
            int contado = 0;
            foreach (char c in password)
            {
                contado++;
            }
            if (contado >= 8) return "****";
            else return "Contraseña insegura";
        }
    }
}