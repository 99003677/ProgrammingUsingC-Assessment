using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemTwo_CompilationError
{
    class DirectReport : Employee
    {
        public Employee ReportsTo { get; set; }
        public string ProjectCode { get; set; }

        public DirectReport(int eId, string eName, int eLevel, DateTime eDoj, Employee managerEmpObj,string pCode) :base(eId, eName,eLevel,eDoj)
        {
            ReportsTo = managerEmpObj;
            ProjectCode = pCode;
            EmpID = eId;
            EmpName = eName;
            EmpLevel = eLevel;
            DateOfJoining = eDoj;

        }
    }
}
