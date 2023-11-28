﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mini_HTTP_Server.Exceptions
{
    public class InternalServerErrorException : Exception
    {
        private const string InternalServerErrorExceptionDefaultMessage = "The Server has encountered an error.";

        public InternalServerErrorException() : this(InternalServerErrorExceptionDefaultMessage)
        {
            ; ;
        }

        public InternalServerErrorException(string name) : base(name)
        {
            ; ;
        }
    }


}
