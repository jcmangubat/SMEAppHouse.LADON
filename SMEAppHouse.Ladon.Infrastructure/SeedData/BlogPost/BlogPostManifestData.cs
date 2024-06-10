using System.Xml.Serialization;

namespace SMEAppHouse.Ladon.Infrastructure.SeedData.BlogPosts
{
    public class BlogPostManifestData
    {
        public static BlogPosts Read()
        {
            var outputDirectory = AppContext.BaseDirectory;
            var manifestFile = Path.Combine(outputDirectory,"SeedData", "BlogPost", "manifest.xml");            
            var xmlContent = File.ReadAllText(manifestFile);

            // Deserialize XML into objects
            BlogPosts blogPosts;
            XmlSerializer serializer = new XmlSerializer(typeof(BlogPosts));
            using StringReader reader = new StringReader(xmlContent);
            blogPosts = (BlogPosts)serializer.Deserialize(reader);
            return blogPosts;
        }

        [XmlRoot("BlogPosts")]
        public class BlogPosts
        {
            [XmlElement("BlogPost")]
            public List<BlogPost> Posts { get; set; } = [];
        }

        public class BlogPost
        {
            public string Title { get; set; }
            public string ContentFile { get; set; }
            public DateTime PublishedDate { get; set; }
            public DateTime LastModified { get; set; }
            public string Slug { get; set; }
            public int Likes { get; set; }
            public int Hearts { get; set; }
            public int Views { get; set; }
            public bool IsFeatured { get; set; }
            public string MetaDescription { get; set; }
            public string CanonicalUrl { get; set; }
            public List<string> MetaKeywords { get; set; }
            public List<string> Tags { get; set; }
            public List<ArticleCategory> ArticleCategories { get; set; }
            public string AuthorName { get; set; }
        }

        public class ArticleCategory
        {
            public string Name { get; set; }
        }
    }
}
