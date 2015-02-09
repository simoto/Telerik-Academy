namespace Chat.Data
{
    using Chat.Models;
    using MongoDB.Driver.Builders;
    using System;
    using System.Text;
    using System.Threading.Tasks;

    public class ChatModule
    {
        private readonly MongoDbContext mongoDbContext;

        public ChatModule(MongoDbContext mongoDbContext)
        {
            this.mongoDbContext = mongoDbContext;
        }

        private long PostsCountOnLastCheck { get; set; }

        public void AddPost(Post post)
        {
            this.mongoDbContext.Posts.Insert(post);
        }

        public Task<bool> HaveNewPosts()
        {
            return Task.Run(() =>
            {
                var newPostCount = this.mongoDbContext.Posts.Count();

                var haveNewPosts = newPostCount != this.PostsCountOnLastCheck;
                if (haveNewPosts)
                {
                    this.PostsCountOnLastCheck = newPostCount;
                }

                return haveNewPosts;
            });
        }

        public StringBuilder GenerateAllPostsAsString(DateTime startDate, DateTime endDate)
        {
            var postsAsString = new StringBuilder();

            var findPostsInDateRangeQuery = Query<Post>.Where(post => post.PostOn >= startDate && post.PostOn <= endDate);
            var posts = this.mongoDbContext.Posts.Find(findPostsInDateRangeQuery);

            foreach (var post in posts)
            {
                postsAsString.AppendLine(this.GenerateOnePostAsString(post));
            }

            if (postsAsString.Length >= 2)
            {
                postsAsString.Length -= 2;
            }

            return postsAsString;
        }

        public string GenerateOnePostAsString(Post post)
        {
            var formattedDate = post.PostOn.ToLocalTime().ToString("dd.MM.yyyy hh:mm:ss");
            return string.Format("[{0}] {1}: {2}", formattedDate, post.PostBy, post.Content);
        }
    }
}
