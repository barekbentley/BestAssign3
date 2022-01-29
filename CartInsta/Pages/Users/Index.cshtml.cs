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
    public class IndexModel : PageModel
    {
        private readonly CartInsta.Data.ShoppingContext _context;

        public IndexModel(CartInsta.Data.ShoppingContext context)
        {
            _context = context;
        }

        public IList<User> Users { get;set; }

        public async Task OnGetAsync()
        {
            Users = await _context.Users.ToListAsync();
        }
    }
}
