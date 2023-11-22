using Core.CrossCuttingConcerns.Exceptions;
using Microsoft.AspNetCore.Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.CrossCuttingConcerns.Extentions;

public static class ExtentionMiddlewareExtentions
{

    public static void ConfigureCustomExceptionMiddleware(this IApplicationBuilder app)
   => app.UseMiddleware<ExceptionMidleware>();


}    
