namespace APIClient.Shared.Common;

public class ResponseModel<T>
{
    public required bool Success { get; set; }
    public string Message { get; set; } = string.Empty;
    public T Output { get; set; }
    public IEnumerable<string>? Errors { get; set; }
    
    public static ResponseModel<T> SuccessResponse(string message, T output)
    {
        return new ResponseModel<T>
        {
            Success = true,
            Message = message,
            Output = output
        };
    }
    
    public static ResponseModel<T> ErrorResponse(string message)
    {
        return new ResponseModel<T>
        {
            Success = false,
            Errors = new List<string> {message}
        };
    }
}