namespace EasyBank.Results
{
    public class DataResult<T> : Result
    {
        public T Data { get; init; }

        public DataResult(T data, bool success, string message = "") 
            : base(success, message)
        {
            Data = data;
        }
    }
}
