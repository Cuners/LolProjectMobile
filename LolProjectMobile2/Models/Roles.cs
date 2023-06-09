using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
namespace LolProjectMobile2
{
    [Table("Roles")]
    public class Roles
    {
        public string Role { get; set; }

        [PrimaryKey]
        public int Id { get; set; }
    }
}
