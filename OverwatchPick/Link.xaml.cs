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
using System.Windows.Shapes;

namespace OverwatchPick
{
    /// <summary>
    /// Логика взаимодействия для Link.xaml
    /// </summary>
    public partial class Link : Window
    {
        public Link()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            LinkWindow.Close();
        }

        private void DiscordOpen(object sender, RoutedEventArgs e)
        {
            Process.Start("https://discord.gg/FxCmQEt");
        }

        private void TelegramOpen(object sender, RoutedEventArgs e)
        {
            Process.Start("tg://resolve?domain=li_is");
        }

        private void VKOpen(object sender, RoutedEventArgs e)
        {
            Process.Start("https://vk.com/li_is.king");
        }
    }
}
