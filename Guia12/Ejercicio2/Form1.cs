using Ejercicio2.Models;

namespace Ejercicio2;

public partial class Form1 : Form
{
    Sistema sistema = new Sistema();
    int nro;
    public Form1()
    {
        InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
        listBox1.Items.Add(new Auto(100, "Audi AA"));
        listBox1.Items.Add(new Auto(100, "Audi AA"));
    }


    private void btnCrearCamion_Click(object sender, EventArgs e)
    {
        DateTime fecha = dateTimePicker1.Value;
        int cantidad = Convert.ToInt32(textBox1.Text);
        nro = sistema.GenerarCamion(fecha, cantidad);
    }

    private void btnCargarCamion_Click(object sender, EventArgs e)
    {
        Auto selected = listBox1.SelectedItem as Auto;

        if (selected != null)
        {
            sistema.CargarCamion(nro, selected);
            listBox1.Items.Remove(selected);
        }
        else
        {
            MessageBox.Show("Seleccione un auto para cargar");
        }
    }

    private void button3_Click(object sender, EventArgs e)
    {

        Auto descargado = sistema.DescargarCamion(nro);
        listBox1.Items.Add(descargado);

    }

    private void btnCerrarCamion_Click(object sender, EventArgs e)
    {
        sistema.CerrarCamion(nro);
    }
}
