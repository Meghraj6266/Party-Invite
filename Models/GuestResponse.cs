using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using PartyInvite.Models;

namespace PartyInvite.Models
{
    public class GuestResponse
    {
        public string? Name { get; set; }
        public string? Email { get; set; }

        public string? Phone { get; set; }
        public bool? WillAttend { get; set; }

    }
}