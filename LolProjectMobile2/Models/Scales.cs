using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
namespace LolProjectMobile2
{
    [Table("Scales")]
    public class Scales
    {
        public string NameHero { get; set; }
        public Nullable<double> Damage { get; set; }
        public Nullable<double> Armor { get; set; }

        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        public Nullable<double> Health { get; set; }
        public Nullable<double> Mana { get; set; }
        public Nullable<double> ResistMagic { get; set; }
    }
}
