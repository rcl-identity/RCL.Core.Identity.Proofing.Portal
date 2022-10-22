﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RCL.Core.Identity.Proofing.Portal.Pages
{
    [Authorize]
    public class IndexModel : PageModel
    {
        public IndexModel()
        {
        }

        public IActionResult OnGet()
        {
            return RedirectToPage("/IdentityApprover/Details", new { area = "IdentityProofing" });
        }
    }
}