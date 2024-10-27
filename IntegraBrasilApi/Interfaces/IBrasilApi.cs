using IntegraBrasilApi.Dtos;
using IntegraBrasilApi.Models;

namespace IntegraBrasilApi.Interfaces
{
    public interface IBrasilApi
    {

        Task<ResponseGenerico<EnderecoModel>> BuscarEnderecoPorCep(string cep);
        Task<ResponseGenerico<List<EnderecoModel>>> BuscarTodosBancos();
        Task<ResponseGenerico<EnderecoModel>> BuscarBanco(string codigoBanco);
    }
}
