using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Projeto1
{
    /// <summary>
    /// Lógica interna para Calculadora.xaml
    /// </summary>
    public partial class Calculadora : Window
    {
        public Calculadora()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //btAdição

           double num1 = Convert.ToDouble(txt_num1.Text);
           double num2 = Convert.ToDouble(txt_num2.Text);


            double resultado = num1 + num2;

            txt_resultado.Text = Convert.ToString(resultado);

        }

        private void btMultiplicar_Click(object sender, RoutedEventArgs e)
        {
            double num1 = Convert.ToDouble(txt_num1.Text);
            double num2 = Convert.ToDouble(txt_num2.Text);

            double resultado = num1 * num2;
            txt_resultado.Text = Convert.ToString(resultado);
        }

        private void btDivisao_Click(object sender, RoutedEventArgs e)
        {
            double num1 = Convert.ToDouble(txt_num1.Text);
            double num2 = Convert.ToDouble(txt_num2.Text);

            double resultado = num1 / num2;
            txt_resultado.Text = Convert.ToString(resultado);
        }

        private void btSubtração_Click(object sender, RoutedEventArgs e)
        {
            double num1 = Convert.ToDouble(txt_num1.Text);
            double num2 = Convert.ToDouble(txt_num2.Text);

            double resultado = num1 - num2;
            txt_resultado.Text = Convert.ToString(resultado);
        }

        private void bt_limpar_Click(object sender, RoutedEventArgs e)
        {
            txt_num1.Clear();
            txt_num2.Clear();
            txt_resultado.Clear();
        }

        private void txt_num1_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
