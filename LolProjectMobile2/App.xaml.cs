using System;
using System.IO;
using System.Reflection;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LolProjectMobile2
{
    public partial class App : Application
    {

         public static LOLPROJECTRepository database;
         public static LOLPROJECTRepository Database
         {
             get
             {
                 if (database == null)
                 {
                     // путь, по которому будет находиться база данных
                     string dbPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "LOLPROJECT20.db");
                     // если база данных не существует (еще не скопирована)
                     if (!File.Exists(dbPath))
                     {
                         // получаем текущую сборку
                         var assembly = IntrospectionExtensions.GetTypeInfo(typeof(App)).Assembly;
                         // берем из нее ресурс базы данных и создаем из него поток
                         using (Stream stream = assembly.GetManifestResourceStream("LolProjectMobile2.LOLPROJECT20.db"))
                         {
                             using (FileStream fs = new FileStream(dbPath, FileMode.OpenOrCreate))
                             {
                                 stream.CopyTo(fs);  // копируем файл базы данных в нужное нам место
                                 fs.Flush();
                             }
                         }
                     }
                     database = new LOLPROJECTRepository(dbPath);
                 }
                 return database;
             }
         }  
       
       


        public App()
        {
            InitializeComponent();
            MainPage= new MainPage(); 
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
