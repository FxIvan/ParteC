using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParteC
{
    public partial class OperacionesConFecha : Form
    {
        public OperacionesConFecha()
        {
            InitializeComponent();
        }

        private void btnSumar_Click(object sender, EventArgs e)
        {
            DateTime fecha1 = new DateTime(dateTimePicker1.Value.Year, dateTimePicker1.Value.Month, dateTimePicker1.Value.Day);
            txtresultado.Text = (fecha1.AddDays(Convert.ToInt32(txtdias.Text)).ToString("dd/MM/yyyy")).ToString();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRestar_Click(object sender, EventArgs e)
        {
            DateTime fecha1 = new DateTime(dateTimePicker1.Value.Year, dateTimePicker1.Value.Month, dateTimePicker1.Value.Day);
            txtresultado.Text = (fecha1.AddDays(-1 *
            Convert.ToInt32(txtdias.Text)).ToString("dd/MM/yyyy")).ToString();
        }
    }
}
