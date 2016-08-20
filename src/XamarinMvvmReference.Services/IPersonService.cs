using System;
using System.Collections.Generic;
using XamarinMvvmReference.Models;

namespace XamarinMvvmReference.Services
{
    public interface IPersonService
    {
        IEnumerable<Person> ListAll();

        Person Retrieve(Guid id);
    }
}
