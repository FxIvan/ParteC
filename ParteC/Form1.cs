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
    public partial class btnTipoDeFecha : Form
    {
        public btnTipoDeFecha()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TipoDeFecha tipoDeFecha = new TipoDeFecha();
            tipoDeFecha.ShowDialog();
        }

        private void btnOperacionsFecha_Click(object sender, EventArgs e)
        {
            OperacionesFecha operacionesFecha = new OperacionesFecha();
            operacionesFecha.ShowDialog();
        }

        private void btnOperacionesConFecha_Click(object sender, EventArgs e)
        {
            OperacionesConFecha operacionesConFecha = new OperacionesConFecha();
            operacionesConFecha.ShowDialog();
        }
    }
}
