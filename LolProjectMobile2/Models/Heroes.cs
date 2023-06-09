using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
namespace LolProjectMobile2
{
    [Table("Heroes")]
    public class Heroes
    {
        [PrimaryKey]
        public string NameHero { get; set; }
        
        
        public byte[] ImageHero { get; set; }
        
        
        public byte[] ImageHeroIcon { get; set; }   
        

      
    }
}
