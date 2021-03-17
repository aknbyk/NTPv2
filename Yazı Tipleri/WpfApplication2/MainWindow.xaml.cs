using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;


namespace WpfApplication2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            textBox1.FontSize = 10;
        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            textBox1.FontSize = 20;
        }

        private void MenuItem_Click_2(object sender, RoutedEventArgs e)
        {
            textBox1.FontSize = 30;
        }

        private void MenuItem_Click_3(object sender, RoutedEventArgs e)
        {
            textBox1.Foreground = Brushes.Red;
            
        }

        private void MenuItem_Click_4(object sender, RoutedEventArgs e)
        {
            textBox1.Foreground = Brushes.Yellow;
        }

        private void MenuItem_Click_5(object sender, RoutedEventArgs e)
        {
            textBox1.Foreground = Brushes.Blue;
        }

        private void MenuItem_Click_6(object sender, RoutedEventArgs e)
        {
            textBox1.Background = Brushes.Red;
        }

        private void MenuItem_Click_7(object sender, RoutedEventArgs e)
        {
            textBox1.Background = Brushes.Yellow;
        }

        private void MenuItem_Click_8(object sender, RoutedEventArgs e)
        {
            textBox1.Background = Brushes.Blue;
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            
            textBox1.FontSize += 5;
           /* label1.Content = textBox1.FontSize.ToString();
            int a = Convert.ToInt32(label1.Content);
            if(a>=150)
            {
                MessageBox.Show("Ekrana Sığmıyor!!!");
            }*/
            
        }

        private void button4_Click(object sender, RoutedEventArgs e)
        {
            textBox1.FontWeight = FontWeights.Bold;
        }

        private void button5_Click(object sender, RoutedEventArgs e)
        {
            textBox1.FontStyle = FontStyles.Italic;
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            textBox1.Text = "";
            label1.Content = "";
        }

        private void scrollBar1_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            label1.Content = scrollBar1.Value;
            textBox1.FontSize = Convert.ToInt32(label1.Content);
        }

        private void textBox1_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }

        private void listBox1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
        }

        private void comboBox1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
            if (comboBox1.SelectedIndex == 0)
            {
                FontFamily font = new FontFamily("Myriad Pro");
                textBox1.FontFamily = font;
                    
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                FontFamily font = new FontFamily("Broadway");
                textBox1.FontFamily = font;
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                FontFamily font = new FontFamily("Arial");
                textBox1.FontFamily = font;
            }
            else if (comboBox1.SelectedIndex == 3)
            {
                FontFamily font = new FontFamily("Comic Sans MS");
                textBox1.FontFamily = font;
            }
            else if (comboBox1.SelectedIndex == 4)
            {
                FontFamily font = new FontFamily("Gigi");
                textBox1.FontFamily = font;
            }
            else if (comboBox1.SelectedIndex == 5)
            {
                FontFamily font = new FontFamily("Rosewood Std Regular");
                textBox1.FontFamily = font;
            }
            else if (comboBox1.SelectedIndex == 6)
            {
                FontFamily font = new FontFamily("Vladimir Script");
                textBox1.FontFamily = font;
            }
            else if (comboBox1.SelectedIndex == 7)
            {
                FontFamily font = new FontFamily("Forte");
                textBox1.FontFamily = font;
            }
            else if (comboBox1.SelectedIndex == 8)
            {
                FontFamily font = new FontFamily("Showcard Gothic");
                textBox1.FontFamily = font;
            }
        }
    }
}
