using AutoMapper;
using SMEAppHouse.Ladon.Application.Models;
using SMEAppHouse.Ladon.Domain.Entities.EFModels;

namespace SMEAppHouse.Ladon.Application.Mappings;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<UserProfileModel, UserProfile>().ReverseMap();

        CreateMap<MessageModel, Message>().ReverseMap();

        CreateMap<QuoteRequestModel, QuoteRequest>()
            .ForMember(dest => dest.AddressLine1, opt => opt.MapFrom(src => src.Address))
            .ForMember(dest => dest.ZipCode, opt => opt.MapFrom(src => src.ZipCode))
            .ForMember(dest => dest.City, opt => opt.MapFrom(src => src.City))
            .ForMember(dest => dest.StateOrRegion, opt => opt.MapFrom(src => src.StateOrRegion))
            .ForMember(dest => dest.CountryCode, opt => opt.MapFrom(src => src.CountryCode))
            .ForMember(dest => dest.SiteAddressLine1, opt => opt.MapFrom(src => src.SiteAddress))
            .ForMember(dest => dest.SiteCity, opt => opt.MapFrom(src => src.SiteCity))
            .ForMember(dest => dest.SiteZipCode, opt => opt.MapFrom(src => src.SiteZipCode))
            .ForMember(dest => dest.SiteStateOrRegion, opt => opt.MapFrom(src => src.SiteStateOrRegion))
            .ForMember(dest => dest.SiteCountryCode, opt => opt.MapFrom(src => src.SiteCountryCode))
            .ForMember(dest => dest.ProjectCategory, opt => opt.MapFrom(src => src.ServiceCategory))
            .ForMember(dest => dest.ProjectServiceTypeCode, opt => opt.MapFrom(src => src.ServiceCode))
            .ForMember(dest => dest.BudgetMinAmount, opt => opt.MapFrom(src => src.MinimumBudgetAmount))
            .ForMember(dest => dest.BudgetMaxAmount, opt => opt.MapFrom(src => src.MaximumBudgetAmount))
            .ForMember(dest => dest.BudgetSpecificAmount, opt => opt.MapFrom(src => src.SpecificBudgetAmount))
            .ForMember(dest => dest.PreferredCommunicationMethod, opt => opt.MapFrom(src => src.ContactPreference))
            .ForMember(dest => dest.RequestorUserProfileId, opt => opt.MapFrom(src => src.RequestorUserProfileId))
            .ForMember(dest => dest.ReferralSource, opt => opt.MapFrom(src => src.ReferralSource))
            .ForMember(dest => dest.ZipCode, opt => opt.MapFrom(src => src.ZipCode))
            .ForMember(dest => dest.SiteZipCode, opt => opt.MapFrom(src => src.SiteZipCode))
            .ForMember(dest => dest.SpecialRequirementsOrFeatures, opt => opt.MapFrom(src => src.SpecialRequirementsOrFeatures))
            .ForMember(dest => dest.AdditionalCommentsOrQuestions, opt => opt.MapFrom(src => src.AdditionalCommentsOrQuestions))
            .ForMember(dest => dest.PhoneNo, opt => opt.MapFrom(src => src.PhoneNo))
            .ForMember(dest => dest.SiteProjectName, opt => opt.MapFrom(src => src.SiteProjectName));

        CreateMap<QuoteRequest, QuoteRequestModel>()
            .ForMember(dest => dest.Address, opt => opt.MapFrom(src => $"{src.AddressLine1}\r\n{src.AddressLine2}".Trim()))
            .ForMember(dest => dest.ZipCode, opt => opt.MapFrom(src => src.ZipCode))
            .ForMember(dest => dest.City, opt => opt.MapFrom(src => src.City))
            .ForMember(dest => dest.StateOrRegion, opt => opt.MapFrom(src => src.StateOrRegion))
            .ForMember(dest => dest.CountryCode, opt => opt.MapFrom(src => src.CountryCode))
            .ForMember(dest => dest.SiteAddress, opt => opt.MapFrom(src => $"{src.SiteAddressLine1}\r\n{src.SiteAddressLine2}".Trim()))
            .ForMember(dest => dest.SiteCity, opt => opt.MapFrom(src => src.SiteCity))
            .ForMember(dest => dest.SiteZipCode, opt => opt.MapFrom(src => src.SiteZipCode))
            .ForMember(dest => dest.SiteStateOrRegion, opt => opt.MapFrom(src => src.SiteStateOrRegion))
            .ForMember(dest => dest.SiteCountryCode, opt => opt.MapFrom(src => src.SiteCountryCode))
            .ForMember(dest => dest.ServiceCategory, opt => opt.MapFrom(src => src.ProjectCategory))
            .ForMember(dest => dest.ServiceCode, opt => opt.MapFrom(src => src.ProjectServiceTypeCode))
            .ForMember(dest => dest.MinimumBudgetAmount, opt => opt.MapFrom(src => src.BudgetMinAmount))
            .ForMember(dest => dest.MaximumBudgetAmount, opt => opt.MapFrom(src => src.BudgetMaxAmount))
            .ForMember(dest => dest.SpecificBudgetAmount, opt => opt.MapFrom(src => src.BudgetSpecificAmount))
            .ForMember(dest => dest.ContactPreference, opt => opt.MapFrom(src => src.PreferredCommunicationMethod))
            .ForMember(dest => dest.RequestorUserProfileId, opt => opt.MapFrom(src => src.RequestorUserProfileId))
            .ForMember(dest => dest.ReferralSource, opt => opt.MapFrom(src => src.ReferralSource))
            .ForMember(dest => dest.ZipCode, opt => opt.MapFrom(src => src.ZipCode))
            .ForMember(dest => dest.SiteZipCode, opt => opt.MapFrom(src => src.SiteZipCode))
            .ForMember(dest => dest.SpecialRequirementsOrFeatures, opt => opt.MapFrom(src => src.SpecialRequirementsOrFeatures))
            .ForMember(dest => dest.AdditionalCommentsOrQuestions, opt => opt.MapFrom(src => src.AdditionalCommentsOrQuestions))
            .ForMember(dest => dest.PhoneNo, opt => opt.MapFrom(src => src.PhoneNo))
            .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
            .ForMember(dest => dest.SiteProjectName, opt => opt.MapFrom(src => src.SiteProjectName));

        CreateMap<QuoteRequestAttachmentModel, QuoteRequestAttachment>().ReverseMap();

        CreateMap<BlogPost, BlogPostModel>()
           .ForMember(dest => dest.Title, opt => opt.MapFrom(src => src.Title))
           .ForMember(dest => dest.Content, opt => opt.MapFrom(src => src.Content))
           .ForMember(dest => dest.PublishedDate, opt => opt.MapFrom(src => src.PublishedDate))
           .ForMember(dest => dest.LastModified, opt => opt.MapFrom(src => src.LastModified))
           .ForMember(dest => dest.Slug, opt => opt.MapFrom(src => src.Slug))
           .ForMember(dest => dest.Likes, opt => opt.MapFrom(src => src.Likes))
           .ForMember(dest => dest.Hearts, opt => opt.MapFrom(src => src.Hearts))
           .ForMember(dest => dest.Views, opt => opt.MapFrom(src => src.Views))
           .ForMember(dest => dest.IsFeatured, opt => opt.MapFrom(src => src.IsFeatured))
           .ForMember(dest => dest.MetaDescription, opt => opt.MapFrom(src => src.MetaDescription))
           .ForMember(dest => dest.CanonicalUrl, opt => opt.MapFrom(src => src.CanonicalUrl))
           .ForMember(dest => dest.MetaKeywords, opt => opt.MapFrom(src => src.MetaKeywords))
           .ForMember(dest => dest.Tags, opt => opt.MapFrom(src => src.Tags))
           .ForMember(dest => dest.RelatedPostsFrom, opt => opt.MapFrom(src => src.RelatedPostsFrom))
           .ForMember(dest => dest.RelatedPostsTo, opt => opt.MapFrom(src => src.RelatedPostsTo))
           .ForMember(dest => dest.Comments, opt => opt.MapFrom(src => src.Comments))
           .ForMember(dest => dest.AuthorUserProfileId, opt => opt.MapFrom(src => src.AuthorUserProfileId))
           .ForMember(dest => dest.AuthorName, opt => opt.MapFrom(src => src.AuthorName))
           .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id));

        CreateMap<BlogPostModel, BlogPost>()
           .ForMember(dest => dest.Title, opt => opt.MapFrom(src => src.Title))
           .ForMember(dest => dest.Content, opt => opt.MapFrom(src => src.Content))
           .ForMember(dest => dest.PublishedDate, opt => opt.MapFrom(src => src.PublishedDate))
           .ForMember(dest => dest.LastModified, opt => opt.MapFrom(src => src.LastModified))
           .ForMember(dest => dest.Slug, opt => opt.MapFrom(src => src.Slug))
           .ForMember(dest => dest.Likes, opt => opt.MapFrom(src => src.Likes))
           .ForMember(dest => dest.Hearts, opt => opt.MapFrom(src => src.Hearts))
           .ForMember(dest => dest.Views, opt => opt.MapFrom(src => src.Views))
           .ForMember(dest => dest.IsFeatured, opt => opt.MapFrom(src => src.IsFeatured))
           .ForMember(dest => dest.MetaDescription, opt => opt.MapFrom(src => src.MetaDescription))
           .ForMember(dest => dest.CanonicalUrl, opt => opt.MapFrom(src => src.CanonicalUrl))
           .ForMember(dest => dest.MetaKeywords, opt => opt.MapFrom(src => src.MetaKeywords))
           .ForMember(dest => dest.Tags, opt => opt.MapFrom(src => src.Tags))
           .ForMember(dest => dest.RelatedPostsFrom, opt => opt.MapFrom(src => src.RelatedPostsFrom))
           .ForMember(dest => dest.RelatedPostsTo, opt => opt.MapFrom(src => src.RelatedPostsTo))
           .ForMember(dest => dest.Comments, opt => opt.MapFrom(src => src.Comments))
           .ForMember(dest => dest.AuthorUserProfileId, opt => opt.MapFrom(src => src.AuthorUserProfileId))
           .ForMember(dest => dest.AuthorName, opt => opt.MapFrom(src => src.AuthorName))
           .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id ?? default));
    }
}

