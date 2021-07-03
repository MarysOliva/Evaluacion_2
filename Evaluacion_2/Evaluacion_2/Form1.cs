using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Evaluacion_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_calcular_Click(object sender, EventArgs e)
        {
            promedio Marys = new promedio();
            Marys.Nombre = txt_nombre.Text;
            Marys.Cuenta = Convert.ToInt64(txt_cuenta.Text);
            Marys.nota1 = Convert.ToInt32(txt_dat1.Text);
            Marys.nota2 = Convert.ToInt32(txt_dat2.Text);
            Marys.nota3 = Convert.ToInt32(txt_dat3.Text);
            Marys.nota4 = Convert.ToInt32(txt_dat4.Text);

            MessageBox.Show(Marys.Nombre +" "+ "su calificación es : " +   Marys.Resultado() + " "   + Marys.Decision());
        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            txt_cuenta.Clear();
            txt_nombre.Clear();
            txt_dat1.Clear();
            txt_dat2.Clear();
            txt_dat3.Clear();
            txt_dat4.Clear();

        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            Close();

        }
    }
}

