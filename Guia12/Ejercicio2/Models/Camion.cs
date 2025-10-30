
namespace Ejercicio2.Models;

public class Camion
{
    Stack<Auto> transporte=new Stack<Auto>;
    private DateTime fecha;
    private object capidad;

    public Camion(DateTime fecha, object capidad)
    {
        this.fecha = fecha;
        this.capidad = capidad;
    }

    public int NroRegisto { get; internal set; }

    public Auto RetirarAuto()
    {
        if(transporte.Count>0)
            return transporte.Pop();
        return null;
    }

    internal IEnumerable<string> VerCarga()
    {
        throw new NotImplementedException();
    }
}
