using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SeleniumSample.Settings;

namespace SeleniumSample.ComponentHelper
{
    public class NavigationHelper
    {
        public static void NavigateUrl(string Url)
        {
            ObjectRepository.Driver.Navigate().GoToUrl(Url);
        }

    }
}
