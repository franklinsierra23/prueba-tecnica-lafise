using System.Net;

namespace PruebaTecnicaLafise.Common.Responses
{
    public class ResponseService<T>
    {
        public bool success { get; set; }
        public string? message { get; set; }
        public T? data { get; set; }
        public string[]? errors { get; set; }
        public HttpStatusCode statusCode { get; set; }
    }
}
