using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
namespace LolProjectMobile2
{
    public class Skills
    {
        [PrimaryKey]
        public string NameSkills { get; set; }

        public string Opisanie { get; set; }
        public byte[] ImageSkill { get; set; }
        public int ID { get; set; }
    }
}
