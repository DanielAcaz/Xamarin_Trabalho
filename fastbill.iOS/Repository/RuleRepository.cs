using System;
using fastbill.Repository;
using Xamarin.Forms;
using System.IO;
using fastbill.iOS.Repository;

[assembly:Dependency(typeof(RuleRepository))]
namespace fastbill.iOS.Repository
{
    public class RuleRepository : ConnectionFactory
    {
        public string getRule(string dataBaseName)
        {
            string rule = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
            string library = Path.Combine(rule, "..", "Library");
            string database = Path.Combine(library, dataBaseName);
            return database;
        }
    }
}
