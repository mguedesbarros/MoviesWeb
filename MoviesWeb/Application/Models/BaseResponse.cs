﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace MoviesWeb.Application.Models
{
    public abstract class BaseResponse
    {

        [JsonIgnore]
        public bool Success { get; protected set; }
        public IList<string> Erros { get; protected set; }

        public void SetError(string error)
        {
            this.Success = false;

            if (this.Erros == null)
                this.Erros = new List<string>();

            this.Erros.Add(error);
        }
    }

    public static class BaseResponseExtension
    {

        public static T AddError<T>(this BaseResponse baseResponse, string error)
        {
            baseResponse.SetError(error);
            return (T)Convert.ChangeType(baseResponse, typeof(T));

        }
    }
}
