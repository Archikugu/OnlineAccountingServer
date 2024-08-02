using OnlineAccountingServer.Domain.AppEntities.Identity;

namespace OnlineAccountingServer.Domain.Roles
{
    public sealed class RoleList
    {
        public static List<AppRole> GetStaticRoles()
        {
            List<AppRole> appRoles = new List<AppRole>
            {
                #region UCOA

                new AppRole(
                    title: UCOA,
                    code: UCOACreateCode,
                    name: UCOACreateName),

                new AppRole(
                    title: UCOA,
                    code: UCOAUpdateCode,
                    name: UCOAUpdateName),

                new AppRole(
                    title: UCOA,
                    code: UCOARemoveCode,
                    name: UCOARemoveName),

                new AppRole(
                    title: UCOA,
                    code: UCOAReadCode,
                    name: UCOAReadName)

                #endregion
            };
            return appRoles;
        }

        #region RoleTitleNames
        public static string UCOA = "Hesap Planı";
        #endregion

        #region RoleCodeAndNames
        public static string UCOACreateCode = "UCOA.Create";
        public static string UCOACreateName = "Hesap Planı Kayıt";

        public static string UCOAUpdateCode = "UCOA.Update";
        public static string UCOAUpdateName = "Hesap Planı Güncelle";

        public static string UCOARemoveCode = "UCOA.Remove";
        public static string UCOARemoveName = "Hesap Planı Sil";

        public static string UCOAReadCode = "UCOA.Read";
        public static string UCOAReadName = "Hesap Planı Oku";
        #endregion
    }
}
