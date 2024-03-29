using SGAS.Api.Interfaces.Models;

namespace SGAS.Api.Models.Response.Base
{
    public class MessageApiResponse : IBaseResponse
    {
        public MessageApiContent Message { get; set; }
        public int StatusCode { get; set; }
    }
}
