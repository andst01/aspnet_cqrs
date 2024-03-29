using SGAS.Api.Models.Response.Base;

namespace SGAS.Api.Interfaces.Models
{
    public interface IBaseResponse
    {
        MessageApiContent Message { get; set; }
        int StatusCode { get; set; }
    }
}
