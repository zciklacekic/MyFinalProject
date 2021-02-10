using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    //Hem I Result interface indeki result ve mesaj hem de T tipinde data dondurecek
    public interface IDataResult<T>:IResult
    {
        T Data { get; }
    }
}
