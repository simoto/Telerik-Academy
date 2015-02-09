namespace Chat.Models
{
    using MongoDB.Bson;
    using System;

    public class Post
    {
        public ObjectId Id { get; set; }

        public string Content { get; set; }

        public DateTime PostOn { get; set; }

        public string PostBy { get; set; }
    }
}
