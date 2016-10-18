﻿using System.Collections.Generic;
using Microsoft.AspNetCore.Http;
using Ocelot.Library.Configuration;
using Ocelot.Library.Responses;

namespace Ocelot.Library.RequestBuilder
{
    public interface IAddHeadersToRequest
    {
        Response SetHeadersOnContext(List<ClaimToHeader> configurationHeaderExtractorProperties,
            HttpContext context);
    }
}