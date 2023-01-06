namespace Weather.Exceptions
{
    internal class ApiKeyNotFoundException : Exception
    {
        public ApiKeyNotFoundException() : base("Không tìm thấy API Key") { }
    }
}
