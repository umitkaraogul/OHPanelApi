using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OHPanelApi;
using System.Collections.Generic;

namespace OHPanelUnitTest
{
    [TestClass]
    public class MaestroPanelTest
    {
        IPanelApi panel;
        public MaestroPanelTest()
        {
            panel = new MaestroPanel("1_b5b745bead7648e782aef88b70cce85a", "http://demo.maestropanel.net:9715/Api/v1");
        }

        [TestMethod]
        public void DomainCreate()
        {
            Domain newDomain = new Domain();

            newDomain.Name = "domainiptest.com";
            newDomain.PlanAlias = "Test";
            newDomain.UserName = "domainiptest.com";
            newDomain.Password = "kr3m@12!";
            newDomain.ActiveDomainUser = true;
            newDomain.FirstName = "domainiptest";
            newDomain.LastName = "domainiptes";
            newDomain.Email = "domainiptes@customer.com";

            PanelResult result = panel.DomainCreate(newDomain);

            //TODO:Error kodun kontrol edilmesi daha uygun olacaktır.
            Assert.AreEqual(200, result.Code);

        }

        [TestMethod]
        public void AddDomainAlias()
        {
            string name = "test.com";
            string alias = "blog.com";

            PanelResult result = panel.AddDomainAlias(name, alias);

            Assert.AreEqual(200, result.Code);

        }

        [TestMethod]
        public void GetDomainAliases()
        {
            string name = "demo11.com";

            PanelResult result = panel.GetDomainAliases(name);

            Assert.AreEqual(200, result.Code);
        }

        [TestMethod]
        public void AddSubDomain()
        {
            string name = "demo11.com";
            string subDomain = "demo12";
            string ftpUser = "demo11.com";

            PanelResult result = panel.AddSubDomain(name, subDomain, ftpUser);

            Assert.AreEqual(200, result.Code);
        }

        [TestMethod]
        public void DeleteSubDomain()
        {
            string name = "ozgurmazlum.com";
            string subDomain = "demo21";

            PanelResult result = panel.DeleteSubDomain(name, subDomain);

            Assert.AreEqual(200, result.Code);
        }


        [TestMethod]
        public void ChangeIpAddr()
        {
            string name = "domainiptes.com";
            string newIp = "193.192.122.67";

            PanelResult result = panel.ChangeIpAddr(name, newIp);

            Assert.AreEqual(200, result.Code);
        }

        [TestMethod]
        public void GetDomainList()
        {

            PanelResult result = panel.GetDomainList();

            Assert.AreEqual(200, result.Code);
        }

        [TestMethod]
        public void GetDomainListItem()
        {
            string name = "ozgurmazlum.com";
            PanelResult result = panel.GetDomainListItem(name);

            Assert.AreEqual(200, result.Code);
        }

        [TestMethod]
        public void DomainGetLimits()
        {
            string name = "ozgurmazlum.com";
            PanelResult result = panel.DomainGetLimits(name);

            Assert.AreEqual(200, result.Code);
        }

        [TestMethod]
        public void DomainForwarding()
        {

            DomainForward forward = new DomainForward();
            forward.Name = "ozgurmazlum.com";
            forward.Enabled = true;
            forward.Destination = "http://www.maestropanel.com";
            forward.StatusCode = "Found";
            PanelResult result = panel.DomainForwarding(forward);


            Assert.AreEqual(200, result.Code);
        }

        [TestMethod]
        public void DomainChangeReseller()
        {
            string name = "domainiptes.com";
            string resellerName = "bayi_test";

            PanelResult result = panel.DomainChangeReseller(name, resellerName);


            Assert.AreEqual(200, result.Code);
        }

        [TestMethod]
        public void DomainSetWriteAccess()
        {
            string name = "demodemo.com";
            string path = @"http\";

            PanelResult result = panel.DomainSetWriteAccess(name, path);


            Assert.AreEqual(200, result.Code);
        }

        [TestMethod]
        public void DomainRevokeWriteAccess()
        {
            string name = "demodemo.com";
            string path = @"http\";

            PanelResult result = panel.DomainRevokeWriteAccess(name, path);


            Assert.AreEqual(200, result.Code);
        }

        [TestMethod]
        public void DomainCreateDirectory()
        {
            string name = "demodemo.com";
            string path = @"http\newDirectory";

            PanelResult result = panel.DomainCreateDirectory(name, path);


            Assert.AreEqual(200, result.Code);
        }

        [TestMethod]
        public void DomainGetItems()
        {
            string name = "demodemo.com";
            string path = "http";

            PanelResult result = panel.DomainGetItems(name, path);


            Assert.AreEqual(200, result.Code);
        }

        [TestMethod]
        public void DomainDeleteItems()
        {
            string name = "demodemo.com";

            List<string> items = new List<string>();
            items.Add(@"http\newDirectory");

            PanelResult result = panel.DomainDeleteItems(name, items);


            Assert.AreEqual(200, result.Code);
        }

        [TestMethod]
        public void DomainZipItem()
        {
            string name = "demodemo.com";
            string zipPath = @"http\backup.zip";

            List<string> items = new List<string>();
            items.Add(@"http\index.html");

            PanelResult result = panel.DomainZipItem(name, zipPath, items);


            Assert.AreEqual(200, result.Code);
        }

        [TestMethod]
        public void DomainProtectStatsArea()
        {
            string name = "ozgurmazlum.com";
            string username = "admin";
            string password = "admin";

            PanelResult result = panel.DomainProtectStatsArea(name, username, password);


            Assert.AreEqual(200, result.Code);
        }

        [TestMethod]
        public void DomainUnProtectStatsArea()
        {
            string name = "ozgurmazlum.com";


            PanelResult result = panel.DomainUnProtectStatsArea(name);


            Assert.AreEqual(200, result.Code);
        }

        [TestMethod]
        public void DomainEnableStatsProtection()
        {
            string name = "ozgurmazlum.com";


            PanelResult result = panel.DomainEnableStatsProtection(name);


            Assert.AreEqual(200, result.Code);
        }

        [TestMethod]
        public void DomainSetFtpUserStatsArea()
        {
            string name = "ozgurmazlum.com";
            string ftpUser = "ozgurmazlum.com";

            PanelResult result = panel.DomainSetFtpUserStatsArea(name, ftpUser);


            Assert.AreEqual(200, result.Code);
        }


        [TestMethod]
        public void DomainAddMailBox()
        {
            DomainMailBox mailBox = new DomainMailBox();
            mailBox.Name = "xyz.com";
            mailBox.Account = "info";
            mailBox.Password = "info";
            mailBox.Quota = 5;

            PanelResult result = panel.DomainAddMailBox(mailBox);


            Assert.AreEqual(200, result.Code);
        }
        [TestMethod]
        public void DomainDeleteMailBox()
        {
            string name = "ozgurmazlum.com";
            string account = "info";

            PanelResult result = panel.DomainDeleteMailBox(name, account);


            Assert.AreEqual(200, result.Code);
        }

        [TestMethod]
        public void DomainChangeMailBoxQuota()
        {
            string name = "ozgurmazlum.com";
            string account = "info";
            int quota = 5;

            PanelResult result = panel.DomainChangeMailBoxQuota(name, account, quota);


            Assert.AreEqual(200, result.Code);
        }
        [TestMethod]
        public void DomainGetMailList()
        {
            string name = "ozgurmazlum.com";

            PanelResult result = panel.DomainGetMailList(name);


            Assert.AreEqual(200, result.Code);
        }

        [TestMethod]
        public void DomainAddDatabase()
        {
            Database db = new Database();
            db.Name = "ozgurmazlum.com";
            db.DbType = "mssql";
            db.Database_ = "ozgur_test";
            db.Users.Add(new DatabaseUser() { Username = "test", Password = "test" });
            db.Quota = 12;


            PanelResult result = panel.DomainAddDatabase(db);


            Assert.AreEqual(200, result.Code);
        }

        [TestMethod]
        public void DomainDeleteDatabase()
        {
            string name = "ozgurmazlum.com";
            string dbType = "mssql";
            string database = "ozgur_test";


            PanelResult result = panel.DomainDeleteDatabase(name, dbType, database);


            Assert.AreEqual(200, result.Code);
        }

        [TestMethod]
        public void DomainAddFtpAccount()
        {
            FtpAccount ftpAccount = new FtpAccount();

            ftpAccount.Name = "ozgurmazlum.com";
            ftpAccount.Account = "ftpTest";
            ftpAccount.Password = "ftpTest";
            ftpAccount.HomePath = "/veritabani";
            ftpAccount.Ronly = false;


            PanelResult result = panel.DomainAddFtpAccount(ftpAccount);


            Assert.AreEqual(200, result.Code);
        }

        [TestMethod]
        public void DomainDeleteFtpAccount()
        {
            FtpAccount ftpAccount = new FtpAccount();

            string name = "ozgurmazlum.com";
            string account = "ftpTest";


            PanelResult result = panel.DomainDeleteFtpAccount(name, account);


            Assert.AreEqual(200, result.Code);
        }
        [TestMethod]
        public void DomainChangeFtpPassword()
        {
            FtpAccount ftpAccount = new FtpAccount();

            string name = "ozgurmazlum.com";
            string account = "ftpTest";
            string newPassword = "NewP4s5!";


            PanelResult result = panel.DomainChangeFtpPassword(name, account,newPassword);


            Assert.AreEqual(200, result.Code);
        }

        [TestMethod]
        public void DomainSetDnsZone()
        {
            DnsZone dnsZone = new DnsZone();
            dnsZone.Name = "demodemo.com";

            PanelResult result = panel.DomainSetDnsZone(dnsZone);


            Assert.AreEqual(200, result.Code);
        }

        [TestMethod]
        public void ResellerSetLimits()
        {
            DomainLimit limit = new DomainLimit();
            limit.ResellerName = "bayi_test";
            limit.MaxDomain = 12;

            PanelResult result = panel.ResellerSetLimits(limit);


            Assert.AreEqual(200, result.Code);
        }

        [TestMethod]
        public void Reseller()
        {
            DomainLimit limit = new DomainLimit();
            limit.ResellerName = "bayi_test";
            limit.MaxDomain = 12;

           //// PanelResult result = panel.geti


           // Assert.AreEqual(200, result.Code);
        }
    }
}
