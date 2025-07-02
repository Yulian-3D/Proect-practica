using System;

namespace Project.BLL.Exceptions
{
    public abstract class HttpException : Exception
    {
        public abstract int StatusCode { get; }
    }
}
