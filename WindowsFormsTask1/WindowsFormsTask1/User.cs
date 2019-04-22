using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq.Mapping;

namespace WindowsFormsTask1
{
    [Table(Name = "Users")]
    public class User
    {
        [Column(IsPrimaryKey = true, IsDbGenerated = true)]
        public int id { get; set; }
        [Column]
        public string Name;
        [Column]
        public string Surname;
        [Column]
        public int Age;
        [Column(Name = "RegistrationDate")]
        public DateTime RDate;
        [Column(Name = "PhoneNumber")]
        public ulong PhNum;
        [Column]
        public string Country;
        [Column]
        public string Town;
        [Column(Name = "Manager")]
        public int ManagerId;
        [Column]
        public int Sum;
        public string GetCell(int i)
        {
            string res = "";
            switch (i)
            {
                case 0:
                    res = id.ToString();
                    break;
                case 1:
                    res = Name;
                    break;
                case 2:
                    res = Surname;
                    break;
                case 3:
                    res = Age.ToString();
                    break;
                case 4:
                    res = RDate.Date.ToShortDateString();
                    break;
                case 5:
                    res = PhNum.ToString();
                    break;
                case 6:
                    res = Country;
                    break;
                case 7:
                    res = Town;
                    break;
                case 8:
                    res = ManagerId.ToString();
                    break;
                case 9:
                    res = Sum.ToString();
                    break;
            }


            return res;
        }
    }
}
