using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CartInsta.Data;
using CartInsta.Models;

namespace CartInsta.Pages.Users
{
    public class DetailsModel : PageModel
    {
        private readonly CartInsta.Data.ShoppingContext _context;

        public DetailsModel(CartInsta.Data.ShoppingContext context)
        {
            _context = context;
        }

        public User Users { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Users = await _context.Users.FirstOrDefaultAsync(m => m.UserID == id);

            if (User == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
