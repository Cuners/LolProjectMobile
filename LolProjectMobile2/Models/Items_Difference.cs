using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace LolProjectMobile2
{
    [Table("Items_Difference")]
    public class Items_Difference
    {
        [PrimaryKey,AutoIncrement]
        public int ID { get; set; }

        public int Id_Item { get; set; }
       
        public int Id_Diff { get; set; }
    }
}
