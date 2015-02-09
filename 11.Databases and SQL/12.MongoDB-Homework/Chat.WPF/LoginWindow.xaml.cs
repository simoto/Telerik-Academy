using Chat.Data;
using Chat.Models;
using System.Windows;

namespace Chat.WPF
{
    /// <summary>
    /// Interaction logic for LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        public LoginWindow()
        {
            InitializeComponent();
            this.textBoxName.Focus();
        }

        private void singUpButton_Click(object sender, RoutedEventArgs e)
        {
            var userName = this.textBoxName.Text;
            if (!ChatValidation.IsValidUsername(userName))
            {
                return;
            }

            this.Hide();
            this.ShowCrowdChatWindow(userName);
            this.Close();
        }

        private void ShowCrowdChatWindow(string username)
        {
            var user = new Session(username);
            var mainWindow = new ChatWindow(user);
            mainWindow.Show();
        }
    }
}
