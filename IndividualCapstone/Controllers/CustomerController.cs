using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using IndividualCapstone.Data;
using IndividualCapstone.Models;
using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;
using System.Net.Http;
using Newtonsoft.Json;




namespace IndividualCapstone.Controllers
{
    
    public class CustomerController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CustomerController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Customers
        public async Task<IActionResult> Index()
        {
            var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);

            var currentCustomer =await _context.Customers.Include(c => c.Account).Include(c => c.Address).Where(c => c.IdentityUserId == userId).ToListAsync();
            return View(currentCustomer);
        }

        // GET: Customers/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            ViewBag.mymap = "https://maps.googleapis.com/maps/api/js?key=" + APIs.Keys.mapsKey + "&callback=initMap";
            var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            var customerMap = _context.Customers.Include(c => c.Address)
                .Where(c => c.IdentityUserId == userId)
                .Select(c => c.Address).FirstOrDefault();
            ViewBag.CustomerLat = customerMap.Lat;
            ViewBag.CustomerLng = customerMap.Lng;

            if (id == null)
            {
                return NotFound();
            }

            var customer = await _context.Customers
                .Include(c => c.Account)
                .Include(c => c.Address)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (customer == null)
            {
                return NotFound();
            }

            return View(customer);
        }

        // GET: Customers/Create
        public IActionResult Create()
        {
            return View();
           
            //ViewData["AccountId"] = new SelectList(_context.Set<Account>(), "Id", "Id");
            //ViewData["AddressId"] = new SelectList(_context.Set<Address>(), "Id", "Id");
            //ViewData["IdentityUserId"] = new SelectList(_context.Users, "Id", "Id");
            //return View();
        }

        // POST: Customers/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Customer customer)
        {
            if (ModelState.IsValid)
            {

                // gets the ID of the logged in user
                var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
                customer.IdentityUserId = userId;
                HttpClient client = new HttpClient();

                _context.Add(customer);
                await _context.SaveChangesAsync();
                if (customer.Address.Lat == null || customer.Address.Lng == null)
                {
                    string location = customer.Address.Street + "+" + customer.Address.City + "+" + customer.Address.State + "+" +
                        customer.Address.ZipCode;
                    string url = "https://maps.googleapis.com/maps/api/geocode/json?address=" + location + "&key=" + APIs.Keys.mapsKey;
                    HttpResponseMessage response = await client.GetAsync(url);
                    string answer = await response.Content.ReadAsStringAsync();
                    if (response.IsSuccessStatusCode)
                    {
                        GeoCode GeoResult = JsonConvert.DeserializeObject<GeoCode>(answer);
                        var lat = GeoResult.results[0].geometry.location.lat;
                        var lng = GeoResult.results[0].geometry.location.lng;
                        customer.Address.Lat = lat;
                        customer.Address.Lng = lng;
                        _context.Update(customer.Address);


                    }
                    await _context.SaveChangesAsync();

                }
                

            }
            ViewData["AccountId"] = new SelectList(_context.Set<Account>(), "Id", "Id", customer.AccountId);
            ViewData["AddressId"] = new SelectList(_context.Set<Address>(), "Id", "Id", customer.AddressId);
            ViewData["IdentityUserId"] = new SelectList(_context.Users, "Id", "Id", customer.IdentityUserId);
            return View(customer);
        }

        // GET: Customers/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
           
            if (id == null)
            {
                return NotFound();
            }

            var customer = await _context.Customers.FindAsync(id);
            if (customer == null)
            {
                return NotFound();
            }
            ViewData["IdentityUserId"] = new SelectList(_context.Users, "Id", "Id", customer.IdentityUserId);
            ViewData["AccountId"] = new SelectList(_context.Set<Account>(), "Id", "Id", customer.AccountId);
            ViewData["AddressId"] = new SelectList(_context.Set<Address>(), "Id", "Id", customer.AddressId);
            return View(customer);
        }

        // POST: Customers/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditAsync( int? id, Customer customer)
        {

            if (id != customer.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {


                    _context.Update(customer);
                    await _context.SaveChangesAsync();

                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CustomerExists(customer.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
            }
            ViewData["IdentityUserId"] = new SelectList(_context.Users, "Id", "Id", customer.IdentityUserId);
            ViewData["AccountId"] = new SelectList(_context.Set<Account>(), "Id", "Id", customer.AccountId);
            ViewData["AddressId"] = new SelectList(_context.Set<Address>(), "Id", "Id", customer.AddressId);
            return View(customer);
        }

        // GET: Customers/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var customer = await _context.Customers
                .Include(c => c.Account)
                .Include(c => c.Address)
                .Include(c => c.IdentityUser)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (customer == null)
            {
                return NotFound();
            }

            return View(customer);
        }

        // POST: Customers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var customer = await _context.Customers.FindAsync(id);
            _context.Customers.Remove(customer);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CustomerExists(int id)
        {
            return _context.Customers.Any(e => e.Id == id);
        }
    }
}
