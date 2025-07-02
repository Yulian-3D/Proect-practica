﻿using Microsoft.AspNetCore.Http;

namespace Project.BLL.Exceptions
{
    public class InternalServerErrorException : HttpException
    {
        public override int StatusCode => StatusCodes.Status500InternalServerError;

        public override string Message => "Internal server error has occurred";
    }
}
