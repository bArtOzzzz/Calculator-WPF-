using System.Data;
using System.Windows;
using System.Windows.Controls;

namespace Project_2_WPF
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            foreach(UIElement element in MainRoot.Children)
            {
                if(element is Button)
                {
                    ((Button)element).Click += Button_Click;
                }
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string str = (string)((Button)e.OriginalSource).Content;

            switch (str) {
                case "AC":
                    textLabel.Text = "";
                    break;
                case "=":
                    string value = new DataTable().Compute(textLabel.Text, null).ToString();
                    textLabel.Text = value;
                    break;
                default: textLabel.Text += str;
                    break;
            }
        }
    }
}
