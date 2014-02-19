using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Threading;

namespace WCF_TaskBasedService
{
    public class Service : IService
    {
        EmployeeInfo[] Employees = null;

        public Service()
        {
            Employees = new EmployeeInfo[]
            {
               new EmployeeInfo() {EmpNo=1,EmpName="A"},
               new EmployeeInfo() {EmpNo=2,EmpName="B"},
               new EmployeeInfo() {EmpNo=3,EmpName="C"},
               new EmployeeInfo() {EmpNo=4,EmpName="D"},
               new EmployeeInfo() {EmpNo=4,EmpName="E"},
               new EmployeeInfo() {EmpNo=5,EmpName="F"},
               new EmployeeInfo() {EmpNo=6,EmpName="G"},
               new EmployeeInfo() {EmpNo=7,EmpName="H"},
               new EmployeeInfo() {EmpNo=8,EmpName="I"},
               new EmployeeInfo() {EmpNo=9,EmpName="J"},
               new EmployeeInfo() {EmpNo=10,EmpName="K"},
               new EmployeeInfo() {EmpNo=11,EmpName="L"},
               new EmployeeInfo() {EmpNo=12,EmpName="M"},
               new EmployeeInfo() {EmpNo=13,EmpName="O"},
               new EmployeeInfo() {EmpNo=14,EmpName="P"},
               new EmployeeInfo() {EmpNo=15,EmpName="Q"},
               new EmployeeInfo() {EmpNo=16,EmpName="R"},
               new EmployeeInfo() {EmpNo=17,EmpName="S"},
               new EmployeeInfo() {EmpNo=18,EmpName="T"},
               new EmployeeInfo() {EmpNo=19,EmpName="U"},
               new EmployeeInfo() {EmpNo=20,EmpName="V"},
               new EmployeeInfo() {EmpNo=21,EmpName="W"},
               new EmployeeInfo() {EmpNo=22,EmpName="X"},
               new EmployeeInfo() {EmpNo=23,EmpName="Y"},
               new EmployeeInfo() {EmpNo=24,EmpName="Z"}
            };
        }

        public EmployeeInfo[] GetEmployees()
        {
            Thread.Sleep(10000); 
            return Employees;
        }
    }
}
