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

namespace API
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public class GroupsList
        {
            public int id { get; set; }
            public string name
            {
                get; set;
            }
        }
        public List<GroupsList> groupsLists = new List<GroupsList>();
        public MainWindow()
        {
            InitializeComponent();
        }
        public string HttpQuery(string url)
        {
            HttpWebRequest myHttpWebRequest = (HttpWebRequest)WebRequest.Create(url);
            HttpWebResponse myHttpWebResponse = (HttpWebResponse)myHttpWebRequest.GetResponse();
            StreamReader strm = new StreamReader(myHttpWebResponse.GetResponseStream());
            return strm.ReadToEnd();
        }

    }
}
