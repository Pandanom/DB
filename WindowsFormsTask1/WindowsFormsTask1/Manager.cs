using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq.Mapping;

namespace WindowsFormsTask1
{
    [Table(Name = "Managers")]
    class Manager
    {
        [Column(IsPrimaryKey = true, IsDbGenerated = true)]
        public int id { get; set; }
        [Column]
        public string FullName;
        [Column]
        public string password;
        [Column]
        public string login;
        [Column]
        public bool isBlocked;
        [Column]
        public bool isAdmin;
        [Column]
        public int wrongTrys;
    }
}
