
namespace CAFSA.Domain.BaseEntity
{
    public class OperationResult
    {
        public OperationResult()
        {
            isSuccess = true;
            message = string.Empty;
            data = null;
            statusCode = 200; // Default to HTTP 200 OK
        }

        public bool isSuccess { get; set; }
        public string? message { get; set; }
        public object? data { get; set; }
        public int? statusCode { get; set; }

        public static OperationResult Success(object? data = null, string? message = null, int statusCode = 200)
        {
            return new OperationResult
            {
                isSuccess = true,
                data = data,
                message = message ?? "Operation completed successfully.",
                statusCode = statusCode
            };
        }

        public static OperationResult Failure(string message, int? statusCode = null, object? data = null)
        {
            return new OperationResult
            {
                isSuccess = false,
                message = message,
                data = data,
                statusCode = statusCode
            };
        }


    }
}
