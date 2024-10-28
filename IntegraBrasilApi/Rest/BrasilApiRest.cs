using System.Dynamic;
using System.Text.Json;
using IntegraBrasilApi.Dtos;
using IntegraBrasilApi.Interfaces;
using IntegraBrasilApi.Models;

namespace IntegraBrasilApi.Rest
{
    public class BrasilApiRest : IBrasilApi
    {
        public object JsonSerializar { get; private set; }

        public async Task<ResponseGenerico<EnderecoModel>> BuscarEnderecoPorCep(string cep)
        {
            var request = new HttpRequestMessage(HttpMethod.Get, $"https://brasilapi.com.br/api/cep/v1/{cep}");

            var response = new ResponseGenerico<EnderecoModel>();
            using (var client = new HttpClient())
            {
                var responseBrasilApi = await client.SendAsync(request);
                var contentResp = await responseBrasilApi.Content.ReadAsStringAsync();
                var objResponser = JsonSerializer.Deserialize<EnderecoModel>(contentResp);

                if (responseBrasilApi.IsSuccessStatusCode)
                {
                    response.CodigoHttps = responseBrasilApi.StatusCode;
                    response.DadosRetorno = objResponser;
                }
                else
                {
                    response.CodigoHttps = responseBrasilApi.StatusCode;
                    response.ErroRetorno = JsonSerializer.Deserialize<ExpandoObject>(contentResp);
                }

                return response;
            }
        }

        public Task<ResponseGenerico<List<EnderecoModel>>> BuscarTodosBancos()
        {
            throw new NotImplementedException();
        }

        public Task<ResponseGenerico<EnderecoModel>> BuscarBanco(string codigoBanco)
        {
            
        }
    }
}
