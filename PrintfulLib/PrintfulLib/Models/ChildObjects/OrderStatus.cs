namespace PrintfulLib.Models.ChildObjects
{
    public enum OrderStatus
    {
        NoFilter = 0,
        Draft = 1,
        Pending = 2,
        Failed = 3,
        Cancelled = 4,
        InProcess = 5,
        OnHold = 6,
        Partial = 7,
        Fulfilled = 8,
        Archived = 9
    }

    public static class OrderStatusExtension
    {
        public static string ToString(this OrderStatus status)
        {
            switch (status)
            {
                case OrderStatus.Draft:
                    return "Draft";
                case OrderStatus.Pending:
                    return "Pending";
                case OrderStatus.Failed:
                    return "Failed";
                case OrderStatus.Cancelled:
                    return "Cancelled";
                case OrderStatus.InProcess:
                    return "In Process";
                case OrderStatus.OnHold:
                    return "On Hold";
                case OrderStatus.Partial:
                    return "Partial";
                case OrderStatus.Fulfilled:
                    return "Fulfilled";
                case OrderStatus.Archived:
                    return "Archived";
                default:
                    return "NO STATUS";
            }
        }
    }
}