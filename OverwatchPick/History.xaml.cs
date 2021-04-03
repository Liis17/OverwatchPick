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

        public static TextBlock tb;
        public History()
        {
            InitializeComponent();
            HistoryText.Text = "";
            tb = HistoryText;
        }

        public static void HistoryKeeping(string time)
        {
            DateTime timE = DateTime.Now;
            string timenow = timE.Hour + ":" + timE.Minute + ":" + timE.Second;

            string olddata = tb.Text;
            tb.Text = timenow + "  " + time + "\n" + olddata;
        }
    }
}
