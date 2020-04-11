using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atique
{
    class LinqJoins
    {
        public static void Main()
        {
            List<Department> departments = new List<Department>();
            departments.Add(new Department { Id = 1, Name = "IT", Location = "Karachi" });
            departments.Add(new Department { Id = 2, Name = "Finance", Location = "Karachi" });
            departments.Add(new Department { Id = 3, Name = "Marketing", Location = "Karachi" });
            departments.Add(new Department { Id = 4, Name = "HR", Location = "Karachi" });
            departments.Add(new Department { Id = 5, Name = "Account", Location = "Karachi" });

            List<Employee> employees = new List<Employee>();
            employees.Add(new Employee { Id = 1, DepartmentId = 1, Age = 19, Name = "John", Gender = "Male" });
            employees.Add(new Employee { Id = 2, DepartmentId = 1, Age = 20, Name = "Carter", Gender = "Male" });
            employees.Add(new Employee { Id = 3, DepartmentId = 2, Age = 23, Name = "Joan", Gender = "Male" });
            employees.Add(new Employee { Id = 4, DepartmentId = 2, Age = 23, Name = "Scott", Gender = "Male" });
            employees.Add(new Employee { Id = 5, DepartmentId = 3, Age = 3, Name = "Andrew", Gender = "Male" });
            employees.Add(new Employee { Id = 6, DepartmentId = 3, Age = 24, Name = "Dave", Gender = "Male" });
            employees.Add(new Employee { Id = 7, DepartmentId = 5, Age = 28, Name = "Jason", Gender = "Male" });
            employees.Add(new Employee { Id = 8, DepartmentId = 5, Age = 24, Name = "Mike", Gender = "Male" });
            employees.Add(new Employee { Id = 9, DepartmentId = 5, Age = 28, Name = "Benn", Gender = "Male" });
            employees.Add(new Employee { Id = 10, DepartmentId = 7, Age = 24, Name = "aamir", Gender = "Male" });

            Console.WriteLine("Inner Join:-");
            InnerJoin(departments, employees);

            Console.WriteLine("Left Outer Join:-");
            LeftOuterJoin(departments, employees);

            Console.WriteLine("Right Outer Join:-");
            RightOuterJoin(departments, employees);

            Console.ReadLine();
        }

        //Inner join
        static void InnerJoin(List<Department> departments, List<Employee> employees)
        {
            //var result = from emp in employees
            //             join dept in departments
            //             on emp.DepartmentId equals dept.Id
            //             select new
            //             {
            //                 EmployeeId = emp.Id,
            //                 EmployeeName = emp.Name,
            //                 DepartmentId = dept.Id,
            //                 DepartmentName = dept.Name
            //             };

            var query = employees.Join(departments,
                      e => e.DepartmentId,
                      d => d.Id,
                      (emp, dept) => new { employee = emp, department = dept });
            //.Select(r => new
            //{
            //    EmployeeId = r.employee.Id,
            //    EmployeeName = r.employee.Name,
            //    DepartmentId = r.department.Id,
            //    DepartmentName = r.department.Name
            //}); // selection

            //foreach (var result in query)
            //{
            //    Console.WriteLine(result.employeeId + "\t\t" + result.employeeName + "\t\t" + result.departmentId + "\t\t" + result.departmentName);
            //}

            Console.WriteLine("Employee ID\tEmployee Name\tDepartment ID\tDepartment Name");

            foreach (var result in query)
            {
                Console.WriteLine(result.employee.Id + "\t\t" + result.employee.Name + "\t\t" + result.department.Id + "\t\t" + result.department.Name);
            }
        }

        //Left outer join
        static void LeftOuterJoin(List<Department> departments, List<Employee> employees)
        {
            var query = departments.GroupJoin(employees,
                d => d.Id,
                e => e.DepartmentId,
                (dept, emps) => new { department = dept, employees = emps });
            //.SelectMany(
            //   r => r.depts.DefaultIfEmpty(),
            //   (emp, dept) => new { employee = emp.employee, department = dept });

            Console.WriteLine("Department Id\tDepartment Name\tEmployee Id\tEmployee Name");

            foreach (var result in query)
            {
                if (result.employees.Count() == 0)
                    Console.WriteLine($"{result.department.Id}\t\t{result.department.Name}\t\tnull\t\tnull");

                foreach (var emp in result.employees)
                {
                    Console.WriteLine($"{result.department.Id}\t\t{result.department.Name}\t\t{emp.Id}\t\t{emp.Name}");
                }
            }
        }

        //Right outer join
        static void RightOuterJoin(List<Department> departments, List<Employee> employees)
        {
            var query = employees.GroupJoin(departments,
                e => e.DepartmentId,
                d => d.Id,
                (employee, depts) => new { employee = employee, depts = depts });
            //     .SelectMany(
            //r => r.depts.DefaultIfEmpty(),
            //(emp, dept) => new { employee = emp.employee, department = dept });

            Console.WriteLine("Employee ID\tEmployee Name\tDepartment ID\tDepartment Name");

            foreach (var result in query)
            {
                if (result.depts.Count() == 0)
                    Console.WriteLine($"{result.employee.Id}\t\t{result.employee.Name}\t\tnull\t\tnull");

                foreach (var dept in result.depts)
                {
                    Console.WriteLine($"{result.employee.Id}\t\t{result.employee.Name}\t\t{dept.Id}\t\t{dept.Name}");
                }
            }


            //var qr = departments.GroupJoin(employees,
            //    d => d.Id,
            //    e => e.DepartmentId,
            //    (dept, emps) => new { dept = dept, emps = emps })
            //     .SelectMany(
            //r => r.emps.DefaultIfEmpty(),
            //(depart, emp) => new { department = depart.dept, employee = emp == null ? new Employee() : emp });


            //foreach (var o in qr)
            //{
            //    Console.WriteLine($"{o.department.Name}, {o.employee.Name}");
            //}
        }
    }

    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
    }

    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int DepartmentId { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
    }
}
