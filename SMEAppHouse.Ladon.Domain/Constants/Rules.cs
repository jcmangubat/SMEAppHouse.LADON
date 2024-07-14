using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace SMEAppHouse.Ladon.Domain.Constants;

public class Rules
{
    public enum MessageStatusEnum
    {
        /// <summary>
        /// The message is new and hasn't been processed yet
        /// </summary>
        New = 0,

        /// <summary>
        /// When this message is persisted, it will await 
        /// for the internal process to notify the support personnel to review and take action
        /// </summary>
        EmailedToSupport = 1,

        /// <summary>
        /// The message is currently being processed
        /// </summary>
        InProgress = 2,

        /// <summary>
        /// The message has been processed and resolved
        /// </summary>
        Resolved = 3,

        /// <summary>
        /// The message is closed without needing further action
        /// </summary>
        Closed = 4,

        /// <summary>
        /// The message has been escalated to higher authorities
        /// </summary>
        Escalated = 5,

        /// <summary>
        /// The message is pending further information from the sender
        /// </summary>
        Pending = 6,

        /// <summary>
        /// The message has been reopened for further review/action
        /// </summary>
        Reopened = 7
    }

    public enum UserRulesEnum
    {
        Admin = 0,
        Manager = 1,
        Editor = 2,
        Moderator = 3,
        Client = 4,
        Visitor = 5
    }

    public enum AddressTypesEnum
    {
        /// <summary>
        /// The residential address where a person lives.
        /// </summary>
        HomeAddress = 1,
        /// <summary>
        /// The address of a person's workplace or place of employment.
        /// </summary>
        WorkOrOfficeAddress = 2,
        /// <summary>
        /// An address used for receiving mail, which may or may not be the same as the home or work address.
        /// </summary>
        MailingAddress = 3,
        /// <summary>
        /// The address associated with a person's payment method, typically used for billing and financial transactions.
        /// </summary>
        BillingAddress = 4,
        /// <summary>
        /// The address where goods or packages are to be delivered, often different from the billing address.
        /// </summary>
        ShippingAddress = 5,
        /// <summary>
        /// An address formatted for alternative home or postal delivery, including components such as street name, house number, city, state/province, postal code, and country.
        /// </summary>
        AlternativeHomeAddress = 6,
    }

    public enum GendersEnum
    {
        /// <summary>
        /// Refers to individuals who identify as male.
        /// </summary>
        Male = 0,

        /// <summary>
        /// Refers to individuals who identify as female.
        /// </summary>
        Female = 1,

        /// <summary>
        /// Refers to individuals who do not exclusively identify as male or female.
        /// </summary>
        NonBinary = 2,

        /// <summary>
        /// Refers to individuals who were assigned female at birth but identify and live as male.
        /// </summary>
        TransgenderMale = 3,

        /// <summary>
        /// Refers to individuals who were assigned male at birth but identify and live as female.
        /// </summary>
        TransgenderFemale = 4,

        /// <summary>
        /// Refers to individuals whose gender identity falls outside of the traditional binary classification of male or female.                
        /// </summary>
        Genderqueer = 5,

        /// <summary>
        /// Refers to individuals whose gender identity may shift or vary over time.
        /// </summary>
        Genderfluid = 6,

        /// <summary>
        /// Refers to individuals who do not identify with any gender.
        /// </summary>
        Agender = 7,

        /// <summary>
        /// Refers to individuals who identify with two distinct gender identities.
        /// </summary>
        Bigender = 8,

        /// <summary>
        /// Refers to individuals within certain Indigenous cultures who embody both masculine and feminine qualities.
        /// </summary>
        TwoSpirit = 9,

        /// <summary>
        /// Refers to individuals who identify with all genders or multiple genders.
        /// </summary>
        Pangender = 10,

        /// <summary>
        /// Refers to individuals who partially identify as male.
        /// </summary>
        Demiboy = 11,

        /// <summary>
        /// Refers to individuals who partially identify as female.
        /// </summary>
        Demigirl = 12,

        /// <summary>
        /// Refers to individuals who have a gender identity that is a blend of both male and female.
        /// </summary>
        Androgynous = 13,

        /// <summary>
        /// Refers to individuals who identify with a gender that is not listed or commonly recognized.
        /// </summary>
        Other = 14
    }

    public enum ContactMethodPreferencesEnum
    {
        Email = 0,
        Phone = 1,
        Both = 2
    }

    public enum ReferralSourcesEnum
    {
        [Description("Online Search")]
        OnlineSearch = 0,
        [Description("Facebook - Our Page")]
        SocialMediaFacebookOurPage = 1,
        [Description("Facebook - Mention")]
        SocialMediaFacebookMention = 2,
        [Description("Twitter")]
        SocialMediaTwitter = 3,
        [Description("Instagram")]
        SocialMediaInstagram = 4,
        [Description("Youtube - Our Channel")]
        YoutubeOurChannel = 5,
        [Description("Youtube - Vlogger's Content")]
        YoutubeVloggerContent = 6,
        [Description("Advertisement")]
        Advertising = 7,
        [Description("Our Website")]
        Website = 8,
        [Description("Word of Mouth")]
        WordOfMouth = 9,
        [Description("Previous Client")]
        PreviousClient = 10,
        [Description("Other")]
        Other = 11
    }


    public enum ArticleStatusEnum
    {
        /// <summary>
        /// The article is still being written or edited and is not yet ready for publication.
        /// </summary>
        Draft,

        /// <summary>
        /// The article has been completed and is awaiting review by an editor or moderator before publication.
        /// </summary>
        PendingReview,

        /// <summary>
        /// The article has been reviewed and scheduled for publication at a future date and time.
        /// </summary>
        Scheduled,

        /// <summary>
        /// The article has been published and is live on the website for public viewing.
        /// </summary>
        Published,

        /// <summary>
        /// The article has been removed from the main article feed or archive and is no longer prominently displayed.
        /// </summary>
        Archived,

        /// <summary>
        /// The article has been permanently deleted from the website and cannot be restored.
        /// </summary>
        Deleted,

        /// <summary>
        /// The article has been highlighted or featured on the website's homepage or in a special section.
        /// </summary>
        Featured,

        /// <summary>
        /// The article has been promoted via social media, email newsletters, or other channels.
        /// </summary>
        Promoted,

        /// <summary>
        /// The article has been flagged for review due to concerns such as inappropriate content or spam.
        /// </summary>
        Flagged,

        /// <summary>
        /// The article has been submitted for approval and is awaiting approval from a higher authority.
        /// </summary>
        PendingApproval,

        /// <summary>
        /// The article has been reviewed but requires revisions or updates before publication.
        /// </summary>
        NeedsRevision,

        /// <summary>
        /// The article has been marked for deletion and will be permanently removed from the website at a future date.
        /// </summary>
        ScheduledForDeletion
    }

    public enum ServiceCategoriesEnum
    {
        [Description("Residential")]
        Residential = 0,
        [Description("Commercial")]
        Commercial = 1,
        [Description("Industrial")]
        Industrial = 2,
        [Description("Institutional")]
        Institutional = 3,
        [Description("Infrastructure")]
        Infrastructure = 4,
        [Description("Recreational")]
        Recreational = 5,
        [Description("Specialized")]
        Specialized = 6,
        [Description("Mixed Use Developments")]
        MixedUseDevelopments = 7,
        [Description("Others")]
        Others = 8
    }

    public enum LengthUnitsEnum
    {
        [Display(Name = "Kilometer", ShortName = "km")]
        Kilometer,
        [Display(Name = "Meter", ShortName = "m")]
        Meter,
        [Display(Name = "Centimeter", ShortName = "cm")]
        Centimeter,
        [Display(Name = "Millimeter", ShortName = "mm")]
        Millimeter,
        [Display(Name = "Micrometer", ShortName = "µm")]
        Micrometer,
        [Display(Name = "Nanometer", ShortName = "nm")]
        Nanometer,
        [Display(Name = "Mile", ShortName = "mi")]
        Mile,
        [Display(Name = "Yard", ShortName = "yd")]
        Yard,
        [Display(Name = "Foot", ShortName = "ft")]
        Foot,
        [Display(Name = "Inch", ShortName = "in")]
        Inch
    }

    public enum RecipientTypesEnum
    {

        /// <summary>
        /// The primary recipient(s) of the email.
        /// </summary>
        PRIMARY,

        /// <summary>
        /// Secondary recipients who receive a copy of the email and 
        /// whose email addresses are visible to all recipients.
        /// </summary>
        CARBONCOPY,

        /// <summary>
        /// Secondary recipients who receive a copy of the email 
        /// but whose email addresses are not visible to other recipients.
        /// </summary>
        BLINDCARBONCOPY
    }

    public enum SiteMessageSourcesEnum
    {
        FromContactUs = 0,
        FromServiceQuoteRequest = 1
    }

    public enum SiteSectionsEnum
    {
        Carousel,
        Feature,
        Welcome,
        AboutUs,
        Teams,
        Facts,
        CompanyVideo,
        OurServices,
        OurPortfoliosProjects,
        Testimonials,
        ContactUs,
        Articles,
        FAQs,
    }

    public enum ArticleTypesEnum
    {
        News,
        Blog,
        PressRelease,
        CaseStudy,
        Opinion,
        Feature,
        Interview,
        Editorial,
        Review,
        Announcement,
        Tutorial,
        Report,
        Event
    }

    public enum ReaderReactionsEnum
    {
        Like,
        Heart
    }

    public enum ImageSizeOrientationStylesEnum
    {
        Small = 0,
        Big = 1,
        Wide = 2,
        Tall = 3
    }

    public enum FactPointsEnum
    {
        ExpertWorkers,
        HappyClients,
        CompletedProjects,
        RunningProjects
    }
}
