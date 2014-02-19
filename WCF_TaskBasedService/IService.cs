using System.ServiceModel;

namespace WCF_TaskBasedService
{
    [ServiceContract]
    public interface IService
    {
        [OperationContract]
        EmployeeInfo[] GetEmployees();
    }


    public class EmployeeInfo
    {
        public int EmpNo { get; set; }
        public string EmpName { get; set; }
    }
}