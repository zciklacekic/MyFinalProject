using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class Result : IResult
    {
        //Iki constructor ard arda yazıp overload ediyoruz.
        //Ilk constructor :this(success) ile ikinci parametresini ikinci constructor a gonder
        //Yani class tek parametre ile de iki parametre ile de çagrılabilir. 
        public Result(bool success, string message):this(success)
        {
            Message = message;
        }
        public Result(bool success)
        {
            Success = success;
        }

        public bool Success { get; }

        public string Message { get; }
    }
}
