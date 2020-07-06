using System.Threading.Tasks;

namespace WindowsStoreServices.OAuth
{
    /// <summary>
    /// 
    /// </summary>
    public interface IOAuthClient
    {
        Task<OAuthToken> GetTokenAsync(string tenantId, string clientId, string clientSecret);
    }
}
