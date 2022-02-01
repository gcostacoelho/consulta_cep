using System.Threading.Tasks;   
using Refit;

class MainClass
{
    static async Task Main()
    {
        try
        {
            var cepClient = RestService.For<consAPI.ICepApiService>("http://viacep.com.br");
            Console.Write("Informe um Cep: ");
            string? cepInfo = Console.ReadLine().ToString();
            Console.WriteLine("Buscando informações do CEP " + cepInfo);

            var address = await cepClient.GetAddressAsync(cepInfo);

            Console.Write($"\nCEP: {address.Cep} \nBairro: {address.Bairro}\nLogradouro: {address.Logradouro}\nCidade: {address.Localidade}");
            Console.ReadKey();

        } catch (Exception e)
        { 
            Console.WriteLine("Erro na consulta - " + e.Message);
        }
    }
}