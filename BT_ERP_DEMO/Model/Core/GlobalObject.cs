// CoreEntities, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// DHSErp.Entities.Core.GlobalObject
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using BT_ERP_DEMO.Model;
using Microsoft.VisualBasic.CompilerServices;

[StandardModule]
public sealed class GlobalObject
{
    public class GeneralList
    {
        private static DataTable _ListTableAcc = new DataTable();

        private static DataTable _ListTableUserInfo = new DataTable();

        private static DataSet _ListTableData = new DataSet();

        public static List<ExportImportExcel> ConfigExportImportExcel
        {
            [DebuggerNonUserCode]
            get;
            [DebuggerNonUserCode]
            set;
        }

        public static DataSet ListTableDataList
        {
            get
            {
                return _ListTableData;
            }
            set
            {
                _ListTableData = value;
            }
        }

        public static DataTable ListTableDataAccount
        {
            get
            {
                return _ListTableAcc;
            }
            set
            {
                _ListTableAcc = value;
            }
        }

        public static DataTable ListTableDataUserInfo
        {
            get
            {
                return _ListTableUserInfo;
            }
            set
            {
                _ListTableUserInfo = value;
            }
        }

        [DebuggerNonUserCode]
        public GeneralList()
        {
        }
    }

    private static string _Ma_cty;

    private static string _Ten_cty;

    private static string _UserName;

    private static string _PasswordHard = "ADMIN" + DateTime.Now.ToString("MMM");

    private static string _UserNameText;

    private static string _language;

    private static string _languagepath;

    private static string _formmain;

    private static string _ModuleDefaultValue;

    private static bool _UserAdmin;

    private static int _QuantityUser;

    private static bool _SupperAdmin;

    private static string _Title;

    private static string _Email;

    private static string _PassEmail;

    private static string _ServerMail;

    private static int _MailPort;

    private static bool _EnableSSL;

    private static string _EmployeeCode;

    private static int _CurYear;

    private static string _Ma_nt0;

    // Commented out: types not found (SiSetup)
    // private static SiSetup _SiSetUp;

    // Commented out: types not found (PoSetup)
    // private static PoSetup _PoSetUp;

    // Commented out: types not found (SoSetup)
    // private static SoSetup _SoSetUp;

    // Commented out: types not found (FaSetup)
    // private static FaSetup _FaSetUp;

    // Commented out: types not found (CoSetup)
    // private static CoSetup _CoSetUp;

    // Commented out: types not found (InSetup)
    // private static InSetup _InSetUp;

    // Commented out: types not found (Company)
    // private static Company _CompanyInfor;

    // Commented out: types not found (GLdmtk)
    // private static List<GLdmtk> _LstAcc;

    // Commented out: types not found (sysMenu)
    // private static List<sysMenu> _LstMenu;

    // Commented out: types not found (SysCurrency)
    // private static List<SysCurrency> _SysCurrency;

    // Commented out: types not found (siUserSignOff)
    // private static List<siUserSignOff> _siUserSignOff;

    // Commented out: types not found (SysTimeNotificationSetting)
    // private static SysTimeNotificationSetting _SysTimeNotificationSetting;

    // Commented out: types not found (SysControlType)
    // private static SysControlType _SysControlType;

    private static string _LinkSignOff;

    private static string _Url_sendnotification;

    public static string StrCodeCompanyEncrypt = "DHSoft211813436Susu";

    private static int _KeyIndexData = 1;

    private static int _KeyIndexSys = 2;

    private static int _KeyIndexGetConn = 0;

    private static int _KeyIndexGetConn3 = 3;

    private static int _KeyIndexGetConn4 = 4;

    private static int _KeyIndexGetConn5 = 5;

    private static int _KeyIndexGetConn6 = 6;

    private static int _KeyIndexGetConn7 = 7;

    private static int _KeyIndexGetConn8 = 8;

    private static int _KeyIndexGetConn9 = 9;

    private static int _KeyIndexGetConn10 = 10;

    public const string gbspGetTain = "spTaxInGetCt";

    public const string gbspInsertTain = "spTaxInInsCt";

    public const string gbspDeleteTain = "spTaxinDel";

    public const string gbspSysProcessVch = "spSysProcessVch";

    public const string gbspGetTaOut = "spTaxOutGet";

    public const string gbspInsertTaOut = "spTaxOutIns";

    public const string gbspDeleteTaOut = "spTaxOutDel";

    public const string gbspSysChkUpdDelVoucher = "spSysChkUpdDelVoucher";

    public const string gbspSysChkCodeExists = "spSysChkCodeExists";

    public const string gbspSysChkVoucherNo = "spSysChkVoucherNo";

    public const string gbsplstCustomerBankGet = "splstCustomerBankGet";

    public const string gbspSysChkExistsCodeDictOnTable = "spSysChkExistsCodeDictOnTable";

    public const string gbspSysGetRecNo = "spSysGetRecNo";

    public const string gbspSysGetVoucherNo = "spSysGetVoucherNo";

    public const string gbspDictionaryInfoGet = "spDictionaryInfoGet";

    public const string gbspSysSetupSIGet = "spSysSetupSIGet";

    public const string gbspSysSetupINGet = "spSysSetupINGet";

    public const string gbspSysGetVoucherByVoucherCode = "spSysGetVoucherByVoucherCode";

    public const string gbspSysGetTableListByTableName = "spSysGetTableListByTableName";

    public const string gbspSysGetTableListCode = "spSysGetListCodeNo";

    public const string gbspSysUpdateTableListCode = "spsysUpdateListCodeNumber";

    public const string gbspGetRight = "spSiGetRight";

    public const string gbspGetReportDrilldown = "spReportDrilldownInfoGet";

    public const string gbspGetReportInfo = "spReportInfoGet";

    public const string gbspSysMenuGetBar = "spSysMenuGetBar";

    public const string gbspSiChangePassword = "spSiChangePassword";

    public const string gbspGetUserInfoByUserName = "spUserInfoGetByUserName";

    public const string gbspOpeningBlanceInfoGet = "spOpeningBlanceInfoGet";

    public const string gbspRightCompanyIns = "spRightCompanyIns";

    public const string gbspRightCompanyGetAll = "spRightCompanyGetAll";

    public const string gbspUserRightsGetAll = "spUserRightsGetAll";

    public const string gbspRoleRightGetAll = "spRoleRightGetAll";

    public const string gbspSysGetLeadtimeAppoveRequisition = "spSysGetLeadtimeAppoveRequisition";

    public const string gbTableTain = "TAXIN";

    public const string gbTableTaOut = "TAXOUT";

    public static int CurYear
    {
        get
        {
            if (_CurYear == 0)
            {
                _CurYear = DateTime.Now.Year;
            }
            return _CurYear;
        }
        set
        {
            _CurYear = value;
        }
    }

    public static string USERNAME
    {
        get
        {
            if (string.IsNullOrEmpty(_UserName))
            {
                _UserName = "ADMIN";
            }
            return _UserName;
        }
        set
        {
            _UserName = value;
        }
    }

    public static string USERNAMETEXT
    {
        get
        {
            return _UserNameText;
        }
        set
        {
            _UserNameText = value;
        }
    }

    public static int QUANTITYUSER
    {
        get
        {
            return _QuantityUser;
        }
        set
        {
            _QuantityUser = value;
        }
    }

    public static string TITLE
    {
        get
        {
            return _Title;
        }
        set
        {
            _Title = value;
        }
    }

    public static string EMAIL
    {
        get
        {
            return _Email;
        }
        set
        {
            _Email = value;
        }
    }

    public static string PASSEMAIL
    {
        get
        {
            return _PassEmail;
        }
        set
        {
            _PassEmail = value;
        }
    }

    public static string SERVERMAIL
    {
        get
        {
            return _ServerMail;
        }
        set
        {
            _ServerMail = value;
        }
    }

    public static int MAILPORT
    {
        get
        {
            return _MailPort;
        }
        set
        {
            _MailPort = value;
        }
    }

    public static bool ENABLESSL
    {
        get
        {
            return _EnableSSL;
        }
        set
        {
            _EnableSSL = value;
        }
    }

    public static string EMPLOYEECODE
    {
        get
        {
            return _EmployeeCode;
        }
        set
        {
            _EmployeeCode = value;
        }
    }

    public static bool USER_ADMIN
    {
        get
        {
            if (Operators.CompareString(_UserName, "ADMIN", TextCompare: false) == 0)
            {
                _UserAdmin = true;
            }
            return _UserAdmin;
        }
        set
        {
            _UserAdmin = value;
        }
    }

    public static bool SUPPER_ADMIN
    {
        get
        {
            if (_SupperAdmin == Conversions.ToBoolean("DHSOFT"))
            {
                _SupperAdmin = true;
            }
            return _SupperAdmin;
        }
        set
        {
            _SupperAdmin = value;
        }
    }

    public static string Language
    {
        get
        {
            if (string.IsNullOrEmpty(_language))
            {
                return "vi-VN";
            }
            return _language;
        }
        set
        {
            _language = value;
        }
    }

    public static string LanguagePath
    {
        get
        {
            if (string.IsNullOrEmpty(_languagepath))
            {
                return "resource\\vi\\resource.xml";
            }
            return _languagepath;
        }
        set
        {
            _languagepath = value;
        }
    }

    public static int FormMain
    {
        get
        {
            return Conversions.ToInteger(_formmain);
        }
        set
        {
            _formmain = Conversions.ToString(value);
        }
    }

    public static string ModuleDefaultValue
    {
        get
        {
            return _ModuleDefaultValue;
        }
        set
        {
            _ModuleDefaultValue = value;
        }
    }

    public static string Ma_cty
    {
        get
        {
            if (string.IsNullOrEmpty(_Ma_cty))
            {
                return "DHS";
            }
            return _Ma_cty;
        }
        set
        {
            _Ma_cty = value;
        }
    }

    public static string Ten_cty
    {
        get
        {
            return _Ten_cty;
        }
        set
        {
            _Ten_cty = value;
        }
    }

    public static string Ma_nt0
    {
        get
        {
            return _Ma_nt0;
        }
        set
        {
            _Ma_nt0 = value;
        }
    }

    public static string Url_sendnotification
    {
        get
        {
            return _Url_sendnotification;
        }
        set
        {
            _Url_sendnotification = value;
        }
    }

    public static string LinkSignoff
    {
        get
        {
            return _LinkSignOff;
        }
        set
        {
            _LinkSignOff = value;
        }
    }

    // Commented out: property referencing missing type SiSetup
    /*
    public static SiSetup SiSetup
    {
        get
        {
            return _SiSetUp;
        }
        set
        {
            _SiSetUp = value;
        }
    }
    */

    // Commented out: property referencing missing type PoSetup
    /*
    public static PoSetup PoSetup
    {
        get
        {
            return _PoSetUp;
        }
        set
        {
            _PoSetUp = value;
        }
    }
    */

    // Commented out: property referencing missing type SoSetup
    /*
    public static SoSetup SoSetup
    {
        get
        {
            return _SoSetUp;
        }
        set
        {
            _SoSetUp = value;
        }
    }
    */

    // Commented out: property referencing missing type FaSetup
    /*
    public static FaSetup FaSetup
    {
        get
        {
            return _FaSetUp;
        }
        set
        {
            _FaSetUp = value;
        }
    }
    */

    // Commented out: property referencing missing type InSetup
    /*
    public static InSetup InSetup
    {
        get
        {
            return _InSetUp;
        }
        set
        {
            _InSetUp = value;
        }
    }
    */

    // Commented out: property referencing missing type CoSetup
    /*
    public static CoSetup CoSetup
    {
        get
        {
            return _CoSetUp;
        }
        set
        {
            _CoSetUp = value;
        }
    }
    */

    // Commented out: property referencing missing type GLdmtk
    /*
    public static List<GLdmtk> LstAcc
    {
        get
        {
            return _LstAcc;
        }
        set
        {
            _LstAcc = value;
        }
    }
    */

    // Commented out: property referencing missing type sysMenu
    /*
    public static List<sysMenu> LstMenu
    {
        get
        {
            return _LstMenu;
        }
        set
        {
            _LstMenu = value;
        }
    }
    */

    // Commented out: property referencing missing type Company
    /*
    public static Company CompanyInfo
    {
        get
        {
            return _CompanyInfor;
        }
        set
        {
            _CompanyInfor = value;
        }
    }
    */

    // Commented out: property referencing missing type SysCurrency
    /*
    public static List<SysCurrency> SysCurrency
    {
        get
        {
            return _SysCurrency;
        }
        set
        {
            _SysCurrency = value;
        }
    }
    */

    // Commented out: property referencing missing type siUserSignOff
    /*
    public static List<siUserSignOff> siUserSignOff
    {
        get
        {
            return _siUserSignOff;
        }
        set
        {
            _siUserSignOff = value;
        }
    }
    */

    // Commented out: property referencing missing type SysTimeNotificationSetting
    /*
    public static SysTimeNotificationSetting SysScheduledTime
    {
        get
        {
            return _SysTimeNotificationSetting;
        }
        set
        {
            _SysTimeNotificationSetting = value;
        }
    }
    */

    public static int KeyIndexData
    {
        get
        {
            return _KeyIndexData;
        }
        set
        {
            _KeyIndexData = value;
        }
    }

    public static int KeyIndexSys
    {
        get
        {
            return _KeyIndexSys;
        }
        set
        {
            _KeyIndexSys = value;
        }
    }

    public static int KeyIndexGetConn
    {
        get
        {
            return _KeyIndexGetConn;
        }
        set
        {
            _KeyIndexGetConn = value;
        }
    }

    public static int KeyIndexGetConn3
    {
        get
        {
            return _KeyIndexGetConn3;
        }
        set
        {
            _KeyIndexGetConn3 = value;
        }
    }

    public static int KeyIndexGetConn4
    {
        get
        {
            return _KeyIndexGetConn4;
        }
        set
        {
            _KeyIndexGetConn4 = value;
        }
    }

    public static int KeyIndexGetConn5
    {
        get
        {
            return _KeyIndexGetConn5;
        }
        set
        {
            _KeyIndexGetConn5 = value;
        }
    }

    public static int KeyIndexGetConn6
    {
        get
        {
            return _KeyIndexGetConn6;
        }
        set
        {
            _KeyIndexGetConn6 = value;
        }
    }

    public static int KeyIndexGetConn7
    {
        get
        {
            return _KeyIndexGetConn7;
        }
        set
        {
            _KeyIndexGetConn7 = value;
        }
    }

    public static int KeyIndexGetConn8
    {
        get
        {
            return _KeyIndexGetConn8;
        }
        set
        {
            _KeyIndexGetConn8 = value;
        }
    }

    public static int KeyIndexGetConn9
    {
        get
        {
            return _KeyIndexGetConn9;
        }
        set
        {
            _KeyIndexGetConn9 = value;
        }
    }

    public static int KeyIndexGetConn10
    {
        get
        {
            return _KeyIndexGetConn10;
        }
        set
        {
            _KeyIndexGetConn10 = value;
        }
    }
}
