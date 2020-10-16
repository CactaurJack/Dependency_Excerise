using CustomDependencyPropertyExample.Components;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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
    /// Interaction logic for Game.xaml
    /// </summary>
    public partial class Game : UserControl
    {
        /// <summary>
        /// Creates a new game control
        /// </summary>
        public Game()
        {
            InitializeComponent();
            var gvm = new GameViewModel();
            gvm.PropertyChanged += HandlePropertyChanged;
            DataContext = gvm;
        }

        void HandleGuess(object sender, RoutedEventArgs e)
        {
            if(e.Source is LetterButton button && DataContext is GameViewModel gvm)
            {
               gvm.Guess(button.Letter);
               e.Handled = true;
            }
        }

        void HandlePropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (DataContext is GameViewModel gvm)
            {
                if (e.PropertyName == "IsWon" && gvm.IsWon)
                {
                    DisplayWin();
                }
                if (e.PropertyName == "IsLost" && gvm.IsLost)
                {
                    DisplayLoss();
                }
            }
        }

        /// <summary>
        /// Starts a new game of LobsterPot
        /// </summary>
        void Reset()
        {
            if(DataContext is GameViewModel oldgvm)
            {
                oldgvm.PropertyChanged -= HandlePropertyChanged;
            }
            var gvm = new GameViewModel();
            gvm.PropertyChanged += HandlePropertyChanged;
            DataContext = gvm;
        }

        /// <summary>
        /// Shows a dialog showing a win message
        /// </summary>
        void DisplayWin()
        {
            var dialog = new WinDialog();
            dialog.ShowDialog();
            Reset();
        }

        /// <summary>
        /// Shows a dialog displaying a loss message
        /// </summary>
        void DisplayLoss()
        {
            MessageBox.Show("You lose!");
            Reset();
        }
    }
}
