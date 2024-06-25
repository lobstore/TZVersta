using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TZVersta.Data;
using TZVersta.Models;

namespace TZVersta.Controllers
{
    public class OrdersController : Controller
    {
        private readonly ApplicationDbContext _context;
        public OrdersController(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            return View(await _context.Orders.ToListAsync());
        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var order = await _context.Orders
                .FirstOrDefaultAsync(m => m.Id == id);
            if (order == null)
            {
                return NotFound();
            }

            return View(order);
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("SenderCity,SenderAddress,RecipientCity,RecipientAddress,Weight,PickupDate")] Order order)
        {
            if (ModelState.IsValid)
            {
                order.OrderNumber = Guid.NewGuid().ToString();
                order.PickupDate = order.PickupDate.ToUniversalTime();
                _context.Add(order);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(order);
        }

    }
}
