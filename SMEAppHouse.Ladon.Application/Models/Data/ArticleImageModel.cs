using SMEAppHouse.Ladon.Application.Models.Base;

namespace SMEAppHouse.Ladon.Application.Models.Data;

public class ArticleImageModel : KeyedModel
{
    public required string ImageCDNUrl { get; set; }
}
