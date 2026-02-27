using System;
using System.Drawing;
using System.Windows.Forms;
using GeoApp.Models;

namespace GeoApp
{
    public class FormCirculo : Form
    {
        private TextBox txtRadio = new TextBox { Location = new Point(100, 20), Width = 120 };
        private Button btnCalcular = new Button { Text = "Calcular", Location = new Point(100, 60), Width = 120 };
        private Label lblResultado = new Label { Location = new Point(20, 100), Width = 250, Text = "" };

        public FormCirculo()
        {
            this.Text = "Calculadora de Círculo";
            this.Size = new System.Drawing.Size(320, 200);

            this.Controls.Add(new Label { Text = "Radio:", Location = new Point(20, 23), Width = 70 });
            this.Controls.Add(txtRadio);
            this.Controls.Add(btnCalcular);
            this.Controls.Add(lblResultado);

            btnCalcular.Click += (s, e) =>
            {
                if (double.TryParse(txtRadio.Text, out double radio))
                {
                    double resultado = Calculadora.AreaCirculo(radio);
                    MessageBox.Show("El área del círculo es: " + Math.Round(resultado, 4));
                }
                else
                {
                    MessageBox.Show("Por favor ingresa un número válido.");
                }
            };
        }
    }
}
