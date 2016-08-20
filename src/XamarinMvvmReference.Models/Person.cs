﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace XamarinMvvmReference.Models
{
    public class Person
    {
        public Person()
        {
            PersonId = Guid.NewGuid(); ;
        }

        public Guid PersonId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
