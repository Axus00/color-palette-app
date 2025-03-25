namespace ColorPalette.Application.Shared;

public class ApiResponse<T>(bool statusResponse, string message, T data)
{
    public bool StatusResponse { get; set; } = statusResponse;
    public string Message { get; set; } = message;
    public T Data { get; set; } = data;

    public static ApiResponse<T> SuccessResponse(T data, string message = "Operation successful")
    {
        return new ApiResponse<T>( true, message, data);
    }

    public static ApiResponse<T> FailureResponse(T data, string message = "Operation failed")
    {
        return new ApiResponse<T>( false, message, data);
    }
}