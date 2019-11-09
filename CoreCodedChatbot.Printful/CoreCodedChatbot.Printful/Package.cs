using System;
using CoreCodedChatbot.Printful.Factories;
using CoreCodedChatbot.Printful.Interfaces.Factories;
using Microsoft.Extensions.DependencyInjection;

namespace CoreCodedChatbot.Printful
{
    public static class Package
    {
        public static IServiceCollection AddChatbotPrintfulService(this IServiceCollection services)
        {
            services.AddTransient<IPrintfulClientFactory, PrintfulClientFactory>();

            return services;
        }
    }
}
