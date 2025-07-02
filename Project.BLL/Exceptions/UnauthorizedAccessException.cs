using Microsoft.AspNetCore.Http;

namespace Project.BLL.Exceptions
{
    public class UnauthorizedAccessException : HttpException
    {
        public override int StatusCode => StatusCodes.Status401Unauthorized;

        public override string Message => "Authorization is required.";
    }
}