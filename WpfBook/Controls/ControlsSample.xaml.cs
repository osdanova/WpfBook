using System.Diagnostics;
using System.IO;
using System.Media;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace WpfBook.Controls
{
    public partial class ControlsSample : UserControl
    {
        public List<string> VacationSpots { get; set; }
        public bool ImageChanged { get; set; }

        public ControlsSample()
        {
            SetVacationSpots();
            InitializeComponent();
            SampleComboBox.ItemsSource = VacationSpots;
            SampleListBox.ItemsSource = VacationSpots;
        }

        public void SetVacationSpots()
        {
            VacationSpots = new List<string>();
            VacationSpots.Add("Spain");
            VacationSpots.Add("France");
            VacationSpots.Add("Peru");
            VacationSpots.Add("Mexico");
            VacationSpots.Add("Italy");
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Debug.WriteLine("Button Clicked");
        }

        private void Button_ChangeImage(object sender, RoutedEventArgs e)
        {
            Uri imageUri = new Uri(@"/Resources/KhLogo.png", UriKind.Relative);
            Uri image2Uri = new Uri(@"/Resources/Kh2Logo.png", UriKind.Relative);
            if (ImageChanged)
            {
                ImageChanged = !ImageChanged;
                SampleImage.Source = new BitmapImage(imageUri);
            }
            else
            {
                ImageChanged = !ImageChanged;
                SampleImage.Source = new BitmapImage(image2Uri);
            }
        }
        private void Button_PlaySound(object sender, RoutedEventArgs e)
        {
            Uri soundUri = new Uri(@"/Resources/KhSave.wav", UriKind.Relative);
            Stream soundStream = Application.GetResourceStream(soundUri).Stream;
            SoundPlayer sp = new SoundPlayer(soundStream);
            sp.Play();
        }

        private void Button_OpenFile(object sender, RoutedEventArgs e)
        {
            // Configure open file dialog box
            Microsoft.Win32.OpenFileDialog dlg = new Microsoft.Win32.OpenFileDialog();
            dlg.FileName = "Document"; // Default file name
            dlg.DefaultExt = ".txt"; // Default file extension
            dlg.Filter = "Text documents (.txt)|*.txt"; // Filter files by extension

            // Show open file dialog box
            Nullable<bool> result = dlg.ShowDialog();

            // Process open file dialog box results
            if (result == true)
            {
                // Open document
                string filename = dlg.FileName;
            }
        }
        private void Button_SaveFile(object sender, RoutedEventArgs e)
        {
            // Configure save file dialog box
            Microsoft.Win32.SaveFileDialog dlg = new Microsoft.Win32.SaveFileDialog();
            dlg.FileName = "Document"; // Default file name
            dlg.DefaultExt = ".txt"; // Default file extension
            dlg.Filter = "Text documents (.txt)|*.txt"; // Filter files by extension

            // Show save file dialog box
            Nullable<bool> result = dlg.ShowDialog();

            // Process save file dialog box results
            if (result == true)
            {
                // Save document
                string filename = dlg.FileName;
            }
        }
    }
}
