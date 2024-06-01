using static SMEAppHouse.Ladon.Domain.Constants.Rules;

namespace SMEAppHouse.Ladon.Domain.ValueObjects;

public class MessageDetails : IEquatable<MessageDetails>
{
    // Properties
    public string Subject { get; }
    public string Content { get; }
    public MessageStatusEnum Status { get; }

    public string Name { get; }
    public string EmailAddress { get; }
    public string MobilePhoneNo { get; }

    // Constructor
    public MessageDetails(string subject, string content, MessageStatusEnum status,
        string name, string emailAddress, string mobilePhoneNo)
    {
        Subject = subject ?? throw new ArgumentNullException(nameof(subject));
        Content = content ?? throw new ArgumentNullException(nameof(content));
        Status = status;

        Name = name ?? throw new ArgumentNullException(nameof(name));
        EmailAddress = emailAddress ?? throw new ArgumentNullException(nameof(emailAddress));
        MobilePhoneNo = mobilePhoneNo ?? throw new ArgumentNullException(nameof(mobilePhoneNo));
    }

    // Methods
    public bool Equals(MessageDetails other)
    {
        if (other is null)
            return false;

        return Subject == other.Subject && Content == other.Content &&
            Status == other.Status && Name == other.Name &&
            EmailAddress == other.EmailAddress && MobilePhoneNo == other.MobilePhoneNo;
    }

    public override bool Equals(object obj)
    {
        if (obj is MessageDetails other)
            return Equals(other);

        return false;
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(Subject, Content, Status, Name, EmailAddress, MobilePhoneNo);
    }

    public static bool operator ==(MessageDetails left, MessageDetails right)
    {
        if (left is null)
            return right is null;

        return left.Equals(right);
    }

    public static bool operator !=(MessageDetails left, MessageDetails right)
    {
        return !(left == right);
    }
}