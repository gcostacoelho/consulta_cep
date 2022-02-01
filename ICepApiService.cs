using Refit;

namespace consAPI
{
    public interface ICepApiService
    {
        [Get("/ws/{Cep}/json")]
        Task<cep_resp> GetAddressAsync(string Cep); 
    }
}