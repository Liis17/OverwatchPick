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
using System.Windows.Shapes;

namespace OverwatchPick
{
    /// <summary>
    /// Логика взаимодействия для History.xaml
    /// </summary>
    public partial class History : Window
    {

        public static TextBox tb;

        static bool loaded = false;

        public History()
        {
            InitializeComponent();
            HistoryText.Text = "";
            loaded = true;
            tb = HistoryText;
        }

        public static void HistoryKeeping(string time)
        {
            if (loaded == true)
            {
                DateTime timE = DateTime.Now;
                string timenow = timE.Hour + ":" + timE.Minute + ":" + timE.Second;

                string olddata = tb.Text;
                tb.Text = timenow + "  " + time + "\n" + olddata;
            }
            
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            MainWindow.HistoryClose();
        }
    }
}
