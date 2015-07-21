using OHPanelApi.Panels.Maestro;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Web;

namespace OHPanelApi
{
    public class MaestroPanel : IPanelApi
    {
        private string apiKey;
        private string apiUri;
        private DataFormat format;
        NameValueCollection _args;

        public MaestroPanel(string apiKey,string apiUri)
        {
            this.apiKey = apiKey;
            this.apiUri = apiUri;
            this.format = DataFormat.Json;
            _args = new NameValueCollection();
        }

        public PanelResult DomainCreate(Domain domain)
        {
            _args.Clear();

            _args.Add("name", domain.Name);
            _args.Add("planAlias", domain.PlanAlias);
            _args.Add("username", domain.UserName);
            _args.Add("password", domain.Password);
            _args.Add("activedomainuser", domain.ActiveDomainUser.ToString());
            _args.Add("firstname", domain.FirstName);
            _args.Add("lastname", domain.LastName);
            _args.Add("email", domain.Email);

            ApiResult<DomainOperationsResult> result = ExecuteAction<DomainOperationsResult>(MaestroAction.DomainCreate, Method.POST, _args);

            return GetPanelResult(result);

        }
        public PanelResult DomainDelete(string name)
        {
            _args.Clear();

            _args.Add("name", name);

            ApiResult<DomainOperationsResult> result = ExecuteAction<DomainOperationsResult>(MaestroAction.DomainDelete, Method.DELETE, _args);

            return GetPanelResult(result);




        }
        public PanelResult DomainStop(string name)
        {
            _args.Clear();

            _args.Add("name", name);

            ApiResult<DomainOperationsResult> result = ExecuteAction<DomainOperationsResult>(MaestroAction.DomainStop, Method.POST, _args);

            return GetPanelResult(result);




        }
        public PanelResult DomainStart(string name)
        {
            _args.Clear();

            _args.Add("name", name);


            ApiResult<DomainOperationsResult> result = ExecuteAction<DomainOperationsResult>(MaestroAction.DomainStart, Method.POST, _args);

            return GetPanelResult(result);




        }
        public PanelResult DomainNewPassword(string name, string newPassword)
        {
            _args.Clear();

            _args.Add("name", name);
            _args.Add("newpassword", newPassword);

            ApiResult<DomainOperationsResult> result = ExecuteAction<DomainOperationsResult>(MaestroAction.DomainPassword, Method.POST, _args);

            return GetPanelResult(result);




        }


        public PanelResult AddDomainAlias(string name, string alias)
        {
            _args.Clear();

            _args.Add("name", name);
            _args.Add("alias", alias);


            ApiResult<DomainOperationsResult> result = ExecuteAction<DomainOperationsResult>(MaestroAction.DomainAddDomainAlias, Method.POST, _args);

            return GetPanelResult(result);




        }
        public PanelResult DeleteDomainAlias(string name, string alias)
        {
            _args.Clear();

            _args.Add("name", name);
            _args.Add("alias", alias);

            ApiResult<DomainOperationsResult> result = ExecuteAction<DomainOperationsResult>(MaestroAction.DomainDeleteDomainAlias, Method.DELETE, _args);

            return GetPanelResult(result);




        }
        public PanelResult GetDomainAliases(string name)
        {
            _args.Clear();

            _args.Add("name", name);


            ApiResultList<string> result = ExecuteActionList<string>(MaestroAction.DomainGetDomainAliases, Method.GET, _args);

            return GetPanelResult(result);




        }
        public PanelResult AddSubDomain(string name, string subDomain, string ftpUser)
        {
            _args.Clear();

            _args.Add("name", name);
            _args.Add("subDomain", subDomain);
            _args.Add("ftpUser", ftpUser);


            ApiResult<DomainOperationsResult> result = ExecuteAction<DomainOperationsResult>(MaestroAction.DomainAddSubDomain, Method.POST, _args);

            return GetPanelResult(result);




        }
        public PanelResult DeleteSubDomain(string name, string subDomain)
        {
            _args.Clear();

            _args.Add("name", name);
            _args.Add("subDomain", subDomain);

            ApiResult<DomainOperationsResult> result = ExecuteAction<DomainOperationsResult>(MaestroAction.DomainDeleteSubDomain, Method.DELETE, _args);

            return GetPanelResult(result);




        }
        public PanelResult GetSubDomains(string name)
        {
            _args.Clear();

            _args.Add("name", name);


            ApiResultList<SubdomainConfig> result = ExecuteActionList<SubdomainConfig>(MaestroAction.DomainGetSubDomains, Method.GET, _args);

            return null;
        }
        public PanelResult ChangeIpAddr(string name, string newIp)
        {
            _args.Clear();

            _args.Add("name", name);
            _args.Add("newip", newIp);

            ApiResult<DomainOperationsResult> result = ExecuteAction<DomainOperationsResult>(MaestroAction.DomainChangeIpAddr, Method.POST, _args);

            return GetPanelResult(result);




        }
        public PanelResult GetDomainList()
        {
            _args.Clear();

            // _args.Add("format", "XML");

            ApiResultList<DomainListItem> result = ExecuteActionList<DomainListItem>(MaestroAction.DomainGetList, Method.GET, _args);

            return null;
        }
        public PanelResult GetDomainListItem(string name)
        {
            _args.Clear();

            _args.Add("name", name);

            ApiResult<DomainListItem> result = ExecuteAction<DomainListItem>(MaestroAction.DomainGetListItem, Method.GET, _args);

            return null;
        }
        public PanelResult DomainGetLimits(string name)
        {
            _args.Clear();

            _args.Add("name", name);

            ApiResultList<Limit> result = ExecuteActionList<Limit>(MaestroAction.DomainGetLimits, Method.GET, _args);

            return null;
        }
        public PanelResult DomainSetLimits(DomainLimit limit)
        {
            _args.Clear();
            _args.Add("name", limit.Name);
            _args.Add("maxdiskspace", limit.MaxDiskSpace.ToString());
            _args.Add("maxmailbox", limit.MaxMailBox.ToString());
            _args.Add("maxftpuser", limit.MaxFtpUser.ToString());
            _args.Add("maxsubdomain", limit.MaxSubDomain.ToString());
            _args.Add("maxdomainalias", limit.MaxDomainAlias.ToString());
            _args.Add("totalwebtraffic", limit.TotalWebTraffic.ToString());
            _args.Add("totalmailspace", limit.TotalMailSpace.ToString());
            _args.Add("maxwebtraffic", limit.MaxWebTraffic.ToString());
            _args.Add("maxftptraffic", limit.MaxFtpTraffic.ToString());
            _args.Add("maxmailtraffic", limit.MaxMailTraffic.ToString());

            _args.Add("maxmysql", limit.MaxMySql.ToString());
            _args.Add("maxmysqluser", limit.MaxMySqlUser.ToString());
            _args.Add("maxmysqlspace", limit.MaxMySqlSpace.ToString());

            _args.Add("maxmssql", limit.MaxMsSql.ToString());
            _args.Add("maxmssqlspace", limit.MaxMsSqlSpace.ToString());
            _args.Add("maxmssqluser", limit.MaxMsSqlUser.ToString());

            ApiResult<DomainOperationsResult> result = ExecuteAction<DomainOperationsResult>(MaestroAction.DomainSetLimits, Method.GET, _args);

            return null;
        }
        public PanelResult DomainForwarding(DomainForward forward)
        {
            _args.Clear();
            _args.Add("name", forward.Name);
            _args.Add("enabled", forward.Enabled.ToString());
            _args.Add("destination", forward.Destination);
            _args.Add("exacDestination", forward.ExacDestination.ToString());
            _args.Add("childOnly", forward.ChildOnly.ToString());
            _args.Add("statusCode", forward.StatusCode);

            ApiResult<DomainOperationsResult> result = ExecuteAction<DomainOperationsResult>(MaestroAction.DomainForwarding, Method.POST, _args);

            return null;
        }
        public PanelResult DomainChangeReseller(string name, string resellerName)
        {
            _args.Clear();

            _args.Add("name", name);
            _args.Add("resellername", resellerName);


            ApiResult<DomainOperationsResult> result = ExecuteAction<DomainOperationsResult>(MaestroAction.DomainChangeReseller, Method.POST, _args);

            return GetPanelResult(result);




        }
        public PanelResult SetDomainPlan(string name, string planAlias)
        {
            _args.Clear();

            _args.Add("name", name);
            _args.Add("planAlias", planAlias);


            ApiResult<DomainOperationsResult> result = ExecuteAction<DomainOperationsResult>(MaestroAction.DomainSetDomainPlan, Method.POST, _args);

            return GetPanelResult(result);




        }

        //FileManager
        public PanelResult DomainSetWriteAccess(string name, string path)
        {
            _args.Clear();

            _args.Add("name", name);
            _args.Add("path", path);


            ApiResult<DomainOperationsResult> result = ExecuteAction<DomainOperationsResult>(MaestroAction.DomainSetWriteAccess, Method.POST, _args);

            return GetPanelResult(result);




        }
        public PanelResult DomainRevokeWriteAccess(string name, string path)
        {
            _args.Clear();

            _args.Add("name", name);
            _args.Add("path", path);


            ApiResult<DomainOperationsResult> result = ExecuteAction<DomainOperationsResult>(MaestroAction.DomainRevokeWriteAccess, Method.POST, _args);

            return GetPanelResult(result);




        }
        public PanelResult DomainCreateDirectory(string name, string path)
        {
            _args.Clear();

            _args.Add("name", name);
            _args.Add("path", path);


            ApiResult<DomainOperationsResult> result = ExecuteAction<DomainOperationsResult>(MaestroAction.DomainCreateDirectory, Method.POST, _args);

            return GetPanelResult(result);




        }

        //TODO: Fixx Json Serialize error.(date time error)
        public PanelResult DomainGetItems(string name, string path)
        {
            _args.Clear();

            _args.Add("name", name);
            _args.Add("path", path);


            ApiResultList<DiskItem> result = ExecuteActionList<DiskItem>(MaestroAction.DomainGetItems, Method.GET, _args);

            return GetPanelResult(result);




        }
        public PanelResult DomainDeleteItems(string name, List<string> items)
        {
            _args.Clear();

            _args.Add("name", name);

            foreach (string item in items)
                _args.Add("item", item);


            ApiResult<DomainOperationsResult> result = ExecuteAction<DomainOperationsResult>(MaestroAction.DomainDeleteItems, Method.DELETE, _args);

            return GetPanelResult(result);




        }
        public PanelResult DomainZipItem(string name, string zipFilePath, List<string> items)
        {
            _args.Clear();

            _args.Add("name", name);
            _args.Add("zipFilePath", zipFilePath);

            foreach (string item in items)
                _args.Add("item", item);


            ApiResult<DomainOperationsResult> result = ExecuteAction<DomainOperationsResult>(MaestroAction.DomainZipItem, Method.POST, _args);

            return GetPanelResult(result);




        }
        public PanelResult DomainUnZipItem(string name, string zipFilePath, string extractPath)
        {
            _args.Clear();

            _args.Add("name", name);
            _args.Add("zipFilePath", zipFilePath);
            _args.Add("extractPath", extractPath);


            ApiResult<DomainOperationsResult> result = ExecuteAction<DomainOperationsResult>(MaestroAction.DomainUnZipItem, Method.POST, _args);

            return GetPanelResult(result);




        }

        //Web Stats
        public PanelResult DomainProtectStatsArea(string name, string userName, string password)
        {
            _args.Clear();

            _args.Add("name", name);
            _args.Add("username", userName);
            _args.Add("password", password);


            ApiResult<DomainOperationsResult> result = ExecuteAction<DomainOperationsResult>(MaestroAction.DomainProtectStatsArea, Method.POST, _args);

            return GetPanelResult(result);




        }
        public PanelResult DomainUnProtectStatsArea(string name)
        {
            _args.Clear();

            _args.Add("name", name);

            ApiResult<DomainOperationsResult> result = ExecuteAction<DomainOperationsResult>(MaestroAction.DomainUnProtectStatsArea, Method.POST, _args);

            return GetPanelResult(result);




        }
        public PanelResult DomainEnableStatsProtection(string name)
        {
            _args.Clear();

            _args.Add("name", name);

            ApiResult<DomainOperationsResult> result = ExecuteAction<DomainOperationsResult>(MaestroAction.DomainEnableStatsProtection, Method.POST, _args);

            return GetPanelResult(result);




        }
        public PanelResult DomainDisableStatsProtection(string name)
        {
            _args.Clear();

            _args.Add("name", name);

            ApiResult<DomainOperationsResult> result = ExecuteAction<DomainOperationsResult>(MaestroAction.DomainDisableStatsProtection, Method.POST, _args);

            return GetPanelResult(result);




        }
        public PanelResult DomainSetFtpUserStatsArea(string name, string ftpuser)
        {
            _args.Clear();

            _args.Add("name", name);
            _args.Add("ftpuser", ftpuser);

            ApiResult<DomainOperationsResult> result = ExecuteAction<DomainOperationsResult>(MaestroAction.DomainSetFtpUserStatsArea, Method.POST, _args);

            return GetPanelResult(result);




        }

        //Mail
        public PanelResult DomainAddMailBox(DomainMailBox mailBox)
        {
            _args.Clear();

            _args.Add("name", mailBox.Name);
            _args.Add("account", mailBox.Account);
            _args.Add("password", mailBox.Password);
            _args.Add("quota", mailBox.Quota.ToString());
            _args.Add("redirect", mailBox.Redirect);
            _args.Add("remail", mailBox.ReMail);

            ApiResult<DomainOperationsResult> result = ExecuteAction<DomainOperationsResult>(MaestroAction.DomainAddMailBox, Method.POST, _args);

            return GetPanelResult(result);




        }
        public PanelResult DomainDeleteMailBox(string name, string account)
        {
            _args.Clear();

            _args.Add("name", name);
            _args.Add("account", account);


            ApiResult<DomainOperationsResult> result = ExecuteAction<DomainOperationsResult>(MaestroAction.DomainDeleteMailBox, Method.POST, _args);

            return GetPanelResult(result);




        }
        public PanelResult DomainChangeMailBoxQuota(string name, string account, int quota)
        {
            _args.Clear();

            _args.Add("name", name);
            _args.Add("account", account);
            _args.Add("quota", quota.ToString());

            ApiResult<DomainOperationsResult> result = ExecuteAction<DomainOperationsResult>(MaestroAction.DomainChangeMailBoxQuota, Method.POST, _args);

            return GetPanelResult(result);




        }
        public PanelResult DomainChangeMailBoxPassword(string name, string account, string newpassword)
        {
            _args.Clear();

            _args.Add("name", name);
            _args.Add("account", account);
            _args.Add("newpassword", newpassword);

            ApiResult<DomainOperationsResult> result = ExecuteAction<DomainOperationsResult>(MaestroAction.DomainChangeMailBoxPassword, Method.POST, _args);

            return GetPanelResult(result);




        }
        public PanelResult DomainGetMailList(string name)
        {
            _args.Clear();

            _args.Add("name", name);

            ApiResult<ExportPostOffice> result = ExecuteAction<ExportPostOffice>(MaestroAction.DomainGetMailList, Method.GET, _args);

            return GetPanelResult(result);




        }

        //Database
        public PanelResult DomainAddDatabase(Database database)
        {
            _args.Clear();

            _args.Add("name", database.Name);
            _args.Add("dbtype", database.DbType);
            _args.Add("database", database.Database_);
            _args.Add("username", database.Users.First().Username);
            _args.Add("password", database.Users.First().Password);
            _args.Add("quota", database.Quota.ToString());
            _args.Add("host", database.Host);

            ApiResult<DomainOperationsResult> result = ExecuteAction<DomainOperationsResult>(MaestroAction.DomainAddDatabase, Method.POST, _args);

            return GetPanelResult(result);




        }
        public PanelResult DomainDeleteDatabase(string name, string dbType, string database)
        {
            _args.Clear();

            _args.Add("name", name);
            _args.Add("dbtype", dbType);
            _args.Add("database", database);

            ApiResult<DomainOperationsResult> result = ExecuteAction<DomainOperationsResult>(MaestroAction.DomainDeleteDatabase, Method.POST, _args);

            return GetPanelResult(result);




        }
        public PanelResult DomainAddDatabaseUser(Database database)
        {
            _args.Clear();

            _args.Add("name", database.Name);
            _args.Add("dbtype", database.DbType);
            _args.Add("database", database.Database_);
            _args.Add("username", database.Users.First().Username);
            _args.Add("password", database.Users.First().Password);
            _args.Add("host", database.Host);

            ApiResult<DomainOperationsResult> result = ExecuteAction<DomainOperationsResult>(MaestroAction.DomainAddDatabaseUser, Method.POST, _args);

            return GetPanelResult(result);




        }

        //Ftp
        public PanelResult DomainAddFtpAccount(FtpAccount account)
        {
            _args.Clear();

            _args.Add("name", account.Name);
            _args.Add("account", account.Account);
            _args.Add("password", account.Password);
            _args.Add("homePath", account.HomePath);
            _args.Add("ronly", account.Ronly.ToString());

            ApiResult<DomainOperationsResult> result = ExecuteAction<DomainOperationsResult>(MaestroAction.DomainAddFtpAccount, Method.POST, _args);

            return GetPanelResult(result);




        }
        public PanelResult DomainDeleteFtpAccount(string name, string account)
        {
            _args.Clear();

            _args.Add("name", name);
            _args.Add("account", account);

            ApiResult<DomainOperationsResult> result = ExecuteAction<DomainOperationsResult>(MaestroAction.DomainDeleteFtpAccount, Method.POST, _args);

            return GetPanelResult(result);




        }
        public PanelResult DomainChangeFtpPassword(string name, string account, string newPassword)
        {
            _args.Clear();

            _args.Add("name", name);
            _args.Add("account", account);
            _args.Add("newpassword", newPassword);

            ApiResult<DomainOperationsResult> result = ExecuteAction<DomainOperationsResult>(MaestroAction.DomainChangeFtpPassword, Method.POST, _args);

            return GetPanelResult(result);




        }

        //Dns
        public PanelResult DomainSetDnsZone(DnsZone dnsZone)
        {
            _args.Clear();

            _args.Add("name", dnsZone.Name);
            _args.Add("soa_expired", dnsZone.SoaExpire.ToString());
            _args.Add("soa_ttl", dnsZone.SoaTtl.ToString());
            _args.Add("soa_refresh", dnsZone.SoaRefresh.ToString());
            _args.Add("soa_email", dnsZone.SoaEmail.ToString());
            _args.Add("soa_retry", dnsZone.SoaRetry.ToString());
            _args.Add("soa_serial", dnsZone.SoaSerial.ToString());
            _args.Add("primaryServer", dnsZone.PrimaryServer.ToString());

            foreach (var item in dnsZone.Records)
                _args.Add("record", item.RecordString);


            ApiResult<DomainOperationsResult> result = ExecuteAction<DomainOperationsResult>(MaestroAction.DomainSetDnsZone, Method.POST, _args);

            return GetPanelResult(result);




        }
        public PanelResult DomainAddDnsRecord(DnsRecord dnsRecord)
        {
            _args.Clear();

            _args.Add("name", dnsRecord.Name);
            _args.Add("rec_type", dnsRecord.RecType);
            _args.Add("rec_name", dnsRecord.RecName);
            _args.Add("rec_value", dnsRecord.RecValue);
            _args.Add("priority", dnsRecord.Priority.ToString());


            ApiResult<DomainOperationsResult> result = ExecuteAction<DomainOperationsResult>(MaestroAction.DomainAddDnsRecord, Method.POST, _args);

            return GetPanelResult(result);




        }
        public PanelResult DomainDeleteDnsRecord(DnsRecord dnsRecord)
        {
            _args.Clear();

            _args.Add("name", dnsRecord.Name);
            _args.Add("rec_type", dnsRecord.RecType);
            _args.Add("rec_name", dnsRecord.RecName);
            _args.Add("rec_value", dnsRecord.RecValue);
            _args.Add("priority", dnsRecord.Priority.ToString());


            ApiResult<DomainOperationsResult> result = ExecuteAction<DomainOperationsResult>(MaestroAction.DomainDeleteDnsRecord, Method.POST, _args);

            return GetPanelResult(result);




        }

        //SSL
        public PanelResult DomainCreateSSLRequest(CreateSSLRequest createSSLRequest)
        {
            _args.Clear();

            _args.Add("name", createSSLRequest.DomainName);
            _args.Add("commonName", createSSLRequest.CommonName);
            _args.Add("organization", createSSLRequest.Organization);
            _args.Add("organizationUnit", createSSLRequest.OrganizationUnit);
            _args.Add("city", createSSLRequest.City);
            _args.Add("state", createSSLRequest.State);
            _args.Add("countryCode", createSSLRequest.CountryCode);

            ApiResult<DomainOperationsResult> result = ExecuteAction<DomainOperationsResult>(MaestroAction.DomainCreateSSLRequest, Method.POST, _args);

            return GetPanelResult(result);




        }
        public PanelResult DomainGetSSLCert(string name)
        {
            _args.Clear();

            _args.Add("name", name);

            ApiResult<SSLDto> result = ExecuteAction<SSLDto>(MaestroAction.DomainGetSSLCert, Method.GET, _args);

            return GetPanelResult(result);




        }
        public PanelResult DomainDeleteSSLRequest(string name)
        {
            _args.Clear();

            _args.Add("name", name);

            ApiResult<DomainOperationsResult> result = ExecuteAction<DomainOperationsResult>(MaestroAction.DomainDeleteSSLRequest, Method.DELETE, _args);

            return GetPanelResult(result);




        }
        public PanelResult DomainCompleteSSLRequest(string name, string responseCertificate)
        {
            _args.Clear();

            _args.Add("name", name);
            _args.Add("responseCertificate", responseCertificate);

            ApiResult<DomainOperationsResult> result = ExecuteAction<DomainOperationsResult>(MaestroAction.DomainCompleteSSLRequest, Method.POST, _args);

            return GetPanelResult(result);




        }
        public PanelResult DomainDeleteSSLCert(string name)
        {
            _args.Clear();

            _args.Add("name", name);

            ApiResult<DomainOperationsResult> result = ExecuteAction<DomainOperationsResult>(MaestroAction.DomainDeleteSSLCert, Method.DELETE, _args);

            return GetPanelResult(result);




        }
        public PanelResult DomainImportPfxFile(string name, string password, Stream pfx)
        {
            _args.Clear();

            _args.Add("name", name);
            _args.Add("password", name);

            ApiResult<DomainOperationsResult> result = ExecuteAction<DomainOperationsResult>(MaestroAction.DomainImportPfxFile, Method.POST, _args);

            return GetPanelResult(result);




        }

        //Reseller
        public PanelResult ResellerCreate(Reseller reseller)
        {
            _args.Clear();

            _args.Add("username", reseller.Username);
            _args.Add("password", reseller.Password);
            _args.Add("planAlias", reseller.PlanAlias);
            _args.Add("firstName", reseller.FirstName);
            _args.Add("lastname", reseller.LastName);
            _args.Add("email", reseller.Email);
            _args.Add("country", reseller.Country);
            _args.Add("organization", reseller.Organization);
            _args.Add("address1", reseller.Address1);
            _args.Add("address2", reseller.Address2);
            _args.Add("city", reseller.City);
            _args.Add("province", reseller.Province);
            _args.Add("postalcode", reseller.PostalCode);
            _args.Add("phone", reseller.Phone);
            _args.Add("fax", reseller.Fax);

            ApiResult<ResellerOperationResult> result = ExecuteAction<ResellerOperationResult>(MaestroAction.ResellerCreate, Method.POST, _args);

            return GetPanelResult(result);




        }
        public PanelResult ResellerStart(string userName)
        {
            _args.Clear();

            _args.Add("name", userName);

            ApiResult<ResellerOperationResult> result = ExecuteAction<ResellerOperationResult>(MaestroAction.ResellerStart, Method.POST, _args);

            return GetPanelResult(result);




        }
        public PanelResult ResellerStop(string userName)
        {
            _args.Clear();

            _args.Add("name", userName);

            ApiResult<ResellerOperationResult> result = ExecuteAction<ResellerOperationResult>(MaestroAction.ResellerStop, Method.POST, _args);

            return GetPanelResult(result);




        }
        public PanelResult ResellerChangePassword(string userName, string newPassword)
        {
            _args.Clear();

            _args.Add("name", userName);
            _args.Add("newpassword", newPassword);

            ApiResult<ResellerOperationResult> result = ExecuteAction<ResellerOperationResult>(MaestroAction.ResellerChangePassword, Method.POST, _args);

            return GetPanelResult(result);




        }
        public PanelResult ResellerAddDomain(Domain domain)
        {
            _args.Clear();

            _args.Add("username", domain.ResellerName);
            _args.Add("domainName", domain.Name);
            _args.Add("planAlias", domain.PlanAlias);
            _args.Add("domainUsername", domain.UserName);
            _args.Add("domainPassword", domain.Password);
            _args.Add("activedomainuser", domain.ActiveDomainUser.ToString());
            _args.Add("firstname", domain.FirstName);
            _args.Add("lastname", domain.LastName);
            _args.Add("email", domain.Email);
            _args.Add("expiration", domain.ExpirationDate.ToShortDateString());

            ApiResult<ResellerOperationResult> result = ExecuteAction<ResellerOperationResult>(MaestroAction.ResellerAddDomain, Method.POST, _args);

            return GetPanelResult(result);




        }
        public PanelResult ResellerDeleteDomain(string userName, string domainName)
        {
            _args.Clear();

            _args.Add("username", userName);
            _args.Add("domainName", domainName);


            ApiResult<ResellerOperationResult> result = ExecuteAction<ResellerOperationResult>(MaestroAction.ResellerDeleteDomain, Method.POST, _args);

            return GetPanelResult(result);




        }
        public PanelResult ResellerGetDomains(string userName)
        {
            _args.Clear();

            _args.Add("username", userName);

            ApiResultList<DomainListItem> result = ExecuteActionList<DomainListItem>(MaestroAction.ResellerGetDomains, Method.GET, _args);

            return GetPanelResult(result);




        }
        public PanelResult GetResellers()
        {
            _args.Clear();


            ApiResultList<LoginListItem> result = ExecuteActionList<LoginListItem>(MaestroAction.ResellerGetResellers, Method.GET, _args);

            return GetPanelResult(result);




        }
        public PanelResult ResellerSetLimits(DomainLimit limit)
        {
            _args.Clear();
            _args.Add("username", limit.ResellerName);
            _args.Add("maxdomain", limit.MaxDomain.ToString());
            _args.Add("maxdiskspace", limit.MaxDiskSpace.ToString());
            _args.Add("maxmailbox", limit.MaxMailBox.ToString());
            _args.Add("maxftpuser", limit.MaxFtpUser.ToString());
            _args.Add("maxsubdomain", limit.MaxSubDomain.ToString());
            _args.Add("maxdomainalias", limit.MaxDomainAlias.ToString());
            _args.Add("totalwebtraffic", limit.TotalWebTraffic.ToString());
            _args.Add("totalmailspace", limit.TotalMailSpace.ToString());
            _args.Add("maxwebtraffic", limit.MaxWebTraffic.ToString());
            _args.Add("maxftptraffic", limit.MaxFtpTraffic.ToString());
            _args.Add("maxmailtraffic", limit.MaxMailTraffic.ToString());

            _args.Add("maxmysql", limit.MaxMySql.ToString());
            _args.Add("maxmysqluser", limit.MaxMySqlUser.ToString());
            _args.Add("maxmysqlspace", limit.MaxMySqlSpace.ToString());

            _args.Add("maxmssql", limit.MaxMsSql.ToString());
            _args.Add("maxmssqlspace", limit.MaxMsSqlSpace.ToString());
            _args.Add("maxmssqluser", limit.MaxMsSqlUser.ToString());

            ApiResult<ResellerOperationResult> result = ExecuteAction<ResellerOperationResult>(MaestroAction.ResellerSetLimits, Method.POST, _args);

            return GetPanelResult(result);




        }

        //User
        public PanelResult UserWhoAmI()
        {
            _args.Clear();


            ApiResult<Whoami> result = ExecuteAction<Whoami>(MaestroAction.UserWhoami, Method.GET, _args);

            return GetPanelResult(result);




        }
        public PanelResult UserLogOff()
        {
            _args.Clear();


            ApiResult<string> result = ExecuteAction<string>(MaestroAction.UserLogoff, Method.GET, _args);

            return GetPanelResult(result);




        }


        #region MaestroPanel Methods

        private void WriteData(ref HttpWebRequest _request, NameValueCollection _parameters)
        {
            byte[] byteData = CreateParameters(_parameters);
            _request.ContentLength = byteData.Length;

            using (Stream postStream = _request.GetRequestStream())
            {
                postStream.Write(byteData, 0, byteData.Length);

            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="_request"></param>
        /// <returns></returns>
        private string GetData(HttpWebRequest _request)
        {
            var _response = String.Empty;
            using (HttpWebResponse response = _request.GetResponse() as HttpWebResponse)
            {
                StreamReader reader = new StreamReader(response.GetResponseStream());
                _response = reader.ReadToEnd();
            }

            return _response;
        }
        private byte[] CreateParameters(NameValueCollection _parameters)
        {
            var _sb = new StringBuilder(_parameters.Count);

            foreach (var item in _parameters.AllKeys)
                _sb.AppendFormat("{0}={1}&", HttpUtility.UrlEncode(item), HttpUtility.UrlEncode(_parameters[item]));

            _sb.Length -= 1;

            return UTF8Encoding.UTF8.GetBytes(_sb.ToString());
        }

        private ApiResult<T> ExecuteAction<T>(string action, Method method, NameValueCollection args)
        {
            var requestUri = String.Empty;
            var result = new ApiResult<T>();

            try
            {
                result = SendApi<ApiResult<T>>(action, method, args);
            }
            catch (Exception ex)
            {
                result = new ApiResult<T>() { ErrorCode = 500, Message = ex.Message, StatusCode = 200 };
            }

            return result;
        }
        private ApiResultList<T> ExecuteActionList<T>(string action, Method method, NameValueCollection args)
        {
            var requestUri = String.Empty;
            var result = new ApiResultList<T>();

            try
            {
                result = SendApi<ApiResultList<T>>(action, method, args);

            }
            catch (Exception ex)
            {
                result = new ApiResultList<T>() { ErrorCode = 500, Message = ex.Message, StatusCode = 200 };
            }

            return result;
        }
        private T SendApi<T>(string action, Method method, NameValueCollection _parameters)
        {
            var result = default(T);
            Uri _uri = null;
            string format = Enum.GetName(typeof(DataFormat), this.format);
            if (method == Method.GET)
                _uri = new Uri(String.Format("{0}/{1}?key={2}&suppress_response_codes=true&format={3}&{4}", apiUri, action, apiKey, format, ToQueryString(_parameters)));
            else
                _uri = new Uri(String.Format("{0}/{1}?key={2}&suppress_response_codes=true&format={3}&", apiUri, action, apiKey, format));

            try
            {
                HttpWebRequest request = WebRequest.Create(_uri) as HttpWebRequest;
                request.Method = Enum.GetName(typeof(Method), method);
                request.Timeout = 120 * 1000;
                request.ContentType = "application/x-www-form-urlencoded";

                if (method != Method.GET)
                    WriteData(ref request, _parameters);

                var _responseText = GetData(request);

                if (this.format == DataFormat.Json)
                    //result = JsonHelper<T>.JsonDeserialize(_responseText);
                    result = JsonHelper<T>.Deserialize(_responseText);

                else
                    result = XmlHelper.DeSerializeObject<T>(_responseText);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return result;
        }

        private string ToQueryString(NameValueCollection nvc)
        {
            var array = (from key in nvc.AllKeys
                         from value in nvc.GetValues(key)
                         select string.Format("{0}={1}", HttpUtility.UrlEncode(key), HttpUtility.UrlEncode(value)))
                .ToArray();
            return string.Join("&", array);
        }

        private PanelResult GetPanelResult(IResult result)
        {
            PanelResult panelResult = new PanelResult();
            panelResult.Code = result.StatusCode;
            panelResult.Message = result.Message;
            panelResult.ErrorCode = result.ErrorCode;

            return panelResult;

        }


        #endregion

    }
}
