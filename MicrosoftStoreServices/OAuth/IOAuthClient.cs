using System.Threading.Tasks;

namespace MicrosoftStoreServicesAPI.OAuth
{
    /// <summary>
    /// 
    /// </summary>
    public interface IOAuthClient
    {
        Task<OAuthToken> GetTokenAsync(string tenantId, string clientId, string clientSecret);
    }
}
