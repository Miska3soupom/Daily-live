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

namespace Ежедневник
{
    public partial class MainWindow : Window
    {
        Decicions choose = new Decicions();
        List<Info> zametki = new List<Info>();

        public MainWindow()
        {
            InitializeComponent();
            zametki = choose.Read();
            LBox.ItemsSource = zametki;
            Date.Text = Convert.ToString(DateTime.Now);
            if (LBox.SelectedIndex != -1)
            {
                Maintxt.Text = Convert.ToString(zametki[1]);
                Sectxt.Text = Convert.ToString(zametki[2]);
            }
        }

        private void But_Click(object sender, RoutedEventArgs e)
        {
            Date.Text = Convert.ToString(Date.SelectedDate);
            if (sender == Save)
            {
                if (Maintxt.Text != "" & Sectxt.Text != "")
                {
                    choose.Update();
                }
                else
                {
                    MessageBox.Show("Введите название и содержание заметки!!");
                }
            }
            else if (sender == Create)
            {
                if (LBox.SelectedIndex == 0)
                {
                    MessageBox.Show("Выберите заметку для сохранения!!");
                }
                else
                {
                    if (Maintxt.Text != "" & Sectxt.Text != "")
                    {
                        choose.Create();
                    }
                    else
                    {
                        MessageBox.Show("Введите название и содержание заметки!!");
                    }
                }
            }
            else if (sender == Delete)
            {
                if (LBox.SelectedIndex == 0)
                {
                    MessageBox.Show("Вы не выбрали запись для удаления!!");
                }
                else
                {
                    choose.Delete();
                }
            }
            Maintxt.Text = "";
            Sectxt.Text = "";
        }

        private void Date_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void LBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (LBox.SelectedIndex != -1)
            {
                Maintxt.Text = zametki[LBox.SelectedIndex].Mantxt;
                Sectxt.Text = zametki[LBox.SelectedIndex].Sextxt;
            }
        }
    }
}
