namespace SMEAppHouse.Ladon.Domain.Constants;

public static class FieldLengths
{
    public static class General
    {
        public const int PhoneNumber = 20;
        public const int EmailAddress = 200;
        public const int URL = 2400;

        public const int ExtremelyShort = 5;
        public const int ExtraShort = 10;
        public const int Short = 20;
        public const int Medium = 50;
        public const int Long = 150;
        public const int ExtraLong = 300;
        public const int SuperLong = 1000;
        public const int HyperLong = 2400;
        public const int SummaryParagraph = 800;
    }

    public static class GeneralAddress
    {
        public const int StreetAddressLength = 250;
        public const int CityLength = 100;
        public const int StateOrRegionLength = 100;
        public const int ZipCodeLength = 15;
        public const int CountryCodeLength = General.ExtremelyShort;
        public const int FullAddressLength = General.ExtraLong;
    }

    public static class QuoteRequest
    {
        public const int FirstName = General.Medium;
        public const int LastName = General.Medium;
        public const int CompanyName = General.Medium;
        public const int EmailAddress = General.EmailAddress;
        public const int PhoneNumber = General.PhoneNumber;
        public const int AddressLine1 = GeneralAddress.StreetAddressLength;
        public const int AddressLine2 = GeneralAddress.StreetAddressLength;
        public const int StateOrRegion = GeneralAddress.StateOrRegionLength;
        public const int City = GeneralAddress.CityLength;
        public const int ZipCode = GeneralAddress.ZipCodeLength;
        public const int CountryCode = GeneralAddress.CountryCodeLength;

        public const int SiteProjectName = General.Long;
        public const int SiteAddressLine1 = GeneralAddress.StreetAddressLength;
        public const int SiteAddressLine2 = GeneralAddress.StreetAddressLength;
        public const int SiteStateOrRegion = GeneralAddress.StateOrRegionLength;
        public const int SiteCity = GeneralAddress.CityLength;
        public const int SiteZipCode = GeneralAddress.ZipCodeLength;
        public const int SiteCountry = GeneralAddress.CountryCodeLength;

        public const int SpecialRequirementsOrFeatures = General.HyperLong;
        public const int AdditionalCommentsOrQuestions = General.HyperLong;

        public const int ProjectServiceTypeCode = General.ExtraShort;
    }

    public static class QuoteRequestAttachment
    {
        public const int OriginalFilename = General.Long;
        public const int AssetCDNUrl = General.URL;
    }

    public static class Message
    {
        public const int Subject = 60;
        public const int ContentText = General.HyperLong;
        public const int ContentHtml = General.HyperLong;
        public const int Name = General.Medium;
        public const int EmailAddress = General.EmailAddress;
        public const int MobilePhoneNo = General.PhoneNumber;
    }

    public static class Article
    {
        public const int Title = 200;
        public const int Content = 4000;

        public const int Tags = 120;
        public const int Slug = 1000;

        public const int MetaDescription = 300;
        public const int ArticleOverview = General.SummaryParagraph;
        public const int MetaKeywords = 400;
        public const int CanonicalUrl = General.URL;
        public const int AuthorName = 80;
    }

    public static class ArticleCategory
    {
        public const int CategoryName = 120;
    }

    public static class ArticleComment
    {
        public const int Name = 30;
        public const int Email = General.EmailAddress;
        public const int CommentText = General.SuperLong;
    }

    public static class QuestionAnswer
    {
        public const int Question = 120;
        public const int AnswerText = General.SuperLong;
    }

    public static class ClientTestimony
    {
        public const int ClientName = 60;
        public const int ClientProfession = 40;
        public const int ClientBusinessName = 60;
        public const int Remarks = 600;

        public const int ClientThumnailUrl = General.URL;
        public const int ProjectImageUrl = General.URL;
    }
}