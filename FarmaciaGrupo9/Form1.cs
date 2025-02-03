using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Farmacia
{
    public struct Medicamento
    {
        public string G9_codigo;
        public string G9_nombre;
        public int G9_cantidad;
        public double G9_precioUnitario;
        public double G9_montoInvertido;

        public Medicamento(string codigo, string nombre, int cantidad, double precioUnitario)
        {
            G9_codigo = codigo;
            G9_nombre = nombre;
            G9_cantidad = cantidad;
            G9_precioUnitario = precioUnitario;
            G9_montoInvertido = cantidad * precioUnitario;
        }
    }

    public partial class Form1 : Form
    {
        // Se crea una Lista de Medicmanetos
        public List<Medicamento> G9_ListaMedicamentos = new List<Medicamento>();

        public Form1()
        {
            InitializeComponent();
        }

        // Mesaje Confirmación
        private void MensajeConfirmacion(string mensaje)
        {
            MessageBox.Show(mensaje, "Farmacia", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Mensaje Error
        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "Farmacia", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        // Agregar Medicamento
        private void i_btn_agregar_Click(object sender, EventArgs e)
        {
            //Comprobación de todos los text field llenos
            if (i_txt_codigo.Text == string.Empty ||
                i_txt_nombre.Text == string.Empty ||
                i_txt_cantidad.Text == string.Empty ||
                i_txt_precio.Text == string.Empty)
            {
                MensajeError("Debe llenar todos los campos.");
                return;
            }

            //Comprobación, TextField Cantidad y Precio, solo contenga números
            bool G_9contieneLetra1 = i_txt_cantidad.Text.Any(c => Char.IsLetter(c));
            bool G_9contieneLetra2 = i_txt_precio.Text.Any(c => Char.IsLetter(c));

            if (G_9contieneLetra1 || G_9contieneLetra2)
            {
                MensajeError("No puede ingresar letras en los campos de cantidad y precio.");
                return;
            }

            //Se crea struct de un nuevo medicamento
            int G9_cantidad = int.Parse(i_txt_cantidad.Text);
            double G9_precio = double.Parse(i_txt_precio.Text);
            Medicamento nuevo_medicamento = new Medicamento(i_txt_codigo.Text, i_txt_nombre.Text, G9_cantidad, G9_precio);

            //Se comprueba que el codigo del medicamento no exista en la lista
            //Buscador
            for (int i = 0; i < G9_ListaMedicamentos.Count; i++)
            {
                if (nuevo_medicamento.G9_codigo == G9_ListaMedicamentos[i].G9_codigo)
                {
                    MensajeError("El código del medicamento ingresado ya existe.");
                    return;
                }
            }
            G9_ListaMedicamentos.Add(nuevo_medicamento);

            //Se ordena alfabeticamente la lista de medicamentos
            //Método burbuja
            for (int i = 0; i < G9_ListaMedicamentos.Count - 1; i++)
            {
                for (int j = 0; j < G9_ListaMedicamentos.Count - i - 1; j++)
                {
                    if (G9_ListaMedicamentos[j].G9_nombre.CompareTo(G9_ListaMedicamentos[j + 1].G9_nombre) > 0)
                    {
                        (G9_ListaMedicamentos[j], G9_ListaMedicamentos[j + 1]) = (G9_ListaMedicamentos[j + 1], G9_ListaMedicamentos[j]);
                    }
                }
            }

            // Impresion de Tabla
            i_listaMedicamentos.Rows.Clear();

            for (int i = 0; i < G9_ListaMedicamentos.Count; i++)
            {
                int n = i_listaMedicamentos.Rows.Add();
                
                i_listaMedicamentos.Rows[n].Cells[0].Value = G9_ListaMedicamentos[i].G9_codigo;
                i_listaMedicamentos.Rows[n].Cells[1].Value = G9_ListaMedicamentos[i].G9_nombre;
                i_listaMedicamentos.Rows[n].Cells[2].Value = G9_ListaMedicamentos[i].G9_cantidad;
                i_listaMedicamentos.Rows[n].Cells[3].Value = G9_ListaMedicamentos[i].G9_precioUnitario;
                i_listaMedicamentos.Rows[n].Cells[4].Value = G9_ListaMedicamentos[i].G9_montoInvertido;
            }

            //Se Borra el contenido de los Textflieds
            i_txt_codigo.Clear();
            i_txt_nombre.Clear();
            i_txt_cantidad.Clear();
            i_txt_precio.Clear();

            //Confirmación
            MensajeConfirmacion("El medicamento se agregó correctamente.");
        }

        //Botón de cancelación de agregado
        private void i_btn_cancelar1_Click(object sender, EventArgs e)
        {
            //Se borran los textField
            i_txt_codigo.Clear();
            i_txt_nombre.Clear();
            i_txt_cantidad.Clear();
            i_txt_precio.Clear();
        }

        //Rliminar un Medicamento
        private void i_eliminar_Click(object sender, EventArgs e)
        {
            //Comprobación que el TextField no este vacio
            string G9_medicamento = i_txt_codigoEliminar.Text;

            if (G9_medicamento == string.Empty)
            {
                MensajeError("Debe ingresar un código");
                return;
            }

            //Buscando el Medicamento por su código
            for (int i = 0; i < G9_ListaMedicamentos.Count; i++)
            {
                //El medicamento es borrado de la lista
                if (G9_ListaMedicamentos[i].G9_codigo == G9_medicamento)
                {
                    DialogResult resultado =
                        MessageBox.Show($"¿Está seguro que desea borrar el medicamento {G9_medicamento}?",
                            "Confirmar borrado", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (resultado == DialogResult.Yes)
                    {
                        G9_ListaMedicamentos.Remove(G9_ListaMedicamentos[i]);

                        i_listaMedicamentos.Rows.Clear();

                        for (int j = 0; j < G9_ListaMedicamentos.Count; j++)
                        {
                            int n = i_listaMedicamentos.Rows.Add();

                            i_listaMedicamentos.Rows[n].Cells[0].Value = G9_ListaMedicamentos[j].G9_codigo;
                            i_listaMedicamentos.Rows[n].Cells[1].Value = G9_ListaMedicamentos[j].G9_nombre;
                            i_listaMedicamentos.Rows[n].Cells[2].Value = G9_ListaMedicamentos[j].G9_cantidad;
                            i_listaMedicamentos.Rows[n].Cells[3].Value = G9_ListaMedicamentos[j].G9_precioUnitario;
                            i_listaMedicamentos.Rows[n].Cells[4].Value = G9_ListaMedicamentos[j].G9_montoInvertido;
                        }

                        i_txt_codigoEliminar.Clear();
                        MensajeConfirmacion("Se elimino con éxito.");
                    }
                    else
                    {
                        i_txt_codigoEliminar.Clear();
                    }

                    return;
                }
            }

            //Al no encotrase el medicamento, manda este mensaje de error
            MensajeError("El código no existe.");
        }

        //Cancela la eliminacion de un medicamento
        private void i_btn_cancelar2_Click(object sender, EventArgs e)
        {
            i_txt_codigoEliminar.Clear();
        }

        //Buscar un medicamento
        private void I_Buscar_Click(object sender, EventArgs e)
        {
            string medicamento = i_txt_buscar.Text;

            if (medicamento == string.Empty)
            {
                MensajeError("Debe ingresar un código");
                return;
            }

            //El nombre del medicamento es buscado en la lista

            for (int i = 0; i < G9_ListaMedicamentos.Count; i++)
            {
                if (G9_ListaMedicamentos[i].G9_nombre == medicamento)
                {
                    string mensaje =
                        $"Se encontró el medicamento: {G9_ListaMedicamentos[i].G9_nombre}\n codigo: {G9_ListaMedicamentos[i].G9_codigo}\n catidad: {G9_ListaMedicamentos[i].G9_cantidad}\n precio: {G9_ListaMedicamentos[i].G9_precioUnitario}\n monto invertido: {G9_ListaMedicamentos[i].G9_montoInvertido}";
                    MensajeConfirmacion(mensaje);
                    return;
                }
            }

            //Al no encotrase el medicamento, manda este mensaje de error
            MensajeError("No se encontró el medicamento.");
        }
        
        // Cancela la Busqueda de un medicamento
        private void i_btn_buscarCancelar_Click(object sender, EventArgs e)
        {
            i_txt_buscar.Clear();
        }

        private void I_Lista_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void i_listaMedicamentos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}