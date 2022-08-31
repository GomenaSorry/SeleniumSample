using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SeleniumSample.Configuration;

namespace SeleniumSample.Interfaces
{
    public interface IConfig
    {
        BrowserType GetBrowser();
        string GetUserName();
        string GetPassword();
        string GetWebsite();
        int GetPageLoadTimeOut();
        int GetElementLoadTimeOut();

        // demo

        string GetDemoWebsite();
    }
}
