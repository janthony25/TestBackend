using Microsoft.AspNetCore.Mvc;
using TestBackend.Data;
using System.Collections.Generic;
using System.Linq;
using TestBackend.Models;
using Microsoft.EntityFrameworkCore;

namespace TestBackend.Controllers
{
    public class CustomerListController : Controller
    {
        private readonly ApplicationDbContext _db;

        private DbSet<tblCustomerList> CustomerListEntity;
        public CustomerListController(ApplicationDbContext db)
        {
            _db = db;
            CustomerListEntity = db.Set<tblCustomerList>();
            
        }

        
        public IActionResult Index()
        {
            var customerList = from tblCustomerList select tblCustomerList.
                               
            

            return View(customerList);
        }
    }
}
