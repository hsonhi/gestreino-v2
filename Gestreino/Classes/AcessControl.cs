using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;

namespace Gestreino.Classes
{
    public class AcessControl
    {
        public static int GT_ATHLETES_LIST_VIEW_SEARCH = 38;
        public static int GT_ATHLETES_NEW = 39;
        public static int GT_ATHLETES_EDIT = 40;
        public static int GT_ATHLETES_ALTER_IMG = 41;
        public static int GT_ATHLETES_FILEMGR = 42;

        public static int GT_ATHLETES_IDENTIFICATION_LIST_VIEW_SEARCH = 43;
        public static int GT_ATHLETES_IDENTIFICATION_NEW = 44;
        public static int GT_ATHLETES_IDENTIFICATION_EDIT = 45;
        public static int GT_ATHLETES_IDENTIFICATION_DELETE = 46;

        public static int GT_ATHLETES_PROFESSIONAL_LIST_VIEW_SEARCH = 47;
        public static int GT_ATHLETES_PROFESSIONAL_NEW = 48;
        public static int GT_ATHLETES_PROFESSIONAL_EDIT = 49;
        public static int GT_ATHLETES_PROFESSIONAL_DELETE = 50;

        public static int GT_ATHLETES_FAM_LIST_VIEW_SEARCH = 51;
        public static int GT_ATHLETES_FAM_NEW = 52;
        public static int GT_ATHLETES_FAM_EDIT = 53;
        public static int GT_ATHLETES_FAM_DELETE = 54;

        public static int GT_ATHLETES_DEFICIENCY_LIST_VIEW_SEARCH = 55;
        public static int GT_ATHLETES_DEFICIENCY_NEW = 56;
        public static int GT_ATHLETES_DEFICIENCY_EDIT = 57;
        public static int GT_ATHLETES_DEFICIENCY_DELETE = 58;

        public static int GT_PLANS_BODYMASS_LIST_VIEW_SEARCH = 59;
        public static int GT_PLANS_BODYMASS_UPDATE = 60;
        public static int GT_PLANS_BODYMASS_DELETE = 61;

        public static int GT_PLANS_CARDIO_LIST_VIEW_SEARCH = 62;
        public static int GT_PLANS_CARDIO_UPDATE = 63;
        public static int GT_PLANS_CARDIO_DELETE = 64;

        public static int GT_QUEST_ANXIETY_LIST_VIEW_SEARCH = 65;
        public static int GT_QUEST_ANXIETY_UPDATE = 66;
        public static int GT_QUEST_ANXIETY_DELETE = 67;

        public static int GT_QUEST_SELFCONCEPT_LIST_VIEW_SEARCH = 68;
        public static int GT_QUEST_SELFCONCEPT_UPDATE = 69;
        public static int GT_QUEST_SELFCONCEPT_DELETE = 70;

        public static int GT_QUEST_CORONARYRISK_LIST_VIEW_SEARCH = 71;
        public static int GT_QUEST_CORONARYRISK_UPDATE = 72;
        public static int GT_QUEST_CORONARYRISK_DELETE = 73;

        public static int GT_QUEST_HEALTH_LIST_VIEW_SEARCH = 74;
        public static int GT_QUEST_HEALTH_UPDATE = 75;
        public static int GT_QUEST_HEALTH_DELETE = 76;

        public static int GT_QUEST_FLEXIBILITY_LIST_VIEW_SEARCH = 77;
        public static int GT_QUEST_FLEXIBILITY_UPDATE = 78;
        public static int GT_QUEST_FLEXIBILITY_DELETE = 79;

        public static int GT_QUEST_BODYCOMPOSITION_LIST_VIEW_SEARCH = 80;
        public static int GT_QUEST_BODYCOMPOSITION_UPDATE = 81;
        public static int GT_QUEST_BODYCOMPOSITION_DELETE = 82;

        public static int GT_QUEST_CARDIO_LIST_VIEW_SEARCH = 83;
        public static int GT_QUEST_CARDIO_UPDATE = 84;
        public static int GT_QUEST_CARDIO_DELETE = 85;

        public static int GT_QUEST_ELDERLY_LIST_VIEW_SEARCH = 86;
        public static int GT_QUEST_ELDERLY_UPDATE = 87;
        public static int GT_QUEST_ELDERLY_DELETE = 88;

        public static int GT_QUEST_FORCE_LIST_VIEW_SEARCH = 89;
        public static int GT_QUEST_FORCE_UPDATE = 90;
        public static int GT_QUEST_FORCE_DELETE = 91;

        public static int GT_QUEST_FUNCTIONAL_LIST_VIEW_SEARCH = 92;
        public static int GT_QUEST_FUNCTIONAL_UPDATE = 93;
        public static int GT_QUEST_FUNCTIONAL_DELETE = 94;

        public static int GT_SEARCH_PRESCRIPTIONS_LIST_VIEW_SEARCH = 95;
        public static int GT_SEARCH_EVALUATIONS_LIST_VIEW_SEARCH = 96;
        public static int GT_SEARCH_MEDIUMWEIGHT_LIST_VIEW_SEARCH = 97;
        public static int GT_SEARCH_ANALYSIS_LIST_VIEW_SEARCH = 98;
        public static int GT_SEARCH_RANKING_LIST_VIEW_SEARCH = 99;
        public static int GT_SEARCH_OTHERS_LIST_VIEW_SEARCH = 100;

        public static int GT_REPORTS_LIST_VIEW_SEARCH = 101;

        public static int GT_ADM_CONFIGURATIONS = 102;

        public static int GROUP_ADM = 1;
        public static int GROUP_INST = 2; 

        public static bool Authorized(int atom)
        {
            var Authorized = false;

            var claimsIdentity = System.Web.HttpContext.Current.User.Identity as ClaimsIdentity;

            var atoms = claimsIdentity.Claims.Where(c => c.Type == "http://schemas.microsoft.com/ws/2008/06/identity/claims/role").ToList();

            foreach (var i in atoms)
            {
                if (int.Parse(i.Value) == atom && isGROUP_INST()) Authorized = true; 
            }
            return Authorized;
        }
        public static bool isGROUP_ADM()
        {
            var Authorized = false;

            var claimsIdentity = System.Web.HttpContext.Current.User.Identity as ClaimsIdentity;

            var groups = claimsIdentity.Claims.Where(c => c.Type == "http://schemas.microsoft.com/ws/2008/06/identity/claims/primarygroupsid").ToList();

            foreach (var i in groups)
            {
                if (int.Parse(i.Value) == GROUP_ADM) Authorized = true;
            }
            return Authorized;
        }
        public static bool isGROUP_INST()
        {
            var Authorized = false;

            var claimsIdentity = System.Web.HttpContext.Current.User.Identity as ClaimsIdentity;

            var groups = claimsIdentity.Claims.Where(c => c.Type == "http://schemas.microsoft.com/ws/2008/06/identity/claims/primarygroupsid").ToList();

            foreach (var i in groups)
            {
                if (int.Parse(i.Value) == GROUP_INST) Authorized = true;
            }
            return Authorized;
        }
        public static int? getUserGroup()
        {
            //Fetch one only
            int? group = null;

            var claimsIdentity = System.Web.HttpContext.Current.User.Identity as ClaimsIdentity;

            var groups = claimsIdentity.Claims.Where(c => c.Type == "http://schemas.microsoft.com/ws/2008/06/identity/claims/primarygroupsid").ToList();

            foreach (var i in groups)
            {
                group=(int.Parse(i.Value));
            }
            return group;
        }
        public static string getLoginInfo(string claim)
        {
            var claimsIdentity = System.Web.HttpContext.Current.User.Identity as ClaimsIdentity;
            var ApplicationId = claimsIdentity.FindFirst(ClaimTypes.Sid) != null ? claimsIdentity.FindFirst(ClaimTypes.Sid).Value : string.Empty;
            var ApplicationName = claimsIdentity.FindFirst(ClaimTypes.GivenName) != null ? claimsIdentity.FindFirst(ClaimTypes.GivenName).Value : string.Empty;
            var ProfileImage = claimsIdentity.FindFirst(ClaimTypes.UserData) != null ? claimsIdentity.FindFirst(ClaimTypes.UserData).Value : string.Empty;

            switch (claim)
            {
                case "Sid":
                    claim = ApplicationId;
                    break;
                case "GivenName":
                    claim = ApplicationName;
                    break;
                case "UserData":
                    claim = ProfileImage;
                    break;
                default:
                    break;
            }

            return claim;
        }
    }
}