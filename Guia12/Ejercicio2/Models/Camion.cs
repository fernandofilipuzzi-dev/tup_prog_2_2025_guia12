
namespace Ejercicio2.Models;

public class Camion
{
    Stack<Auto> transporte = new Stack<Auto>();
    private DateTime fecha;
    private int cantidad;

    public Camion(DateTime fecha, int cantidad)
    {
        this.fecha = fecha;
        this.cantidad = cantidad;
    }

    public int NroRegisto { get; set; }

    public Auto RetirarAuto()
    {
        if (transporte.Count > 0)
            return transporte.Pop();
        return null;
    }

    public void CargarVehiculo(Auto auto)
    {
        if (cantidad > transporte.Count)
        { 
            transporte.Push(auto);
        }
    }

    public string[] VerCarga()
    {
        string[] carga = new string[transporte.Count];
        int n = 0;
        foreach (Auto auto in transporte)
        {
            carga[n++] = auto.ToString();
        }
        return carga;
    }

    override public string ToString()
    {
        return $"{NroRegisto}_{fecha:yyyyMMdd}";
    }
}
