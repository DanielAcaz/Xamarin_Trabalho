using System;
namespace fastbill.Repository
{
    public interface ConnectionFactory
    {
        string getRule(string dataBaseName);   
    }

}
