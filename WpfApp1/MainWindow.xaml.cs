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
using Core;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Drawing.Text;
using System.Drawing;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string regime;
        string reflection;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void reflection_Checked(object sender, RoutedEventArgs e)
        {
            RadioButton pressed = (RadioButton)sender;
            reflection = pressed.Content.ToString();
        }

        private void regime_Checked(object sender, RoutedEventArgs e)
        {
            RadioButton pressed = (RadioButton)sender;
            regime = pressed.Content.ToString();
        }

        private Item CreateItem()
        {
            Item item = new();
            item.Ffunc = Ffunc.Text;
            item.Gfunc = Gfunc.Text;
            item.RegisterSize = RegisterSize.Text;
            item.InputX = InputX.Text;
            item.InputY = InputY.Text;
            return item;
        }

        private void CreateGraph()
        {
            System.Drawing.Pen myWind = new(System.Drawing.Brushes.DeepSkyBlue, 2);
            //Graphics g = pictureBox1.CreateGraphics();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Calculate calc = new(CreateItem());
            int size = Int32.Parse(RegisterSize.Text);
            if (regime == "последовательность")
            {
                if (reflection == "Мона")
                {
                    for (int i = 0; i < Math.Pow(2, size); i++)
                    {
                        for (int j = 0; j < Math.Pow(2, size); j++)
                        {

                        }
                    }
                }
            }
        }
    }
}
