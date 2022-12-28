using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
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

namespace WpfApp3._1
{

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            themes.SelectedItem = 0;
            //themes.SelectionChanged += ThemeChange; 
        }
        /*
        private void ThemeChange(object sender, SelectionChangedEventArgs e)
        {
            int styleIndex = styleBox.SelectedIndex; 
            Uri uri = new Uri("White.xaml", UriKind.Relative); 
                                                               
            if (styleIndex == 1)
            {
                uri = new Uri("Dark.xaml", UriKind.Relative);

            }
            ResourceDictionary resource = Application.LoadComponent(uri) as ResourceDictionary;
            Application.Current.Resources.Clear();
            Application.Current.Resources.MergedDictionaries.Add(resource);

        }
        */
        private void BoldButton_Checked(object sender, RoutedEventArgs e)
        {
            textBox.FontWeight = FontWeights.Bold;
        }

        private void BoldButton_Unchecked(object sender, RoutedEventArgs e)
        {
            textBox.FontWeight = FontWeights.Regular;
        }

        private void ItalicButton_Checked(object sender, RoutedEventArgs e)
        {
            textBox.FontStyle = FontStyles.Italic;
        }

        private void Re(object sender, RoutedEventArgs e)
        {
            textBox.FontStyle = FontStyles.Normal;
        }

        private void ToggleButton_Checked(object sender, RoutedEventArgs e)
        {
            textBox.TextDecorations.Add(TextDecorations.Underline);
        }

        private void ToggleButton_Unchecked(object sender, RoutedEventArgs e)
        {
            textBox.TextDecorations.Remove(TextDecorations.Underline[0]);
        }

        private void fontSize_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (textBox != null)
            {
                double fs = Convert.ToDouble(((sender as ComboBox).SelectedItem as string));
                textBox.FontSize = fs;
            }
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            if (textBox != null)
            {
                textBox.Foreground = Brushes.Black;
            }
        }

        private void RadioButton_Checked_1(object sender, RoutedEventArgs e)
        {
            if (textBox != null)
            {
                textBox.Foreground = Brushes.Red;
            }
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string fn = ((sender as ComboBox).SelectedItem as string);
            if (textBox != null)
            {
                textBox.FontFamily = new FontFamily(fn);
            }
        }
        /*
        private void Open_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Текстовые (*.txt)|*.txt|Все файлы (*.*)|*.*";
            if (open.ShowDialog() == true)
            {
                textBox.Text = File.ReadAllText(open.FileName);
            }
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "Текстовые (*.txt)|*.txt|Все файлы (*.*)|*.*";
            if (save.ShowDialog() == true)
                File.WriteAllText(save.FileName, textBox.Text);
        }

        private void Close_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
        */

        private void OpenExecuted(object sender, RoutedEventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Текстовые (*.txt)|*.txt|Все файлы (*.*)|*.*";
            if (open.ShowDialog() == true)
            {
                textBox.Text = File.ReadAllText(open.FileName);
            }
        }

        private void SaveExecuted(object sender, RoutedEventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "Текстовые (*.txt)|*.txt|Все файлы (*.*)|*.*";
            if (save.ShowDialog() == true)
                File.WriteAllText(save.FileName, textBox.Text);
        }

        private void ExitExecuted(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void themes_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int styleIndex = themes.SelectedIndex;
            Uri uri = new Uri("White.xaml", UriKind.Relative);

            if (styleIndex == 1)
            {
                uri = new Uri("Dark.xaml", UriKind.Relative);

            }
            ResourceDictionary resource = Application.LoadComponent(uri) as ResourceDictionary;
            Application.Current.Resources.Clear();
            Application.Current.Resources.MergedDictionaries.Add(resource);
            //MessageBox.Show(styleIndex.ToString());
        }
    }
}
