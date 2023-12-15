using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotnetYuzuncuYil.Core
{
    public class UserProfile
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string NickName { get; set; }

        //Foreign Key
        public int UserId { get; set; }

        //Birebir İlişki 
        public User User { get; set; }
        public Team Team { get; set; }
    }
}
