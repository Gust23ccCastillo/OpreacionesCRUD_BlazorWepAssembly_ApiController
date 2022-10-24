using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpreacionesCRUD_BlazorWepAssembly_ApiController.Shared
{
    public class LoginRequest
    {
        public string? UserName { get; set; }
        public string? Password { get; set; }
    }
}
