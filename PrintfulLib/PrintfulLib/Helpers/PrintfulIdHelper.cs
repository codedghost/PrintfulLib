using System;

namespace PrintfulLib.Helpers
{
    public static class PrintfulIdHelper
    {
        internal static string GetIdOrExternalId(int id, string externalId)
        {
            if (id == 0 && string.IsNullOrWhiteSpace(externalId))
                throw new Exception("An ID or an ExternalID must be provided");

            var idString = id > 0 ? id.ToString() : $"@{externalId}";

            return idString;
        }
    }
}