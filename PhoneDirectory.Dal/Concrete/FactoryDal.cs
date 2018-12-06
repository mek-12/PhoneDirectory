using PhoneDirectory.Dal.Abstract;
using PhoneDirectory.Dal.Concrete.EntityFrameworkCodeFirst;

namespace PhoneDirectory.Dal.Concrete
{
    public class FactoryDal
    {
        private FactoryDal() { }

        public static IDepartmentDal GetDepartmentDal
        {
            get => new EfDepartmentDal(PhoneDirectoryContext.Instance);
        }

        public static IEmployeeDal GetEmployeeDal
        {
            get => new EfEmployeeDal(PhoneDirectoryContext.Instance);
        }

        public static IDAdminDal GetDAdminDal
        {
            get => new EfDAdminDal(PhoneDirectoryContext.Instance);
        }
    }
}