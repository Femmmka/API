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
using static API.MainWindow;

namespace API.Pages
{
    /// <summary>
    /// Логика взаимодействия для Groups.xaml
    /// </summary>
    public partial class Groups : Page
    {
        public Groups()
        {
            InitializeComponent();

            LoadData();
        }
        private void FindGroups()
        {
            
        }
        public void LoadData()
        {
            listView.Items.Clear();

            for (int i = 0; i < init.groupsLists.Count; i++)
            {
                listView.Items.Add(init.groupsLists[i]);
            }
        }
    }
}
