using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
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

namespace WpfApplication1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();


            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            using (
                var req =
                    new StreamReader(
                        HttpWebRequest.Create("https://www.twitch.tv/ogamingsc2").GetResponse().GetResponseStream()))
            {
                string str = req.ReadToEnd();
                var str2 = "475";
                if (str.IndexOf(str2) > -1)
                {
                    str+="Вхождения найдены";
                }
                else
                {
                     str+="Вхождения не найдены";
                }
                Lbl1.Text = str;
            }

        }
    }
}
