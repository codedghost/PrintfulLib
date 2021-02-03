using System.Threading.Tasks;
using PrintfulLib.Helpers;
using PrintfulLib.Models.ApiRequest;
using PrintfulLib.Models.ApiResponse;

namespace PrintfulLib.Services
{
    internal class WebhookSetupService : PrintfulServiceBase
    {
        internal WebhookSetupService(string apiKey) : base(apiKey)
        {
        }

        internal async Task<WebhookConfigurationResponse> Get()
        {
            var response = await _client.GetAsync<WebhookConfigurationResponse>("webhooks");

            return response;
        }

        internal async Task<WebhookConfigurationResponse> SetUp(SetUpWebhookConfigurationRequest request)
        {
            var response = await _client.PostAsync<WebhookConfigurationResponse, SetUpWebhookConfigurationRequest>("webhooks", request);

            return response;
        }

        internal async Task<WebhookConfigurationResponse> Disable()
        {
            var response = await _client.DeleteAsync<WebhookConfigurationResponse>("webhooks");

            return response;
        }
    }
}