using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
namespace LolProjectMobile2
{
    [Table("Items")]
    public class Items
    {
        public string ItemName { get; set; }
        public byte[] ImageItem { get; set; }
        public Nullable<int> AD { get; set; }
        public Nullable<int> Crit { get; set; }
        public Nullable<int> AP { get; set; }
        public Nullable<int> Attack_speed { get; set; }
        public Nullable<int> Movement { get; set; }
        public Nullable<int> Armor { get; set; }
        public Nullable<int> HP { get; set; }
        public string Modificators { get; set; }

        [PrimaryKey,AutoIncrement]
        public int Id { get; set; }
    }
}
