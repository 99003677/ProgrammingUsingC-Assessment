using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemTwo_CompilationError
{
    class Manager : Employee
    {
        public List<Employee> DirectReports { get; set; }
        public string CostCode { get; set; }

        public Manager(int eId, string eName, int eLevel, DateTime eDoj, List<Employee> drEmployeesLst, string cCode) :base(eId, eName, eLevel, eDoj)
        {
            DirectReports = drEmployeesLst;
            CostCode = cCode;
            EmpID = eId;
            EmpName = eName;
            EmpLevel = eLevel;
            DateOfJoining = eDoj;

        }

        public List<string> GetMyReports()
        {
            return DirectReports.Select(x => x.EmpName).ToList();
        }

    }
}
