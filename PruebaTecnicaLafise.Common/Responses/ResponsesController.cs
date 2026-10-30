namespace PruebaTecnicaLafise.Common.Responses
{
    public class ResponseController<T>
    {
        public bool success { get; set; }
        public string? message { get; set; }
        public string[]? errors { get; set; }
        public T? data { get; set; }
        public DateTime published_at { get; set; }
    }
}
