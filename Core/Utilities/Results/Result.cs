using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class Result : IResult
    {
        //EĞER 1 PARAMETRE YOLLARSA 2. CONSTRUCTOR ÇALIŞACAK
        //EĞER 2 PARAMETRE YOLLARSA 1. CONSTRUCTOR ÇALIŞACAK AMA 1.CONSTRUCTOR'DA 2.CONTRUCTOR'I ÇALIŞTIRACAK
        public Result(bool success, string message) : this(success) 
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
