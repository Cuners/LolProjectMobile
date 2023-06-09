using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
namespace LolProjectMobile2
{
    [Table("Skill_Hero")]
    public class Skill_Hero
    {
        public string Nameskill { get; set; }
        public string NameHero { get; set; }

        [PrimaryKey,AutoIncrement]
        public int Id { get; set; }
    }
}
