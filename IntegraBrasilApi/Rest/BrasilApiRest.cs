using IntegraBrasilApi.Dtos;
using IntegraBrasilApi.Interfaces;
using IntegraBrasilApi.Models;

namespace IntegraBrasilApi.Rest
{
    public class BrasilApiRest : IBrasilApi
    {
        public Task<ResponseGenerico<EnderecoModel>> BuscarBanco(string codigoBanco)
        {
            throw new NotImplementedException();
        }

        public Task<ResponseGenerico<EnderecoModel>> BuscarEnderecoPorCep(string cep)
        {
            throw new NotImplementedException();
        }

        public Task<ResponseGenerico<List<EnderecoModel>>> BuscarTodosBancos()
        {
            throw new NotImplementedException();
        }
    }
}
