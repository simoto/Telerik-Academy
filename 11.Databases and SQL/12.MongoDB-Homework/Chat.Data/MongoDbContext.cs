namespace Chat.Data
{
    using Chat.Models;
    using MongoDB.Driver;

    public class MongoDbContext
    {
        private readonly string connectionString;
        private readonly string databaseName;
        private MongoServer mongoServer;

        public MongoDbContext()
            : this(ConnectionString.Default.MongoDbCloudServer, ConnectionString.Default.MongoDbDefaultDatabase)
        {
        }

        public MongoDbContext(string connectionString, string databaseName)
        {
            this.connectionString = connectionString;
            this.databaseName = databaseName;
        }

        public MongoCollection<Post> Posts
        {
            get
            {
                return this.GetCollection<Post>("Posts");
            }
        }

        public MongoCollection<Session> Users
        {
            get
            {
                return this.GetCollection<Session>("Users");
            }
        }

        private MongoCollection<T> GetCollection<T>(string collectionName)
        {
            var database = this.GetDatabase();
            return database.GetCollection<T>(collectionName);
        }

        private MongoDatabase GetDatabase()
        {
            var server = this.GetServer();
            return server.GetDatabase(this.databaseName);
        }

        private MongoServer GetServer()
        {
            if (this.mongoServer == null)
            {
                var mongoClient = new MongoClient(this.connectionString);
                this.mongoServer = mongoClient.GetServer();
            }

            return this.mongoServer;
        }
    }
}
