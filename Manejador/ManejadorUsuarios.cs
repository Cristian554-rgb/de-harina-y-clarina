using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AccesoDatos;
namespace Manejador
{
    public class ManejadorUsuarios
    {
        Funciones f = new Funciones();
        public void Guardar(TextBox Username, TextBox Password,
            TextBox Nombre, TextBox Apellido, ComboBox Nivel)
        {
            MessageBox.Show(f.Guardar($"insert into usuarios values ('{Username.Text}', sha1('{Password.Text}'), '{Nombre.Text}', '{Apellido.Text}', '{Nivel.Text}');"),
                "!Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public void Borrar(int Id, string dato)
        {
            DialogResult rs = MessageBox.Show($"estas seguro de borrar {dato}",
                "!Atencion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
            {
                f.Borrar($"delete from usuarios where id={Id}");
                MessageBox.Show("Registro Eliminado", "!Atencion", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }
        public void Modificar(TextBox Username, TextBox Password, TextBox Nombre,
            TextBox Apellido, ComboBox Nivel, int Id)
        {
            MessageBox.Show(f.Modificar($"UPDATE usuarios SET Username = '{Username.Text}', Password = '{Password.Text}', Nombre = '{Nombre.Text}', Apellidos = '{Apellido.Text}', Nivel = '{Nivel.Text}' WHERE Id = {Id};"),
                "!Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        DataGridViewButtonColumn Boton(string t, Color co)
        {
            DataGridViewButtonColumn bo = new DataGridViewButtonColumn();
            bo.Text = t;
            bo.UseColumnTextForButtonValue = true;
            bo.FlatStyle = FlatStyle.Popup;
            bo.DefaultCellStyle.BackColor = co;
            bo.DefaultCellStyle.ForeColor = Color.White;
            return bo;
        }
        public void Mostrar(DataGridView tabla, string filtro)
        {
            tabla.Columns.Clear();
            tabla.DataSource = f.Mostrar($"Select * from usuarios where nombre like '%{filtro}%'",
                "usuarios").Tables[0];
            tabla.Columns.Insert(4, Boton("Borrar", Color.Red));
            tabla.Columns.Insert(5, Boton("Modificar", Color.Green));
            tabla.AutoResizeColumns();
            tabla.AutoResizeRows();
        }
    }
}
