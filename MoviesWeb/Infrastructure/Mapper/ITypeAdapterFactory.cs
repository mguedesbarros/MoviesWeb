using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesWeb.Infrastructure.Mapper
{
    public interface ITypeAdapterFactory
    {
        ITypeAdapter Create();
    }
}
