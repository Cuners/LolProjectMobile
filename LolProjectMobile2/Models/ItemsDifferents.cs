using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
namespace LolProjectMobile2
{
    [Table("ItemsDifferents")]
    public class ItemsDifferents
    {
        public string ItemsDiff { get; set; }

        [PrimaryKey,AutoIncrement]
        public int Id { get; set; }
    }
}
