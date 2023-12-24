﻿using System;
using System.Runtime.Serialization;

namespace DotnetYuzuncuYil.Service.Exceptions
{
    [Serializable]
    public class NotFoundException : Exception
    {
        public NotFoundException(string message) : base(message)
        {

        }

        protected NotFoundException(SerializationInfo info, StreamingContext context) : base(info, context)
        {

        }
    }
}
