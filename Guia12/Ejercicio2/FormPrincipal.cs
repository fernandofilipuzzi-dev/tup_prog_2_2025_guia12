using Ejercicio2.Models;

namespace Ejercicio2;

public partial class FormPrincipal : Form
{
    Sistema sistema = new Sistema();
    int nro;
    public FormPrincipal()
    {
        InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
        List<Auto> lista = new List<Auto>
        {
            new Auto(100, "Audi AA"),
            new Auto(101, "Audi AA")
        };
        //muestro lo que hay en la darsena
        lbDarsenaConcesionaria.Items.AddRange(lista.ToArray());

        Camion camion=new Camion(DateTime.Now,10);
        camion.NroRegisto = sistema.NroOrden;
        foreach (Auto auto in lista)
        {
            camion.CargarVehiculo(auto);
        }
    }

    private void btnCrearCamion_Click(object sender, EventArgs e)
    {
        DateTime fecha = dateTimePicker1.Value;
        int cantidad = Convert.ToInt32(textBox1.Text);
        nro = sistema.GenerarCamion(fecha, cantidad);
    }

    private void btnCargarCamion_Click(object sender, EventArgs e)
    {
        Auto selected = lbDarsenaConcesionaria.SelectedItem as Auto;

        if (selected != null)
        {
            sistema.CargarCamion(nro, selected);
            lbDarsenaConcesionaria.Items.Remove(selected);
            lbDarsenaConcesionaria.SelectedItem = null;
        }
        else
        {
            MessageBox.Show("Seleccione un auto para cargar");
        }
    }

    private void btnDescargaCamion_Click(object sender, EventArgs e)
    {

        Auto descargado = sistema.DescargarCamion(nro);
        lbDarsenaConcesionaria.Items.Add(descargado);

    }

    private void btnCerrarCamion_Click(object sender, EventArgs e)
    {
        sistema.CerrarCamion(nro);
    }


    private void btnRecibirCamion_Click(object sender, EventArgs e)
    {

        if (openFileDialog1.ShowDialog() == DialogResult.OK)
        {
            string path = openFileDialog1.FileName;

            FileStream fs = null;
            StreamReader sr = null;
            try
            {

                fs = new FileStream(path, FileMode.Open, FileAccess.Read);
                sr = new StreamReader(fs);

                lbItinerarioCamion.Items.Clear();

                sr.ReadLine();//descartar cabecera
                while (sr.EndOfStream == false)
                {
                    string linea = sr.ReadLine();

                    string[] campos = linea.Split(';');

                    int nro = Convert.ToInt32(campos[0]);
                    string modelo = campos[1];
                    double precio = Convert.ToDouble(campos[2]);

                    Auto nuevo = new Auto(nro, modelo);
                    nuevo.Precio = precio;

                    lbItinerarioCamion.Items.Add(nuevo); //Ahi tiene sentido el listbox2 para usarlo de lista intermedia
                }

                //acá recien se cuantos autos tengo , ahi puedo cargar el camion
                Camion camion = new Camion(DateTime.Now, lbItinerarioCamion.Items.Count);
                
                
                sistema.RecibirCamion(camion);

                //antes debo registrarlo , porque el sistema le tiene que dar un nro de registro
                foreach (Auto auto in lbItinerarioCamion.Items)
                {
                    sistema.CargarCamion(camion.NroRegisto, auto);
                }
                nro = camion.NroRegisto;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                if (sr != null)
                    sr.Close();
                if (fs != null)
                    fs.Close();
            }
        }
    }

    private void btnDescargarCamionRecibido_Click(object sender, EventArgs e)
    {
        if (nro>0)
        { 
            
           Auto auto= sistema.DescargarCamion(nro);//el primero
            while (auto != null)//hasta que no me devuelva mas auto
            {
                lbDarsenaConcesionaria.Items.Add(auto);  //se ven en la darsena 
                lbItinerarioCamion.Items.Remove(auto);//ya no esta en el camion

                auto = sistema.DescargarCamion(nro);
                
            }

        }
    }
}
