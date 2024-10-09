using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPagesDemo.Pages
{
    public class Employee
    {
        public int id { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }

        public DateTime Birth { get; set; }
    }
    public class EmployeeModel : PageModel {
        public List<Employee> EmployeeList { get; set; }
        public EmployeeModel(List<Employee> ListOfEmployee)
        {
            EmployeeList = ListOfEmployee;
            EmployeeList.Add(new Employee() { id = 1, FirstName = "Иван",       LastName = "Кучеренко" ,Birth = new DateTime(2000, 9, 21)});
            EmployeeList.Add(new Employee() { id = 2, FirstName = "Владимир",   LastName = "Путилин",   Birth = new DateTime(2001, 11, 25) });
            EmployeeList.Add(new Employee() { id = 3, FirstName = "Магомед",    LastName = "Сидорчук",  Birth = new DateTime(2002, 12, 12) });
        }

        [BindProperty(SupportsGet = true)]

        public int Id { get; set; }
        public void OnGet(int Id) { if (Id == 0)
            {
                this.Id = 1;
            }
        }
    }
}

