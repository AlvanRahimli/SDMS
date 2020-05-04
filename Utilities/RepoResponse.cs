namespace SDMS.Utilities
{
    public class RepoResponse<T>
    {
        public T Content { get; set; }
        public bool IsSuccess { get; set; }
        public string Message { get; set; }
    }
}