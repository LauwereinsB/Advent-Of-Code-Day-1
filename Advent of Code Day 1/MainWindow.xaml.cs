using System;
using System.Collections.Generic;
using System.IO;
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

namespace Advent_of_Code_Day_1
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
        int increasingCount = 0;
        private void btnRun_Click(object sender, RoutedEventArgs e)
        {
            
            using (StreamReader reader = new StreamReader("D:\\Users\\Benji\\source\\repos\\Advent of Code Day 1\\Advent of Code Day 1\\Advant of code sonar input.txt"))
            {
                int check = 190;
                int read;
                while (!reader.EndOfStream)
                {
                    read = Convert.ToInt32(reader.ReadLine());
                    if (read > check)
                    {
                        increasingCount++;
                    }
                    check = read;
                }
            }
            lblResult.Content = increasingCount.ToString();
        }


    }
}
