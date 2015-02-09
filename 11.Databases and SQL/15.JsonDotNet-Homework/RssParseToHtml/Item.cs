namespace RssParseToHtml
{
    using Newtonsoft.Json;
    using System;

    [JsonObject("item")]
    public class Item
    {
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("link")]
        public string Link { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("pubDate")]
        public DateTime PublicateData { get; set; }
    }
}
