using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using SQLite;
namespace LolProjectMobile2
{
    public class LOLPROJECTRepository
    {
       /* private readonly SQLiteConnection _database;

        public static string DbPath { get; } = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "LOLPROJECT20.db");

        public LOLPROJECTRepository()
        {
            _database = new SQLiteConnection(DbPath);
            _database.CreateTable<Appeals>();
        }

        public List<Appeals> List()
        {
            return _database.Table<Appeals>().ToList();
        } */
         SQLiteConnection database;
        public LOLPROJECTRepository(string DbPath)
          {
              database = new SQLiteConnection(DbPath);
              database.CreateTable<Appeals>();
              database.CreateTable<Heroes>();
              database.CreateTable<BaseScales>();
              database.CreateTable<Scales>();
              database.CreateTable<Skills>();
              database.CreateTable<Skill_Hero>();
              database.CreateTable<Items>();
          }
          
          public List<Heroes> GetItemsHeroes()
          {
              return database.Table<Heroes>().ToList();
          } 
          
          public List<Appeals> GetItemsAppeal()
          {
              return database.Table<Appeals>().ToList();
          }
        public List<BaseScales> GetItemsBaseScales()
        {
            return database.Table<BaseScales>().ToList();
        }
        public List<Scales> GetItemsScales()
        {
            return database.Table<Scales>().ToList();
        }
        public List<Items> GetItemsItems()
        {
            return database.Table<Items>().ToList();
        }
        public int DeleteItem(int id)
        {
            return database.Delete<Items>(id);
        }
        public int SaveItemItems(Items item)
        {
            if (item.Id != 0)
            {
                database.Update(item);
                return item.Id;
            }
            else
            {
                return database.Insert(item);
            }
        }
        public List<Items> SearchItem(string search)
        {
            return database.Table<Items>().Where(p=>p.ItemName.Contains(search)).ToList();
        }
        public Items GetItemItems(string id)
        {
            return database.Get<Items>(id);
        }
        public List<ItemsDifferents> GetItemsItemsDifferents()
        {
            return database.Table<ItemsDifferents>().ToList();
        }
        public List<Items_Difference> GetItemsItems_Difference()
        {
            return database.Table<Items_Difference>().ToList();
        }
        public List<Polzovatel> GetItemsPolzovatel()
        {
            return database.Table<Polzovatel>().ToList();
        }
        public int SaveItemPolzovatel(Polzovatel item)
        {
            return database.Insert(item);
        }
        public List<Roles> GetItemsRoles()
        {
            return database.Table<Roles>().ToList();
        }
        public List<Skills> GetItemsSkills()
        {
            return database.Table<Skills>().ToList();
        }
        public List<Skill_Hero> GetItemsSkill_Hero()
        {
            return database.Table<Skill_Hero>().ToList();
        }
        public int SaveItemAppeal(Appeals item)
        {
            if (item.Id != 0)
            {
                database.Update(item);
                return item.Id;
            }
            else
            {
                return database.Insert(item);
            }
        }
        public Appeals GetItemAppeal(string id)
        {
            return database.Get<Appeals>(id);
        }
    }
}
