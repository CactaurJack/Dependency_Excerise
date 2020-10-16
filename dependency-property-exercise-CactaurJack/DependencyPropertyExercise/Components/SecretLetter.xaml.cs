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
    /// Interaction logic for SecretLetter.xaml
    /// </summary>
    public partial class SecretLetter : UserControl
    {
        /// <summary>
        /// A dependancy property representing the letter this 
        /// control represents
        /// </summary>
        public static DependencyProperty LetterProperty = DependencyProperty.Register("Letter", typeof(char), typeof(SecretLetter));

        /// <summary>
        /// The letter this control represents
        /// </summary>
        public char Letter
        {
            get { return (char)GetValue(LetterProperty); }
            set { SetValue(LetterProperty, value); }
        }

        public SecretLetter()
        {
            InitializeComponent();
        }
    }
}
