using System;
using Xamarin.Forms;
using fastbill.Repository;
using System.IO;
using fastbill.Droid.Repository;

[assembly:Dependency(typeof(RuleRepository))]
namespace fastbill.Droid.Repository
{
    public class RuleRepository : ConnectionFactory
    {
        public string getRule(string dataBaseName){
            string rule = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
            string database = Path.Combine(rule, dataBaseName);
            return database;
        }
    }
}
