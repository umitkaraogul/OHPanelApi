using OHPanelApi;
using OHPanelApi.Panels.Maestro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OhPanelConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            IPanelApi panel = new MaestroPanel("1_b5b745bead7648e782aef88b70cce85a", "http://demo.maestropanel.net:9715/Api/v1");

            //Domain newDomain = new Domain();

            //newDomain.Name = "demo504.com";
            //newDomain.PlanAlias = "Test";
            //newDomain.UserName = "demo504.com";
            //newDomain.Password = "kr3m@12!";
            //newDomain.ActiveDomainUser = true;
            //newDomain.FirstName = "Demo504";
            //newDomain.LastName = "Customer504";
            //newDomain.Email = "demo504@customer.com";

            //panel.DomainCreate(newDomain);

            //panel.GetDomainList();


        }
    }
}
