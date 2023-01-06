namespace Weather.Exceptions
{
    internal class BaseApiUrlNotFoundException : Exception
    {
        public BaseApiUrlNotFoundException() : base("Không tìm thấy Base Api URL") { }
    }
}
