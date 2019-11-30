using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace MediaCollection
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void AddMultimedia_Click(object sender, RoutedEventArgs e)
        {
            NewMultimediaElement nme = new NewMultimediaElement();
            bool? multimediaEntered = nme.ShowDialog();
            if(multimediaEntered.HasValue && (multimediaEntered.Value == true))
            {
                ObservableCollection<Multimedia> oc = Resources["myMultimediaList"] as ObservableCollection<Multimedia>;
                oc.Add(nme.ReturnValue);
            }
        }
    }
}
