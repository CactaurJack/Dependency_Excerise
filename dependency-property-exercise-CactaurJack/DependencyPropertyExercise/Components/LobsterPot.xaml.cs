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
    /// Interaction logic for LobsterPot.xaml
    /// </summary>
    public partial class LobsterPot : UserControl
    {
        static FrameworkPropertyMetadata metaData = new FrameworkPropertyMetadata(0, FrameworkPropertyMetadataOptions.AffectsRender, HandleRevealChange);
        public static DependencyProperty RevealProperty = DependencyProperty.Register("Reveal", typeof(int), typeof(LobsterPot), metaData);
        public int Reveal {
            get => (int)GetValue(RevealProperty);
            set => SetValue(RevealProperty, value);
        }
        public LobsterPot()
        {
            InitializeComponent();
        }

        public static void HandleRevealChange(object sender, DependencyPropertyChangedEventArgs e)
        {
            if(sender is LobsterPot pot)
            {
                pot.clippingBounds.Rect = new Rect(0, (7 - pot.Reveal) * 50, 300, 750);
            }
        }
    }
}
