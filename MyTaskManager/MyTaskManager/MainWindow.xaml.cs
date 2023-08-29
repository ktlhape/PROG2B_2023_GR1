using System;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace MyTaskManager
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            LoadTasks();
        }

       public void LoadTasks()
        {
            lstDisplay.Items.Clear();
            string myPC = Environment.MachineName;
            Process[] runningProcess = (from proc in Process.GetProcesses(myPC)
                                 orderby proc.ProcessName descending
                                 select proc).ToArray();
            foreach (Process p in runningProcess)
            {
                lstDisplay.Items.Add($"{p.Id} {p.ProcessName}");
            }
        }

        private void btnEndTask_Click(object sender, RoutedEventArgs e)
        {
            string selected = lstDisplay.SelectedItem.ToString();
            int index = selected.IndexOf(" ");
            int processId = Convert.ToInt32(selected.Substring(0, index));
            Process myProcess = Process.GetProcessById(processId);
            myProcess.Kill();

            LoadTasks();
        }
    }
}
