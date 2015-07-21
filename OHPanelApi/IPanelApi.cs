using OHPanelApi.Panels.Maestro;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OHPanelApi
{
    public interface IPanelApi
    {
        PanelResult DomainCreate(Domain domain);
        PanelResult DomainDelete(string name);
        PanelResult DomainStop(string name);
        PanelResult DomainStart(string name);
        PanelResult DomainNewPassword(string name, string newPassword);
        PanelResult AddDomainAlias(string name, string alias);
        PanelResult DeleteDomainAlias(string name, string alias);
        PanelResult GetDomainAliases(string name);
        PanelResult AddSubDomain(string name, string subDomain, string ftpUser);
        PanelResult DeleteSubDomain(string name, string subDomain);
        PanelResult GetSubDomains(string name);
        PanelResult ChangeIpAddr(string name, string newIp);
        PanelResult GetDomainList();
        PanelResult GetDomainListItem(string name);
        PanelResult DomainGetLimits(string name);
        PanelResult DomainSetLimits(DomainLimit limit);
        PanelResult DomainForwarding(DomainForward forward);
        PanelResult DomainChangeReseller(string name, string resellerName);
        PanelResult SetDomainPlan(string name, string planAlias);
        PanelResult DomainSetWriteAccess(string name, string path);
        PanelResult DomainRevokeWriteAccess(string name, string path);
        PanelResult DomainCreateDirectory(string name, string path);
        PanelResult DomainGetItems(string name, string path);
        PanelResult DomainDeleteItems(string name, List<string> items);
        PanelResult DomainZipItem(string name, string zipFilePath, List<string> items);
        PanelResult DomainUnZipItem(string name, string zipFilePath, string extractPath);
        PanelResult DomainProtectStatsArea(string name, string userName, string password);
        PanelResult DomainUnProtectStatsArea(string name);
        PanelResult DomainEnableStatsProtection(string name);
        PanelResult DomainDisableStatsProtection(string name);
        PanelResult DomainSetFtpUserStatsArea(string name, string ftpuser);
        PanelResult DomainAddMailBox(DomainMailBox mailBox);
        PanelResult DomainDeleteMailBox(string name, string account);
        PanelResult DomainChangeMailBoxQuota(string name, string account, int quota);
        PanelResult DomainChangeMailBoxPassword(string name, string account, string newpassword);
        PanelResult DomainGetMailList(string name);
        PanelResult DomainAddDatabase(Database database);
        PanelResult DomainDeleteDatabase(string name, string dbType, string database);
        PanelResult DomainAddDatabaseUser(Database database);
        PanelResult DomainAddFtpAccount(FtpAccount account);
        PanelResult DomainDeleteFtpAccount(string name, string account);
        PanelResult DomainChangeFtpPassword(string name, string account, string newPassword);
        PanelResult DomainSetDnsZone(DnsZone dnsZone);
        PanelResult DomainAddDnsRecord(DnsRecord dnsRecord);
        PanelResult DomainDeleteDnsRecord(DnsRecord dnsRecord);
        PanelResult DomainCreateSSLRequest(CreateSSLRequest createSSLRequest);
        PanelResult DomainGetSSLCert(string name);
        PanelResult DomainDeleteSSLRequest(string name);
        PanelResult DomainCompleteSSLRequest(string name, string responseCertificate);
        PanelResult DomainDeleteSSLCert(string name);
        PanelResult DomainImportPfxFile(string name, string password, Stream pfx);
        PanelResult ResellerCreate(Reseller reseller);
        PanelResult ResellerStart(string userName);
        PanelResult ResellerStop(string userName);
        PanelResult ResellerChangePassword(string userName, string newPassword);
        PanelResult ResellerAddDomain(Domain domain);
        PanelResult ResellerDeleteDomain(string userName, string domainName);
        PanelResult ResellerGetDomains(string userName);
        PanelResult GetResellers();
        PanelResult ResellerSetLimits(DomainLimit limit);
        PanelResult UserWhoAmI();
        PanelResult UserLogOff();
    }
}
