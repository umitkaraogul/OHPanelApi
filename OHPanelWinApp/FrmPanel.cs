using OHPanelApi;
using OHPanelApi.Panels.Maestro;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OHPanelWinApp
{
    public partial class frmApi : Form
    {
        IPanelApi panel;
        public frmApi()
        {
            InitializeComponent();

            panel = new MaestroPanel("1_b5b745bead7648e782aef88b70cce85a", "http://demo.maestropanel.net:9715/Api/v1");
            bindingSourcePanelApi.DataSource = GetDomainInstance();
        }

        private void btnDomainAdd_Click(object sender, EventArgs e)
        {
            Domain domain = (Domain)bindingSourcePanelApi.Current;

            panel.DomainCreate(domain);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Domain domain = (Domain)bindingSourcePanelApi.Current;

            panel.DomainDelete(domain.Name);
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            Domain domain = (Domain)bindingSourcePanelApi.Current;

            panel.DomainStart(domain.Name);
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            Domain domain = (Domain)bindingSourcePanelApi.Current;

            panel.DomainStop(domain.Name);
        }

        private Domain GetDomainInstance()
        {
            Domain newDomain = new Domain();

            newDomain.Name = "demo505.com";
            newDomain.PlanAlias = "Test";
            newDomain.UserName = "demo505.com";
            newDomain.Password = "kr3m@12!";
            newDomain.ActiveDomainUser = true;
            newDomain.FirstName = "Demo505";
            newDomain.LastName = "Customer505";
            newDomain.Email = "demo505@customer.com";

            return newDomain;
        }

        private void buttonTest_Click(object sender, EventArgs e)
        {
            ApiResultList<SubdomainConfig> result;
            try
            {
                string json = txtTest.Text;
                result = JsonHelper<ApiResultList<SubdomainConfig>>.JsonDeserialize(json);
            }
            catch (Exception ex)
            {
                throw ex;
            }
          
        }

        private void btnResellerGetDomains_Click(object sender, EventArgs e)
        {
            panel.ResellerGetDomains("bayi_test");
        }

        private void btnResellerAddDomain_Click(object sender, EventArgs e)
        {
            Domain domain = (Domain)bindingSourcePanelApi.Current;
            domain.ResellerName = "bayi_test";

            panel.ResellerAddDomain(domain);
        }
    }

    
}
