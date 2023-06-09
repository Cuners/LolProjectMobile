using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
namespace LolProjectMobile2
{
    [Table("Appeal")]
    public class Appeals
    {
        public string Tema { get; set; }
        [MaxLength(2147483647)]
        public string Opisanie { get; set; }
        [MaxLength(2147483647)]
        public string Status { get; set; }
        [MaxLength(2147483647)]
        public string User_login { get; set; }
        [MaxLength(2147483647)] 
        public string Otvet { get; set; }
        [PrimaryKey, AutoIncrement, Column("ID")]
        public int Id { get; set; }

        public string AdminLogin { get; set; }
        
    }
}
