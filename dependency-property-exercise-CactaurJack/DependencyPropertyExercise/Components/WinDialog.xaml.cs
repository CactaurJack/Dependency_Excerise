using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace CustomDependencyPropertyExample.Components
{
    
    /// <summary>
    /// Interaction logic for WinDialog.xaml
    /// </summary>
    public partial class WinDialog : Window
    {
        string page = "<!DOCTYPE html><html lang=\"en\" xmlns=\"http://www.w3.org/1999/xhtml\"><head><meta charset=\"utf-8\"/><title>You Win!</title></head><body><h1>You Win!</h1><iframe width=\"560\" height=\"315\" src=\"https://www.youtube.com/embed/Pj-D0jc17D0?start=60\" frameborder=\"0\" allow=\"accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture\" allowfullscreen></iframe></body></html>";

        /// <summary>
        /// Constructs a new win dialog
        /// </summary>
        public WinDialog()
        {
            InitializeComponent();
            browser.NavigateToString(page);
            this.Closed += WinDialog_Closed;
        }

        /// <summary>
        /// Event handler for closing the dialog
        /// </summary>
        /// <param name="sender">The source of the event</param>
        /// <param name="e">The event args</param>
        private void WinDialog_Closed(object sender, EventArgs e)
        {
            // Dispose of the browser to stop video 
            this.browser.Dispose();
        }

        /// <summary>
        /// Event handler for the OK button, which closes the dialog
        /// </summary>
        /// <param name="sender">The source of the event</param>
        /// <param name="e">The event args</param>
        void Ok_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
