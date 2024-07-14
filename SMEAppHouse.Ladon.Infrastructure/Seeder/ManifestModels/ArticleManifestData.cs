using System.Xml.Serialization;
using static SMEAppHouse.Ladon.Domain.Constants.Rules;

namespace SMEAppHouse.Ladon.Infrastructure.Seeder.ManifestModels;

public class ArticleManifestData
{
    public static List<Article> Read()
    {
        var articles = new List<Article>();
        var outputDirectory = AppContext.BaseDirectory;

        var manifestsFolder = Path.Combine(outputDirectory, "Seeder", "Data", "ArticleManifests");
        var articleManifestFiles = Directory.GetFiles(manifestsFolder, "*.xml");        
        
        var articlesFolder = Path.Combine(outputDirectory, "Resources", "Documents", "Articles");
        var articleContentFiles = Directory.GetFiles(articlesFolder, "*.md");

        foreach (var articleManifestFile in articleManifestFiles)
        {
            var fileNameNoExt = Path.GetFileNameWithoutExtension(articleManifestFile);
            if (!articleContentFiles.Any(cf => cf.Contains(fileNameNoExt)))
                continue;

            var serializer = new XmlSerializer(typeof(Article));
            var manifestFile = Path.Combine(manifestsFolder, articleManifestFile);
            var xmlContent = File.ReadAllText(manifestFile);
            using StringReader reader = new(xmlContent);
            var article = (Article)serializer.Deserialize(reader);
            if (article == null)
                continue;

            article.ContentFilename = $"{fileNameNoExt}.md";
            articles.Add(article);
        }

        return articles;
    }

    public List<Article> Posts { get; set; } = [];

    public class Article
    {
        public string Title { get; set; }
        public ArticleTypesEnum ArticleType { get; set; }
        public ArticleStatusEnum ArticleStatus { get; set; }
        public DateTime? PublishedDate { get; set; }
        public DateTime LastModified { get; set; }
        public required string Slug { get; set; }
        public int Likes { get; set; }
        public int Hearts { get; set; }
        public int Views { get; set; }
        public bool IsFeatured { get; set; }
        public string MetaDescription { get; set; }
        public string ArticleOverview { get; set; }
        public string CanonicalUrl { get; set; }

        [XmlArray("MetaKeywords")]
        [XmlArrayItem("Keyword")]
        public List<string> MetaKeywords { get; set; }

        [XmlArray("Tags")]
        [XmlArrayItem("Tag")]
        public List<string> Tags { get; set; }

        [XmlArray("ArticleCategories")]
        [XmlArrayItem("ArticleCategory")]
        public List<string> ArticleCategories { get; set; } = [];

        [XmlArray("ArticleImages")]
        [XmlArrayItem("ArticleImage")]
        public List<string> ArticleImages { get; set; }

        public string AuthorName { get; set; }
        public string AuthorAvatarImageCDNUrl { get; set; }
        public string ContentFilename { get; set; }
    }
}
