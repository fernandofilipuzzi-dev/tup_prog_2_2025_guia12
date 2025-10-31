namespace Ejercicio2.Models;

public  class Auto
{
    private int numeroRegistro;
    private string modelo;
    public double Precio { get; set; }

    public Auto(int numeroRegistro, string modelo)
    {
        this.numeroRegistro = numeroRegistro;
        this.modelo = modelo;
    }

    public int NroRegistro
    {
        get { return numeroRegistro; }
        set { numeroRegistro = value; }
    }

    override public string ToString()
    {
        return $"{numeroRegistro};{modelo}";
    }
}
