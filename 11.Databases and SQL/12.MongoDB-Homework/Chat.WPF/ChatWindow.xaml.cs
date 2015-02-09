namespace Chat.WPF
{
    using Chat.Data;
    using Chat.Models;
    using System;
    using System.Threading;
    using System.Threading.Tasks;
    using System.Windows;

    /// <summary>
    /// Interaction logic for ChatWindow.xaml
    /// </summary>
    public partial class ChatWindow : Window
    {
        private Thread updatePostsThread;
        ChatModule crowdChatModule;
        
        public ChatWindow(Session user)
        {
            InitializeComponent();
            this.User = user;
        }

        private Session User { get; set; }

        private bool IsInShowAllPostsMode { get; set; }

        private Task<string> GetPostsAsString(Tuple<DateTime, DateTime> dateTimeRange)
        {
            return Task.Run(() =>
            {
                return this.crowdChatModule.GenerateAllPostsAsString(dateTimeRange.Item1, dateTimeRange.Item2).ToString();
            });
        }

        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            this.updatePostsThread.Abort();
            App.Current.Shutdown();
        }

        private async void ShowAllPostsAsync(Tuple<DateTime, DateTime> dateTimeRanges)
        {
            var postsAsString = await this.GetPostsAsString(dateTimeRanges);
            this.allPostsTextBox.Text = postsAsString.ToString();
            this.allPostsTextBox.ScrollToEnd();
        }

        private void OnShowAllPosts_Click(object sender, RoutedEventArgs e)
        {
            this.IsInShowAllPostsMode = true;
            this.ShowAllPostsAsync(this.GetDateTimeRange());
        }

        private void OnPostButton_Click(object sender, RoutedEventArgs e)
        {
            var postContent = this.postContent.Text;
            if (string.IsNullOrEmpty(postContent))
            {
                return;
            }

            var postModel = new Post()
            {
                Content = postContent,
                PostOn = DateTime.Now,
                PostBy = this.User.Name
            };

            this.postContent.Text = string.Empty;
            this.crowdChatModule.AddPost(postModel);
            this.allPostsTextBox.Text += (this.allPostsTextBox.Text.Length > 0 ? Environment.NewLine : string.Empty) +
                                         this.crowdChatModule.GenerateOnePostAsString(postModel);
            this.allPostsTextBox.ScrollToEnd();
        }

        private Tuple<DateTime, DateTime> GetDateTimeRange()
        {
            if (this.IsInShowAllPostsMode)
            {
                return Tuple.Create(DateTime.MinValue, DateTime.MaxValue);
            }
            else
            {
                return Tuple.Create(this.User.LoggedOn, DateTime.MaxValue);
            }
        }

        private void OnWindowFormLoaded(object sender, RoutedEventArgs e)
        {
            this.InitializeChatModule();
            this.ShowAllPostsAsync(this.GetDateTimeRange());
            this.postContent.Focus();
            this.UpdatePostsEachMsAsync();
        }

        private void InitializeChatModule()
        {
            var mongoDbContext = new MongoDbContext();
            this.crowdChatModule = new ChatModule(mongoDbContext);
        }

        private async void UpdatePostsEachMsAsync(int refreshMs = 500)
        {
            this.updatePostsThread = new Thread(async () =>
            {
                while (true)
                {
                    this.allPostsTextBox.Dispatcher.BeginInvoke((Action)(async () => this.UpdatePosts()));
                    Thread.Sleep(refreshMs);
                }
            });

            this.updatePostsThread.Start();
        }

        private async void UpdatePosts()
        {
            var haveNewPosts = await this.crowdChatModule.HaveNewPosts();
            if (!haveNewPosts)
            {
                return;
            }

            var newPostsAsString = await this.GetPostsAsString(this.GetDateTimeRange());
            this.allPostsTextBox.Text = newPostsAsString;
            this.allPostsTextBox.ScrollToEnd();
        }
    }
}
