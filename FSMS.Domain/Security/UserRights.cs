using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FSMS.Domain
{
    public class UserRights
    {
        public int Id { get; set; }
        public int menuId { get; set; }
        public int userId { get; set; }
        public string MenuRightString { get; set; }
    }
}
