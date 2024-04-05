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

namespace lab6
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<int> Listlab1;

        public MainWindow()
        {
            InitializeComponent();
            Listlab1=new List<int>();
        }
        
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Listlab1.Add(int.Parse(tbElement.Text));
            Lblist.ItemsSource = null;
            Lblist.ItemsSource = Listlab1;
            tbElement.Text = "";
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            int index=Lblist.SelectedIndex;
            Listlab1.RemoveAt(index);
            Lblist.ItemsSource = null;
            Lblist.ItemsSource = Listlab1;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            List<int> numbers=new List<int>();
            foreach (var item in Lblist.Items)
            {
                if (int.TryParse(item.ToString(), out int num))
                {
                    numbers.Add(num);
                }
            }
            if (numbers.Count > 0)
            {
                int min = numbers[0];
                int minIndex = 0;
                for (int i = 1; i < numbers.Count; i++)
                {
                    if (numbers[i] < min)
                    {
                        min = numbers[i];
                        minIndex = i;
                    }
                }

                Result.Text = $"Индекс наименьшего элемента: {minIndex}";
            }
            else
            {
                Result.Text = "Список чисел пуст. Добавьте числа в ListBox.";
            }
        }
    }
    
}