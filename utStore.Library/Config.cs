using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Collections;
using System.Collections.Specialized;
using System.Diagnostics;

namespace utStore.Library
{
    public class Config
    {
        public string Get(string variable)
        {
            try
            {
                return ConfigurationManager.AppSettings[variable].ToString().Trim();
            } 
            catch(Exception e){
                Trace.WriteLine(e.Message);
            }
            return String.Empty;
        }

        public string GetConnectionString(string name)
        {
            return ConfigurationManager.ConnectionStrings[name].ToString().Trim();
        }

    }
}


