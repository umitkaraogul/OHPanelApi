using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OHPanelApi
{
    public class PleskPanel : IPanelApi
    {

        public PanelResult DomainCreate(Domain domain)
        {
            throw new NotImplementedException();
        }

        public PanelResult DomainDelete(string name)
        {
            throw new NotImplementedException();
        }

        public PanelResult DomainStop(string name)
        {
            throw new NotImplementedException();
        }

        public PanelResult DomainStart(string name)
        {
            throw new NotImplementedException();
        }

        public PanelResult DomainNewPassword(string name, string newPassword)
        {
            throw new NotImplementedException();
        }

        public PanelResult AddDomainAlias(string name, string alias)
        {
            throw new NotImplementedException();
        }

        public PanelResult DeleteDomainAlias(string name, string alias)
        {
            throw new NotImplementedException();
        }

        public PanelResult GetDomainAliases(string name)
        {
            throw new NotImplementedException();
        }

        public PanelResult AddSubDomain(string name, string subDomain, string ftpUser)
        {
            throw new NotImplementedException();
        }

        public PanelResult DeleteSubDomain(string name, string subDomain)
        {
            throw new NotImplementedException();
        }

        public PanelResult GetSubDomains(string name)
        {
            throw new NotImplementedException();
        }

        public PanelResult ChangeIpAddr(string name, string newIp)
        {
            throw new NotImplementedException();
        }

        public PanelResult GetDomainList()
        {
            throw new NotImplementedException();
        }

        public PanelResult GetDomainListItem(string name)
        {
            throw new NotImplementedException();
        }

        public PanelResult DomainGetLimits(string name)
        {
            throw new NotImplementedException();
        }

        public PanelResult DomainSetLimits(DomainLimit limit)
        {
            throw new NotImplementedException();
        }

        public PanelResult DomainForwarding(DomainForward forward)
        {
            throw new NotImplementedException();
        }

        public PanelResult DomainChangeReseller(string name, string resellerName)
        {
            throw new NotImplementedException();
        }

        public PanelResult SetDomainPlan(string name, string planAlias)
        {
            throw new NotImplementedException();
        }

        public PanelResult DomainSetWriteAccess(string name, string path)
        {
            throw new NotImplementedException();
        }

        public PanelResult DomainRevokeWriteAccess(string name, string path)
        {
            throw new NotImplementedException();
        }

        public PanelResult DomainCreateDirectory(string name, string path)
        {
            throw new NotImplementedException();
        }

        public PanelResult DomainGetItems(string name, string path)
        {
            throw new NotImplementedException();
        }

        public PanelResult DomainDeleteItems(string name, List<string> items)
        {
            throw new NotImplementedException();
        }

        public PanelResult DomainZipItem(string name, string zipFilePath, List<string> items)
        {
            throw new NotImplementedException();
        }

        public PanelResult DomainUnZipItem(string name, string zipFilePath, string extractPath)
        {
            throw new NotImplementedException();
        }

        public PanelResult DomainProtectStatsArea(string name, string userName, string password)
        {
            throw new NotImplementedException();
        }

        public PanelResult DomainUnProtectStatsArea(string name)
        {
            throw new NotImplementedException();
        }

        public PanelResult DomainEnableStatsProtection(string name)
        {
            throw new NotImplementedException();
        }

        public PanelResult DomainDisableStatsProtection(string name)
        {
            throw new NotImplementedException();
        }

        public PanelResult DomainSetFtpUserStatsArea(string name, string ftpuser)
        {
            throw new NotImplementedException();
        }

        public PanelResult DomainAddMailBox(DomainMailBox mailBox)
        {
            throw new NotImplementedException();
        }

        public PanelResult DomainDeleteMailBox(string name, string account)
        {
            throw new NotImplementedException();
        }

        public PanelResult DomainChangeMailBoxQuota(string name, string account, int quota)
        {
            throw new NotImplementedException();
        }

        public PanelResult DomainChangeMailBoxPassword(string name, string account, string newpassword)
        {
            throw new NotImplementedException();
        }

        public PanelResult DomainGetMailList(string name)
        {
            throw new NotImplementedException();
        }

        public PanelResult DomainAddDatabase(Database database)
        {
            throw new NotImplementedException();
        }

        public PanelResult DomainDeleteDatabase(string name, string dbType, string database)
        {
            throw new NotImplementedException();
        }

        public PanelResult DomainAddDatabaseUser(Database database)
        {
            throw new NotImplementedException();
        }

        public PanelResult DomainAddFtpAccount(FtpAccount account)
        {
            throw new NotImplementedException();
        }

        public PanelResult DomainDeleteFtpAccount(string name, string account)
        {
            throw new NotImplementedException();
        }

        public PanelResult DomainChangeFtpPassword(string name, string account, string newPassword)
        {
            throw new NotImplementedException();
        }

        public PanelResult DomainSetDnsZone(DnsZone dnsZone)
        {
            throw new NotImplementedException();
        }

        public PanelResult DomainAddDnsRecord(DnsRecord dnsRecord)
        {
            throw new NotImplementedException();
        }

        public PanelResult DomainDeleteDnsRecord(DnsRecord dnsRecord)
        {
            throw new NotImplementedException();
        }

        public PanelResult DomainCreateSSLRequest(CreateSSLRequest createSSLRequest)
        {
            throw new NotImplementedException();
        }

        public PanelResult DomainGetSSLCert(string name)
        {
            throw new NotImplementedException();
        }

        public PanelResult DomainDeleteSSLRequest(string name)
        {
            throw new NotImplementedException();
        }

        public PanelResult DomainCompleteSSLRequest(string name, string responseCertificate)
        {
            throw new NotImplementedException();
        }

        public PanelResult DomainDeleteSSLCert(string name)
        {
            throw new NotImplementedException();
        }

        public PanelResult DomainImportPfxFile(string name, string password, System.IO.Stream pfx)
        {
            throw new NotImplementedException();
        }

        public PanelResult ResellerCreate(Reseller reseller)
        {
            throw new NotImplementedException();
        }

        public PanelResult ResellerStart(string userName)
        {
            throw new NotImplementedException();
        }

        public PanelResult ResellerStop(string userName)
        {
            throw new NotImplementedException();
        }

        public PanelResult ResellerChangePassword(string userName, string newPassword)
        {
            throw new NotImplementedException();
        }

        public PanelResult ResellerAddDomain(Domain domain)
        {
            throw new NotImplementedException();
        }

        public PanelResult ResellerDeleteDomain(string userName, string domainName)
        {
            throw new NotImplementedException();
        }

        public PanelResult ResellerGetDomains(string userName)
        {
            throw new NotImplementedException();
        }

        public PanelResult GetResellers()
        {
            throw new NotImplementedException();
        }

        public PanelResult ResellerSetLimits(DomainLimit limit)
        {
            throw new NotImplementedException();
        }

        public PanelResult UserWhoAmI()
        {
            throw new NotImplementedException();
        }

        public PanelResult UserLogOff()
        {
            throw new NotImplementedException();
        }
    }
}
