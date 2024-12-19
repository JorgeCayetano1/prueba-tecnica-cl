namespace APIClient.Shared.Common;

public class ResponsePagination<T>
{
    public int Length { get; set; }
    public int PageSize { get; set; }
    public required IEnumerable<T> Data { get; set; }
}