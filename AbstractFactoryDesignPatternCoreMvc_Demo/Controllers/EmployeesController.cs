﻿using AbstractFactoryDesignPatternCoreMvc_Demo.Data;
using AbstractFactoryDesignPatternCoreMvc_Demo.Factory.AbstractFactory;
using AbstractFactoryDesignPatternCoreMvc_Demo.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace AbstractFactoryDesignPatternCoreMvc_Demo.Controllers
{
    public class EmployeesController : Controller
    {
        private readonly ApplicationDbContext db;

        public EmployeesController(ApplicationDbContext context)
        {
            db = context;
        }

        public async Task<IActionResult> Index()
        {
            var applicationDbContext = db.Employees.Include(e => e.Department).Include(e => e.EmployeeType);
            return View(await applicationDbContext.ToListAsync());
        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var employee = await db.Employees
                .Include(e => e.Department)
                .Include(e => e.EmployeeType)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (employee == null)
            {
                return NotFound();
            }

            return View(employee);
        }

        public IActionResult Create()
        {
            ViewData["DepartmentId"] = new SelectList(db.Departments, "Id", "DepartmentName");
            ViewData["EmployeeTypeId"] = new SelectList(db.EmployeeTypes, "Id", "EmployeeTypeName");
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Employee employee)
        {
            if (ModelState.IsValid)
            {
                IComputerFactory factory = new EmployeeSystemFactory().Create(employee);
                EmployeeSystemManager manager = new EmployeeSystemManager(factory);
                employee.ComputerDetails = manager.GetSystemDetails();
                db.Add(employee);
                await db.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["DepartmentId"] = new SelectList(db.Departments, "Id", "DepartmentName", employee.DepartmentId);
            ViewData["EmployeeTypeId"] = new SelectList(db.EmployeeTypes, "Id", "EmployeeTypeName", employee.EmployeeTypeId);
            return View(employee);
        }

        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var employee = await db.Employees.FindAsync(id);
            if (employee == null)
            {
                return NotFound();
            }
            ViewData["DepartmentId"] = new SelectList(db.Departments, "Id", "DepartmentName", employee.DepartmentId);
            ViewData["EmployeeTypeId"] = new SelectList(db.EmployeeTypes, "Id", "EmployeeTypeName", employee.EmployeeTypeId);
            return View(employee);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Employee employee)
        {
            if (id != employee.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    IComputerFactory factory = new EmployeeSystemFactory().Create(employee);
                    EmployeeSystemManager manager = new EmployeeSystemManager(factory);
                    employee.ComputerDetails = manager.GetSystemDetails();
                    db.Update(employee);
                    await db.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EmployeeExists(employee.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["DepartmentId"] = new SelectList(db.Departments, "Id", "DepartmentName", employee.DepartmentId);
            ViewData["EmployeeTypeId"] = new SelectList(db.EmployeeTypes, "Id", "EmployeeTypeName", employee.EmployeeTypeId);
            return View(employee);
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var employee = await db.Employees
                .Include(e => e.Department)
                .Include(e => e.EmployeeType)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (employee == null)
            {
                return NotFound();
            }

            return View(employee);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var employee = await db.Employees.FindAsync(id);
            db.Employees.Remove(employee);
            await db.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool EmployeeExists(int id)
        {
            return db.Employees.Any(e => e.Id == id);
        }
    }
}
