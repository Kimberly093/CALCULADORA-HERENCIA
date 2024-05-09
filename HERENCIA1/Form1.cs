using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HERENCIA1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void sumar_Click(object sender, EventArgs e)
        {
            //voy a darle comportamiento a mi boton
            //voy a utilizar mi clase hija sumar
            Sumar suma = new Sumar(); //instancie, o
                                      //hice un nuevo objeto suma
                                      //llamar al metodo de clase suma operar
            resultado.Text = suma.operar
            (int.Parse(valor1.Text), int.Parse(valor2.Text)).ToString();
        }

        private void restar_Click(object sender, EventArgs e)
        {
            //voy a darle comportamiento a mi boton
            //voy a utilizar mi clase hija sumar
            Restar resta = new Restar(); //instancie, o
                                         //hice un nuevo objeto suma
                                         //llamar al metodo de clase suma operar
            resultado.Text = resta.operar
            (int.Parse(valor1.Text), int.Parse(valor2.Text)).ToString();
        }

        private void limpiar_Click(object sender, EventArgs e)
        {
            valor1.Clear();
            valor2.Clear();
            resultado.Clear();
        }

        private void multiplicar_Click(object sender, EventArgs e)
        {
            //voy a darle comportamiento a mi boton
            //voy a utilizar mi clase hija sumar
            Multiplicar multiplicar = new Multiplicar(); //instancie, o
                                                         //hice un nuevo objeto suma
                                                         //llamar al metodo de clase suma operar
            resultado.Text = multiplicar.operar
            (int.Parse(valor1.Text), int.Parse(valor2.Text)).ToString();
        }

        private void valor1_TextChanged(object sender, EventArgs e)
        {   
        
            
        }

            private void dividir_Click(object sender, EventArgs e)
            {
                // Obtienen los valores de las cajas de texto que en este caso son 'valor1' y 'valor2' 
                // Y despues los pasamo a conver a enteros
                int num1 = int.Parse(valor1.Text);
                int num2 = int.Parse(valor2.Text);

                // Creamos una nueva instancia de la clase 'Division'
                Division division = new Division();

                // Llamamos al método 'operar' de la clase 'Division' para realizar la división
                int resultadoDivision = division.operar(num1, num2);

                // Verificar si el resultado de la división es igual al valor especial que indicamos para división por cero
                if (resultadoDivision == int.MinValue)
                {
                    // Si el resultado indica división por cero, mostrar un mensaje de error
                   Console.WriteLine("No se puede dividir por cero.");
                }
                else
                {
                    // Si la división fue exitosa, mostrar el resultado en el TextBox 'resultado'
                    resultado.Text = resultadoDivision.ToString();
                }
            }

    }
}         

