using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Asp.netCoreChineesDragon.Models;

namespace Asp.netCoreChineesDragon.Controllers
{
    public class OrderController : Controller
    {
        private readonly OrderContext _context;

        public OrderController(OrderContext context)
        {
            _context = context;
        }

        // GET: Order
        public async Task<IActionResult> Index()
        {
            return View(await _context.Orders.ToListAsync());
        }


        // GET: Order/Create
        public IActionResult AddOrEdit(int id = 0)
        {
            if (id == 0)
                return View(new Order());
            else
                return View(_context.Orders.Find(id));
        }

        // POST: Order/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddOrEdit([Bind("OrderId,ReferanceNumber,OrderedThrough,OrderType,OrderItems,OrderStatuses")] Order Order)
        {
            if (ModelState.IsValid)
            {
                Order.OrderDateTime = DateTime.UtcNow;
                if (Order.OrderId == 0)
                    _context.Add(Order);
                else
                    _context.Update(Order);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(Order);
        }


        // GET: Order/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            var Order =await _context.Orders.FindAsync(id);
            _context.Orders.Remove(Order);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }


    }
}
