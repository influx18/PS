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

namespace StudentInfoSystem
{
    /// <summary>
    /// Interaction logic for StudentListWindow.xaml
    /// </summary>
    public partial class StudentListWindow : Window
    {
        public StudentListWindow()
        {
            InitializeComponent();
        }

        public StudentListWindow(List<UserLogin.Student> students)
        {
            InitializeComponent();
            Binding myBinding = new Binding();
            //set binding parameters if necessary
            myBinding.Source = students;
            StudentListBox.SetBinding(ItemsControl.ItemsSourceProperty, myBinding);
        }
    }
}
