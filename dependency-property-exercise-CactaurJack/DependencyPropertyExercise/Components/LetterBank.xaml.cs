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
    /// Interaction logic for LetterBank.xaml
    /// </summary>
    public partial class LetterBank : WrapPanel
    {
        public LetterBank()
        {
            InitializeComponent();
            for (char c = 'A'; c <= 'Z'; c++)
            {
                Children.Add(new LetterButton() { Letter = c});
            }   
        }

    }
}
