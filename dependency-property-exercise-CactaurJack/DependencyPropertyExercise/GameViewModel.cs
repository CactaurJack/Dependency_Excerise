using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using LobsterPot;

namespace DependencyPropertyExercise
{
    public class GameViewModel : INotifyPropertyChanged
    {
        GameEngine game = new GameEngine();
        public event PropertyChangedEventHandler PropertyChanged;
        public string Phrase
        {
            get { return game.RevealedPhrase; }
        }

        public int WrongGuesses => game.WrongGuesses;

        public bool IsWon => game.IsWon;

        public bool IsLost => game.IsLost;

        public void Guess(char c)
        {
            if (game.Guess(c))
            {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Phrase"));
                if (game.IsWon) PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("IsWon"));
            }
            else
            {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("WrongGuesses"));
                if (game.IsLost) PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("IsLost"));
            }
        }
    }
}
