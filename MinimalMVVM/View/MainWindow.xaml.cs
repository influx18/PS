using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using MinimalMVVM.ViewModel;
using System.Collections.ObjectModel;


namespace MinimalMVVM.View
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private bool upperCase = true;

        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = new PresenterUpperCase();
        }

        private void ChangeVMButton_Click(object sender, RoutedEventArgs e)
        {
            if (upperCase)
            {
                PresenterUpperCase currentPresenter = this.DataContext as PresenterUpperCase;
                this.DataContext = new PresenterLowerCase(currentPresenter.History as ObservableCollection<string>, currentPresenter.SomeText);
            } else
            {
                PresenterLowerCase currentPresenter = this.DataContext as PresenterLowerCase;
                this.DataContext = new PresenterUpperCase(currentPresenter.History as ObservableCollection<string>, currentPresenter.SomeText);
            }
            upperCase = !upperCase;
        }
    }
}
