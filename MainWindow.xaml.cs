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
using DemoAppPopova.Model;

namespace DemoAppPopova
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        AgentDatabaseEntities context = new AgentDatabaseEntities();
        List<string> cbValue = new List<string>();
        List<string> listFiltr = new List<string>();
        public MainWindow()
        {
            InitializeComponent();

        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            cbValue.Add("Фильтрация");
            foreach (var item in context.AgentType.ToList())
            {
                cbValue.Add(item.Title);
            }
            cbFilter.SelectedIndex = 0;
            cbFilter.ItemsSource = cbValue;

            listFiltr.Add("Сортировка");
            listFiltr.Add("По возрастанию");
            listFiltr.Add("По убыванию");
           
            cbSort.SelectedIndex = 0;
            cbSort.ItemsSource = listFiltr;
            
        }
    }
}
