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
    /// Interaction logic for SecretPhrase.xaml
    /// </summary>
    public partial class SecretPhrase : WrapPanel
    {
        static FrameworkPropertyMetadata metaData = new FrameworkPropertyMetadata("", FrameworkPropertyMetadataOptions.AffectsMeasure | FrameworkPropertyMetadataOptions.AffectsRender, HandlePhraseChanged);
        public static DependencyProperty PhraseProperty = DependencyProperty.Register("Phrase", typeof(string), typeof(SecretPhrase), metaData);

        public string Phrase
        {
            get => (string)GetValue(PhraseProperty);
            set => SetValue(PhraseProperty, value);
        }

        public SecretPhrase()
        {
            InitializeComponent();
        }

        static void HandlePhraseChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if(sender is SecretPhrase secretPhrase)
            {
                secretPhrase.Children.Clear();
                foreach(char c in secretPhrase.Phrase)
                {
                    secretPhrase.Children.Add(new SecretLetter() { Letter = c });
                }
            }
        }
    }
}
