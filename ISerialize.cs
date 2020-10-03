using System;
using System.Collections.Generic;
using System.Text;

namespace personal_registry
{
    interface ISerialize
    {
        void serialize(List<Person> personList);
    }
}
