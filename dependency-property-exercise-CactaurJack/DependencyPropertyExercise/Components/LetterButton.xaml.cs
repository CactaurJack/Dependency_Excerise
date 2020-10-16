using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DependencyPropertyExercise.Components
{
    /// <summary>
    /// Interaction logic for LetterButton.xaml
    /// </summary>
    public partial class LetterButton : UserControl
    {
        public static DependencyProperty LetterProperty = DependencyProperty.Register("Letter", typeof(char), typeof(LetterButton));

        public char Letter
        {
            get => (char)GetValue(LetterProperty);
            set => SetValue(LetterProperty, value);
        }

        public LetterButton()
        {
            InitializeComponent();
        }

        void HandleChecked(object sender, RoutedEventArgs e)
        {
            pickedToggleButton.IsEnabled = false;
        }

    }
}
