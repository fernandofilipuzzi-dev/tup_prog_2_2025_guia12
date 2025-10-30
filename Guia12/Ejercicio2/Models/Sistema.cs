using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Ejercicio2.Models;

public class Sistema
{
    public int NroOrden { get; set; }

    List<Camion> listaCamiones = new List<Camion> ();
    List<Auto> listaAutos = new List<Auto>();

    public int GenerarCamion(DateTime fecha, int capacidad)
    {
        Camion nuevo = new Camion(fecha, capacidad);
        listaCamiones.Add(nuevo);
        nuevo.NroRegisto = NroOrden;
        return nuevo.NroRegisto;
    }
    public Auto DescargarCamion(int nroOrden)
    {
        Camion buscado= VerCamion(nroOrden);

        Auto retirado = null;
        if(buscado!=null)
        { 
            retirado= buscado.RetirarAuto();
            listaAutos.Add(retirado);
        }

        return retirado;
    }

    public Camion VerCamion(int numero)
    {
        for (int n = 0; n < listaCamiones.Count; n++)
        { 
            if (listaCamiones[n].NroRegisto == numero)
                return listaCamiones[n];
        }
        return null;
    }

    public void CargarCamion(int nro, Auto selected)
    {
        throw new NotImplementedException();
    }

   public void CerrarCamion(int nro)
    {
        Camion camion = VerCamion(nro);
        if (camion != null)
        {
            //  if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // string path= saveFileDialog1.FileName;

                string path = camion.ToString() + ".csv";

                FileStream fs = null;
                StreamWriter sw = null;
                try
                {

                    fs = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write);
                    sw = new StreamWriter(fs);

                    foreach (string linea in camion.VerCarga())
                    {
                        sw.WriteLine(linea);
                    }
                    ;
                }
                catch (Exception ex)
                {
                }
                finally
                {
                    if (sw != null) sw.Close();
                    if (fs != null) fs.Close();
                }
            }
        }
    }
}
