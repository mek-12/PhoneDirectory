using PhoneDirectory.Dal.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace PhoneDirectory.Dal.Concrete.EntityFrameworkCodeFirst
{
    public abstract class FactoryPhoneDirectoryContext
    {
        public static PhoneDirectoryContext GetPhoneDirectoryContext()
        {
            return PhoneDirectoryContext.Instance;
        }
    }
}
