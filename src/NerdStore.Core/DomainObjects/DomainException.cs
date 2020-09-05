﻿using System;
using System.Collections.Generic;
using System.Text;

namespace NerdStore.Core.DomainObjects
{
    public class DomainException:Exception
    {
        public DomainException()
        {

        }

        public DomainException(string message) : base(message)
        {

        }
        public DomainException(string message, Exception InnerException) : base(message, InnerException)
        {

        }
    }

}
