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

namespace OverwatchPick
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<string> heroes_;
        public MainWindow()
        {
            InitializeComponent();

            heroes_ = new List<string>();

            yourheroes.Visibility = Visibility.Hidden;
            heroes.Visibility = Visibility.Hidden;

            heroes_.Add("d.va");
            heroes_.Add("заря");
            heroes_.Add("ориса");
            heroes_.Add("райнхардт");
            heroes_.Add("сигма");
            heroes_.Add("таран");
            heroes_.Add("турбосвин");
            heroes_.Add("уинстон");
            heroes_.Add("бастион");
            heroes_.Add("гэндзи");
            heroes_.Add("жнец");
            heroes_.Add("крысавчик");
            heroes_.Add("кулак смерти");
            heroes_.Add("маккри");
            heroes_.Add("мэй");
            heroes_.Add("роковая вдова");
            heroes_.Add("симметра");
            heroes_.Add("солдат-76");
            heroes_.Add("сомбра");
            heroes_.Add("торбьорн");
            heroes_.Add("трейсер");
            heroes_.Add("фарра");
            heroes_.Add("хандзо");
            heroes_.Add("эхо");
            heroes_.Add("эш");
            heroes_.Add("ана");
            heroes_.Add("ангел");
            heroes_.Add("батист");
            heroes_.Add("бригитта");
            heroes_.Add("дзеньятта");
            heroes_.Add("лусио");
            heroes_.Add("мойра");
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Random random = new Random();
            var value = random.Next(0, heroes_.Count - 1);
            yourheroes.Visibility = Visibility.Visible;
            heroes.Visibility = Visibility.Visible;
            heroes.Text = heroes_[value];
        }
    }
}
