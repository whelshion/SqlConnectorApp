using System;
using System.Collections.Generic;
using System.Text;

namespace CaspClient.Common.Code
{
    public class ResultCode
    {
        public const string RESULT_OK = "1000";

        public const string RESULT_FAIL = "1001";

        public const string RESULT_MASTER_ACC_NOT_EXIST = "1010";

        public const string RESULT_MASTER_ACC_PWD_ERROR = "1011";

        public const string RESULT_MASTER_ACC_LOCKED = "1012";

        public const string RESULT_MASTER_ACC_EXPIRED = "1013";

        public const string RESULT_LOGIN_IP_ERROR = "1014";

        public const string RESULT_LOGIN_TIME_ERROR = "1015";

        public const string RESULT_ACC_MAX_PWD_ERROR = "1016";

        public const string RESULT_SLAVE_ACC_NOT_EXIST = "1017";

        public const string RESULT_SLAVE_ACC_PWD_ERROR = "1018";

        public const string RESULT_APP_ID_ERROR = "1019";

        public const string RESULT_CANOT_FIND_MASTER_BY_SLAVE = "1020";

        public const string RESULT_ACC_INACTIVE = "1021";

        public const string RESULT_ACC_IS_OFF = "1022";

        public const string RESULT_CANNOT_FIND_MOBILE_BY_ACC = "1040";

        public const string RESULT_INVALID_MOBILE = "1041";

        public const string RESULT_AUTH_ILLEGAL_TICKET = "1050";

        public const string RESULT_AUTH_EXPIRED_TICKET = "1051";

        public const string RESULT_HAS_NO_TICKET = "1052";

        public const string RESULT_TICKET_CHECK_FAIL = "1053";

        public const string RESULT_HAS_NO_SERVER = "1100";

        public const string RESULT_RESPONSE_IS_NULL = "1110";

        public const string RESULT_RES_NOT_EXIST = "2011";

        public const string RESULT_MASTER_ACC_IS_NULL = "2012";

        public const string RESULT_SLAVE_ACC_IS_NULL = "2013";

        public const string RESULT_PASSWORD_IS_NULL = "2014";

        public const string RESULT_PASSWORD_EXPIRED = "2015";

        public const string RESULT_SLAVE_ACC_EXPIRED = "2016";

        public const string RESULT_SLAVE_AUTH_NO_MATER = "2017";

        public const string RESULT_RES_NO_PERMISSION = "2018";

        public const string RESULT_USER_NOT_HAS_AUTHTYPE = "2019";

        public const string RESULT_POLICY_PARAM_ERROR = "4001";

        public const string RESULT_POLICY_AUTHMODE_FAIL = "4011";

        public const string RESULT_AUTH_PARAM_IS_NULL = "2001";

        public const string RESULT_AUTH_PARAM_ERROR = "2002";

        public const string RESULT_ACCOUNT_IS_NULL = "2004";

        public const string RESULT_AUTH_PARAM_NO_RESNUM = "2003";

        public const string RESULT_AUTHTYPE_NOT_EXIST = "2005";

        public const string RESULT_AUTH_CERT_IS_NULL = "2101";

        public const string RESULT_AUTH_CERT_FAIL = "2102";

        public const string RESULT_CENTER_AUTH_IS_NULL = "2031";

        public const string RESULT_CENTER_AUTH_IS_ERROR = "2032";

        public const string RESULT_AUTH_SCC_FAIL = "2201";

        public const string PASSERRORCOUNT = "n";
    }
}
