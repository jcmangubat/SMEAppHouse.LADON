namespace SMEAppHouse.Ladon.Web.Helper;

public static class CronHelper
{
    public static CronInfo Convert(this TimeSpan periodRecurrence)
    {
        if (periodRecurrence.Hours >= 1)
        {
            if (periodRecurrence.Seconds != 0)
                throw new ArgumentException("Seconds not allowed when hours are specified.");
            return new CronInfo($"{periodRecurrence.Minutes} */{periodRecurrence.Hours} * * *");
        }

        if (periodRecurrence.Minutes > 1)
        {
            if (periodRecurrence.Seconds != 0)
                throw new ArgumentException("Seconds not allowed when minutes are specified.");
            return new CronInfo($"*/{periodRecurrence.Minutes} * * * *");
        }

        return new CronInfo($"*/1 * * * *");
    }

    public class CronInfo(string cronExpression)
    {
        public string CronExpression { get; set; } = cronExpression;
    }
}
