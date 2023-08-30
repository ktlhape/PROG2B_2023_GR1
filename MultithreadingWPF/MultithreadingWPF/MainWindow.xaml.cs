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
using System.Threading;

namespace MultithreadingWPF
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

        private void btnEven_Click(object sender, RoutedEventArgs e)
        {
            Thread thEven = new Thread(EvenNumbers);
            thEven.Start();
           // EvenNumbers();
        }
        public void EvenNumbers()
        {
            Thread.Sleep(5000);
            for (int i = 1; i <= 10; i++)
            {
                if (i % 2 == 0)
                {
                    lstEven.Items.Add(i);
                }
            }
        }
        public void OddNumbers()
        {
            for (int x = 1; x <= 10; x++)
            {
                if (x % 2 != 0)
                {
                    lstOdd.Items.Add(x);
                }
            }
        }

        private void btnOdd_Click(object sender, RoutedEventArgs e)
        {
            Thread thOdd = new Thread(OddNumbers);
            thOdd.Start();
           // OddNumbers();
        }
    }
}
