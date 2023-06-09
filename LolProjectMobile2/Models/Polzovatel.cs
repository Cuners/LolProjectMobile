using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
namespace LolProjectMobile2
{
    [Table("Polzovatel")]
    public class Polzovatel
    {
        [PrimaryKey]
        public string Login { get; set; }

        public string Password { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Email { get; set; }
        public int IdRole { get; set; }
    }
}
