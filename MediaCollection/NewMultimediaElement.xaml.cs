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
using static MediaCollection.Multimedia;

namespace MediaCollection
{
    /// <summary>
    /// Interaction logic for NewMultimediaElement.xaml
    /// </summary>
    public partial class NewMultimediaElement : Window
    {
        public Multimedia ReturnValue = null;
        public NewMultimediaElement()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ReturnValue = Resources["NewMultimedia"] as Multimedia;
            DialogResult = true;
            Close();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            ReturnValue = null;
            comboType.ItemsSource = Enum.GetValues(typeof(MediaType)).Cast<MediaType>();
            Keyboard.Focus(txtTitle);
        }
    }
}
