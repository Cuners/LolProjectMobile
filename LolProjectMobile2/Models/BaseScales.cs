using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
namespace LolProjectMobile2
{
    [Table("BaseScales")]
    public class BaseScales
    {
        public string NameHero { get; set; }
        public Nullable<double> Health { get; set; }
        public Nullable<double> Armor { get; set; }
        public Nullable<double> Mana { get; set; }
        public Nullable<double> AD { get; set; }
        public Nullable<double> Crit { get; set; }
        public Nullable<double> MoveSpeed { get; set; }
        public Nullable<double> Speed_Attack { get; set; }

        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
    }
}
