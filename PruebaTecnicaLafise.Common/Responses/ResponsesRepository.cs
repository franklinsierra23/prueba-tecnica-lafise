namespace PruebaTecnicaLafise.Common.Responses
{
    public class ResponseRepository<T>
    {
        public bool success { get; set; }
        public T? data { get; set; }
        public string? errors { get; set; }
    }
}
