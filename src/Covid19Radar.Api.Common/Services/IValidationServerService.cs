﻿using Covid19Radar.Api.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Covid19Radar.Api.Services
{
    public interface IValidationServerService
    {
        ValidateResult Validate(HttpRequest req);

        public class ValidateResult
        {
            public static readonly ValidateResult Error = new ValidateResult()
            {
                IsValid = false,
                ErrorActionResult = new BadRequestResult()
            };
            public bool IsValid;
            public IActionResult ErrorActionResult;
        }

    }
}
