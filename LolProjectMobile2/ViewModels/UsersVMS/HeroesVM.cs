using System;
using System.Collections.Generic;
using System.Text;

namespace LolProjectMobile2
{
    public class HeroesVM :ViewModel
    {
        private string _nameHero;
        public string NameHero
        {
            get { return _nameHero; }
            set=> Set(ref _nameHero, value);
        }
       
        private string _Level;
        public string Level
        {
            get { return _Level; }
            set
            {
                _Level = value;
                foreach (var basescales in BaseScales2)
                {
                    foreach (var scales in Scales2)
                    {
                        AD = basescales.AD + scales.Damage * Convert.ToDouble(Level);
                        Armor = basescales.Armor + scales.Armor * Convert.ToDouble(Level);
                        Health = basescales.Health + scales.Health * Convert.ToDouble(Level);
                        Mana = basescales.Mana + scales.Mana * Convert.ToDouble(Level);
                        
                    }
                }

                OnPropertyChanged("Level");
            }
        }
        private byte[] _imageHero;
        public byte[] ImageHero
        {
            get { return _imageHero; }
            set=>Set(ref _imageHero, value);
        }
        private byte[] _imageSkill1;
        public byte[] ImageSkill1
        {
            get { return _imageSkill1; }
            set => Set(ref _imageSkill1, value);
        }
        private byte[] _imageSkill2;
        public byte[] ImageSkill2
        {
            get { return _imageSkill2; }
            set => Set(ref _imageSkill2, value);
        }
        private byte[] _imageSkill3;
        public byte[] ImageSkill3
        {
            get { return _imageSkill3; }
            set => Set(ref _imageSkill3, value);
        }
        private byte[] _imageSkill4;
        public byte[] ImageSkill4
        {
            get { return _imageSkill4; }
            set => Set(ref _imageSkill4, value);
        }
        private string _opisanie;
        public string Opisanie
        {
            get { return _opisanie;}
            set=>Set(ref _opisanie, value);
        }
        private string _opisanie2;
        public string Opisanie2
        {
            get { return _opisanie2; }
            set => Set(ref _opisanie2, value);
        }
        private string _opisanie3;
        public string Opisanie3
        {
            get { return _opisanie3; }
            set => Set(ref _opisanie3, value);
        }
        private string _opisanie4;
        public string Opisanie4
        {
            get { return _opisanie4; }
            set => Set(ref _opisanie4, value);
        }
        private Nullable<double> _Health=0;
        public Nullable<double> Health
        {
            get { return _Health; }
            set => Set(ref _Health, value);
        }
        private Nullable<double> _Armor=0;
        public Nullable<double> Armor
        {
            get { return _Armor; }
            set => Set(ref _Armor, value);
        }
        private Nullable<double> _Mana=0;
        public Nullable<double> Mana
        {
            get { return _Mana; }
            set => Set(ref _Mana, value);
        }
        private Nullable<double> _AD=0;
        public Nullable<double> AD
        {
            get { return _AD; }
            set => Set(ref _AD, value);
        }
        private Nullable<double> _ResistMagic = 0;
        public Nullable<double> ResistMagic
        {
            get { return _ResistMagic; }
            set => Set(ref _ResistMagic, value);
        }
        private Nullable<double> _Crit=0;
        public Nullable<double> Crit
        {
            get { return _Crit; }
            set => Set(ref _Crit, value);
        }
        private Nullable<double> _MoveSpeed=0;
        public Nullable<double> MoveSpeed
        {
            get { return _MoveSpeed; }
            set => Set(ref _MoveSpeed, value);
        }
        private Nullable<double> _Attack_speed=0;
        public Nullable<double> Attack_speed
        {
            get { return _Attack_speed; }
            set => Set(ref _Attack_speed, value);
        }
        private List<Skills> skills2;
        public List<Skills> Skills2
        {
            get { return skills2; }
            set=>Set(ref skills2, value);
        }
        public List<Skills> Skills { get; set; }
        
        private List<Skill_Hero> skill_Heroes;
        public List<Skill_Hero> Skill_Heroes
        {
            get { return skill_Heroes; }
            set => Set(ref skill_Heroes, value);
        }
        public List<Scales> Scales { get; set; }
        public List<Scales> Scales2 { get; set; }
        public List<BaseScales> BaseScales { get; set; }
        public List<BaseScales> BaseScales2 { get; set; }
        public HeroesVM()
        {
            Skills2 = new List<Skills>();
        }
        public HeroesVM(Heroes heroes)
        {
            
            _nameHero = heroes.NameHero;
            _imageHero = heroes.ImageHero;
            Skills = App.Database.GetItemsSkills();
            Skill_Heroes = App.Database.GetItemsSkill_Hero();
            Scales=App.Database.GetItemsScales();
            BaseScales=App.Database.GetItemsBaseScales();
            Skills2 = new List<Skills>();
            Scales2=new List<Scales>();
            BaseScales2=new List<BaseScales>();
            int i = 0;
            foreach(Skill_Hero skillhero in Skill_Heroes)
            {
                if (skillhero.NameHero == _nameHero)
                {
                    foreach(Skills skills in Skills)
                    {
                        if (skillhero.Nameskill == skills.NameSkills)
                        {
                            Skills2.Add(skills);
                            
                        }
                    }
                }
            }
            foreach(Skills skill in Skills2)
            {
                if (i == 0)
                {
                    _imageSkill1 = skill.ImageSkill;
                    _opisanie = skill.Opisanie;
                    i++;
                }
                else if (i == 1)
                {
                    _imageSkill2=skill.ImageSkill;
                    _opisanie2=skill.Opisanie;
                    i++;
                }
                else if (i == 2)
                {
                    _imageSkill3 = skill.ImageSkill;
                    _opisanie3=skill.Opisanie;
                    i++;
                }
                else if(i == 3)
                {
                    _imageSkill4=skill.ImageSkill;
                    _opisanie4=skill.Opisanie;
                    i++;
                }
            }
            foreach(Scales scales in Scales)
            {
                if (scales.NameHero == _nameHero)
                {
                    Scales2.Add(scales);
                }
            }
            foreach(BaseScales basescales in BaseScales)
            {
                if(basescales.NameHero == _nameHero)
                {
                    BaseScales2.Add(basescales);
                    AD=basescales.AD;
                    Armor=basescales.Armor;
                    Mana=basescales.Mana;
                    Health=basescales.Health;
                    Crit=basescales.Crit;
                    MoveSpeed=basescales.MoveSpeed;
                    Attack_speed = basescales.Speed_Attack;
                }
            }
        }
        private MainListVM _mainListVM;
        public MainListVM MainListVM
        {
            get { return _mainListVM; }
            set=>Set(ref _mainListVM, value);
        }
    }
}
