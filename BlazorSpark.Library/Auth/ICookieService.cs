﻿using Microsoft.AspNetCore.Authentication.Cookies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorSpark.Library.Auth
{
    public interface ICookieService
    {
        Task ValidateAsync(CookieValidatePrincipalContext context);
    }
}
