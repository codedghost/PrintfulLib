using System.ComponentModel;
using PrintfulLib.Models.ChildObjects;

namespace PrintfulLib.Helpers
{
    internal static class OrderStatusHelper
    {
        internal static string GetOrderStatus(this OrderStatus orderStatus)
        {
            switch (orderStatus)
            {
                case OrderStatus.Draft:
                    return "draft";
                case OrderStatus.Pending:
                    return "pending";
                case OrderStatus.Failed:
                    return "failed";
                case OrderStatus.Cancelled:
                    return "canceled";
                case OrderStatus.InProcess:
                    return "inprocess";
                case OrderStatus.OnHold:
                    return "onhold";
                case OrderStatus.Partial:
                    return "partial";
                case OrderStatus.Fulfilled:
                    return "fulfilled";
                default:
                    throw new InvalidEnumArgumentException("Invalid value for OrderStatus");
            }
        }

        internal static OrderStatus ParseOrderStatus(string orderStatus)
        {
            switch (orderStatus)
            {
                case "draft":
                    return OrderStatus.Draft;
                case "failed":
                    return OrderStatus.Failed;
                case "pending":
                    return OrderStatus.Pending;
                case "canceled":
                    return OrderStatus.Cancelled;
                case "onhold":
                    return OrderStatus.OnHold;
                case "inprocess":
                    return OrderStatus.InProcess;
                case "partial":
                    return OrderStatus.Partial;
                case "fulfilled":
                    return OrderStatus.Fulfilled;
                default:
                    throw new InvalidEnumArgumentException("Invalid value for OrderStatus");
            }
        }
    }
}