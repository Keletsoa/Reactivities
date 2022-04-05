namespace Application.Core
{
    public class AppException
    {
        private readonly int _statusCode;
        private readonly string _message;
        private readonly string _details;
        public AppException(int statusCode, string message, string details = null)
        {
            _details = details;
            _message = message;
            _statusCode = statusCode;
        }
        public int StatusCode { get; set; }
        public string Message { get; set; }
        public string Details { get; set; }
    }
}