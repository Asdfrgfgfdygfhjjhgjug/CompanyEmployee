namespace CompanyEmployee.Services
{
    using System;
    using System.Linq;
    using System.Reflection.Emit;
    using System.Collections.Generic;

    using AutoMapper.QueryableExtensions;

    using CompanyEmployee.Data;
    using CompanyEmployee.Data.Models.Entities;
    using CompanyEmployee.Services.Contracts;
    using CompanyEmployee.Services.Models;
    using System.Threading.Tasks;
    using Microsoft.EntityFrameworkCore;

    public class EmployeeService : IEmployeeService
    {
        private readonly CompanyEmployeeDBContext db;

        public EmployeeService(CompanyEmployeeDBContext db)
        {
            this.db = db;
        }

        public void Create(EmployeeRequestModel model)
        {
            var employee = new Employee()
            {
                Name = model.Name,
                Experience = model.Experience,
                StartingDate = model.StartingDate,
                Salary = model.Salary,
                VacationDays = model.VacationDays,
                CompanyId = model.CompanyId
            };

            this.db.Employees.Add(employee);
            this.db.SaveChanges();
        }

        public async Task Delete(int id)
        {
            var employee = await this.db.Employees.FindAsync(id);
            if (employee == null)
            {
                return;
            }

            this.db.Remove(employee);
            await this.db.SaveChangesAsync();
        }

        public void Edit(EmployeeDetailsModel member)
        {
            var employee = this.db.Employees.Find(member.Id);
            if (member == null)
            {
                return;
            }
            employee.Id = member.Id;
            employee.Name = member.Name;
            employee.Experience = member.Level;
            employee.StartingDate = member.StartingDate;
            employee.Salary = member.Salary;
            employee.VacationDays = member.VacationDays;

            this.db.SaveChanges();
        }

        public async Task<bool> Exists(int id)
             => await this.db.Employees.AnyAsync(c => c.Id == id);

        public EmployeeFullDetailsModel EmployeeById(int id)
        {
            return this.db.Employees.Where(b => b.Id == id)
                .ProjectTo<EmployeeFullDetailsModel>().FirstOrDefault();
        }

        public async Task<IEnumerable<Employee>> EmployeesInCompany(int Id) =>
            await this.db
           .Employees
           .Where(c => c.CompanyId == Id)
           .ToListAsync<Employee>();
    }
}
