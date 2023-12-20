using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotnetYuzuncuYil.Core.DTOs
{
    public class UserDto:BaseDto
    {
        public string UserName { get; set; }
        public string Email { get; set; }
    }
}
