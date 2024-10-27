using System.Dynamic;
using System.Net;

namespace IntegraBrasilApi.Dtos
{
    public class ResponseGenerico<T> where T : class
    {
        public HttpStatusCode CodigoHttps { get; set; }
        
        public T? DadosRetorno { get; set; }
        
        public ExpandoObject? ErroRetorno { get; set; }
    }
}
