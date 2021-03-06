//-----------------------------------------------------------------------
// <copyright file="SwaggerOwinSettings.cs" company="NSwag">
//     Copyright (c) Rico Suter. All rights reserved.
// </copyright>
// <license>https://github.com/NSwag/NSwag/blob/master/LICENSE.md</license>
// <author>Rico Suter, mail@rsuter.com</author>
//-----------------------------------------------------------------------

using NSwag.CodeGeneration.SwaggerGenerators.WebApi;

namespace NSwag.AspNetCore
{
    /// <summary>The settings for UseSwagger.</summary>
    public class SwaggerOwinSettings : WebApiToSwaggerGeneratorSettings
    {
        /// <summary>Gets or sets the Swagger URL route.</summary>
        public string SwaggerRoute { get; set; } = "/swagger/v1/swagger.json";

        /// <summary>Gets or sets the swagger service transformer.</summary>
        public ISwaggerServiceTransformer SwaggerServiceTransformer { get; set; }
    }
}