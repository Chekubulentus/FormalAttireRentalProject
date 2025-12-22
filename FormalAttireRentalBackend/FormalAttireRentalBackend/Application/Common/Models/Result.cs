namespace FormalAttireRentalBackend.Application.Common.Models
{
    public class Result<T>
    {
        public bool IsSuccess { get; set; }
        public T? Data { get; set; } 
        public string? ErrorMessage { get; set; }
        public string? SuccessMessage { get; set; }

        public static Result<T> SuccessWithData(T data) => new() { IsSuccess = true, Data = data };
        public static Result<T> Failure(string message) => new() { IsSuccess = false, ErrorMessage = message };
        public static Result<T> SuccessWithMessage(string message) => new() { IsSuccess = true, SuccessMessage = message };
    }
}
