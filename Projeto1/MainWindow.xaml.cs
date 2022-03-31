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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Projeto1
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void bt_entrar_Click(object sender, RoutedEventArgs e)
        {
            string senha = txt_senha.Password.ToString();
            string user = txt_usuario.Text;
            
      
            
           
                if (user == "renatacastellan" & senha == "1234")
                {
                    MessageBox.Show("Loading");
                    txt_usuario.Clear();
                    txt_senha.Clear();
                    Calculadora calculadora = new Calculadora();
                    calculadora.Show();
                    this.Close();
                }
                
            
                else
                {
                MessageBox.Show("Senha ou usuário incorreto");
                txt_usuario.Clear();
                txt_senha.Clear();
                txt_usuario.Focus();
                 }


        }
    }
}
