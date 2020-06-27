﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesWeb.Application.Models
{
    public class ErrorResponse : BaseResponse
    {

        public ErrorResponse(List<string> erros)
        {
            this.Erros = erros;
        }
    }
}
