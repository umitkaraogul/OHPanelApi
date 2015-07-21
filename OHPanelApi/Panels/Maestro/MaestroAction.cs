using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OHPanelApi.Panels.Maestro
{
    public class MaestroAction
    {
        #region Domain Action Constants

        //Domain Action-->Web
        public const string DomainCreate = "Domain/Create";
        public const string DomainDelete = "Domain/Delete";
        public const string DomainStart = "Domain/Start";
        public const string DomainStop = "Domain/Stop";
        public const string DomainPassword = "Domain/Password";
        public const string DomainAddDomainAlias = "Domain/AddDomainAlias";
        public const string DomainDeleteDomainAlias = "Domain/DeleteDomainAlias";
        public const string DomainGetDomainAliases = "Domain/GetDomainAliases";
        public const string DomainAddSubDomain = "Domain/AddSubDomain";
        public const string DomainDeleteSubDomain = "Domain/DeleteSubDomain";
        public const string DomainGetSubDomains = "Domain/GetSubDomains";
        public const string DomainChangeIpAddr = "Domain/ChangeIpAddr";
        public const string DomainGetList = "Domain/GetList";
        public const string DomainGetListItem = "Domain/GetListItem";
        public const string DomainGetLimits = "Domain/GetLimits";
        public const string DomainSetLimits = "Domain/SetLimits";
        public const string DomainForwarding = "Domain/Forwarding";
        public const string DomainChangeReseller = "Domain/ChangeReseller";
        public const string DomainSetDomainPlan = "Domain/SetDomainPlan";

        //Domain Action-->	FileManager

        public const string DomainSetWriteAccess = "Domain/SetWriteAccess";
        public const string DomainRevokeWriteAccess = "Domain/RevokeWriteAccess";
        public const string DomainCreateDirectory = "Domain/CreateDirectory";
        public const string DomainGetItems = "Domain/GetItems";
        public const string DomainDeleteItems = "Domain/DeleteItems";
        public const string DomainZipItem = "Domain/ZipItem";
        public const string DomainUnZipItem = "Domain/UnZipItem";

        //Domain Action-->	Web Stats

        public const string DomainProtectStatsArea = "Domain/ProtectStatsArea";
        public const string DomainUnProtectStatsArea = "Domain/UnProtectStatsArea";
        public const string DomainEnableStatsProtection = "Domain/EnableStatsProtection";
        public const string DomainDisableStatsProtection = "Domain/DisableStatsProtection";
        public const string DomainSetFtpUserStatsArea = "Domain/SetFtpUserStatsArea";

        //Domain Action-->	Mail

        public const string DomainAddMailBox = "Domain/AddMailBox";
        public const string DomainDeleteMailBox = "Domain/DeleteMailBox";
        public const string DomainChangeMailBoxPassword = "Domain/ChangeMailBoxPassword";
        public const string DomainChangeMailBoxQuota = "Domain/ChangeMailBoxQuota";
        public const string DomainGetMailList = "Domain/GetMailList";

        //Domain Action-->	Database

        public const string DomainAddDatabase = "Domain/AddDatabase";
        public const string DomainDeleteDatabase = "Domain/DeleteDatabase";
        public const string DomainAddDatabaseUser = "Domain/AddDatabaseUser";
        public const string DomainChangeDatabaseUserPassword = "Domain/ChangeDatabaseUserPassword";
        public const string DomainGetDatabaseList = "Domain/GetDatabaseList";
        public const string DomainSetDatabaseQuota = "Domain/SetDatabaseQuota";

        //Domain Action-->	Ftp

        public const string DomainAddFtpAccount = "Domain/AddFtpAccount";
        public const string DomainDeleteFtpAccount = "Domain/DeleteFtpAccount";
        public const string DomainChangeFtpPassword = "Domain/ChangeFtpPassword";

        //Domain Action-->	Dns

        public const string DomainSetDnsZone = "Domain/SetDnsZone";
        public const string DomainAddDnsRecord = "Domain/AddDnsRecord";
        public const string DomainDeleteDnsRecord = "Domain/DeleteDnsRecord";

        //Domain Action-->	SSL

        public const string DomainCreateSSLRequest = "Domain/CreateSSLRequest";
        public const string DomainDeleteSSLRequest = "Domain/DeleteSSLRequest";
        public const string DomainCompleteSSLRequest = "Domain/CompleteSSLRequest";
        public const string DomainDeleteSSLCert = "Domain/DeleteSSLCert";
        public const string DomainGetSSLCert = "Domain/GetSSLCert";
        public const string DomainImportPfxFile = "Domain/ImportPfxFile";

        #endregion

        //Reseller Actions
        public const string ResellerCreate = "Reseller/Create";
        public const string ResellerStart = "Reseller/Start";
        public const string ResellerStop = "Reseller/Stop";
        public const string ResellerChangePassword = "Reseller/ChangePassword";
        public const string ResellerGetResellers = "Reseller/GetResellers";
        public const string ResellerSetLimits = "Reseller/SetLimits";
        public const string ResellerGetLimits = "Reseller/GetLimits";

        public const string ResellerAddDomain = "Reseller/AddDomain";
        public const string ResellerDeleteDomain = "Reseller/DeleteDomain";
        public const string ResellerGetDomains = "Reseller/GetDomains";

        //User Actions
        public const string UserWhoami = "User/Whoami";
        public const string UserLogoff = "User/Logoff";

    }
}
