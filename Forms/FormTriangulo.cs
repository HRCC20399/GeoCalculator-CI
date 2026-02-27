using System;
using System.Drawing;
using System.Windows.Forms;
using GeoApp.Models;

namespace GeoApp
{
    public class FormTriangulo : Form
    {
        private TextBox txtBase = new TextBox { Location = new Point(100, 20) };
        private TextBox txtAltura = new TextBox { Location = new Point(100, 50) };
        private Button btnCalcular = new Button { Text = "Calcular", Location = new Point(100, 80) };

        public FormTriangulo()
        {
            this.Controls.Add(new Label { Text = "Base:", Location = new Point(20, 20) });
            this.Controls.Add(txtBase);
            this.Controls.Add(new Label { Text = "Altura:", Location = new Point(20, 50) });
            this.Controls.Add(txtAltura);
            this.Controls.Add(btnCalcular);

            btnCalcular.Click += (s, e) =>
            {
                double res = Calculadora.AreaTriangulo(double.Parse(txtBase.Text), double.Parse(txtAltura.Text));
                MessageBox.Show("El área es: " + res);
            };
        }
    }
}
