class Estudiante
{
    private int edad;
    public int Edad
    {
        get
        {
            if (edad >= 0&&edad<=100) return edad;
            else return 0;
        }
    }
}