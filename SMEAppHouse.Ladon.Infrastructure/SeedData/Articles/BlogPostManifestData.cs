using System.Xml.Serialization;
using static SMEAppHouse.Ladon.Domain.Constants.Rules;

namespace SMEAppHouse.Ladon.Infrastructure.SeedData.Articles
{
    public class ArticleManifestData
    {
        public static Articles Read()
        {
            var outputDirectory = AppContext.BaseDirectory;
            var manifestFile = Path.Combine(outputDirectory,"SeedData", "Articles", "manifest.xml");            
            var xmlContent = File.ReadAllText(manifestFile);

            // Deserialize XML into objects
            Articles blogPosts;
            XmlSerializer serializer = new XmlSerializer(typeof(Articles));
            using StringReader reader = new StringReader(xmlContent);
            blogPosts = (Articles)serializer.Deserialize(reader);
            return blogPosts;
        }

        [XmlRoot("Articles")]
        public class Articles
        {
            [XmlElement("Article")]
            public List<Article> Posts { get; set; } = [];
        }

        public class Article
        {
            public string Title { get; set; }
            public ArticleTypesEnum ArticleType { get; set; }
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

            [XmlArray("MetaKeywords")]
            [XmlArrayItem("Keyword")]
            public List<string> MetaKeywords { get; set; }

            [XmlArray("Tags")]
            [XmlArrayItem("Tag")]
            public List<string> Tags { get; set; }

            [XmlArray("ArticleCategories")]
            [XmlArrayItem("ArticleCategory")]
            public List<ArticleCategory> ArticleCategories { get; set; }

            [XmlArray("ArticleImages")]
            [XmlArrayItem("ArticleImage")]
            public List<string> ArticleImages { get; set; }

            public string AuthorName { get; set; }
            public string AuthorAvatarImageCDNUrl { get; set; }

        }

        public class ArticleCategory
        {
            public string Name { get; set; }
        }
    }
}
