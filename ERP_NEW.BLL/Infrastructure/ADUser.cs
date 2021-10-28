using System;
using System.Collections.Generic;
using System.DirectoryServices.AccountManagement;
using System.Windows;

namespace ERP_NEW.BLL.Infrastructure
{
    public class ADUser
    {
        #region Переменные

        private static readonly string sDomain = "domain.local";
        private static readonly string sDefaultOU = "OU=test,DC=domain,DC=local";
        private static readonly string sDefaultRootOU = "DC=domain,DC=local";
        private static readonly string sServiceUser = "username";
        private static readonly string sServicePassword = "p@$$w0rd";

        #endregion

        #region Методы проверки

        public static string CurrentDC()
        {
            try
            {
                using (var context = new PrincipalContext(ContextType.Domain))
                {
                    var DC = context.ConnectedServer;
                    return DC;
                }
            }
            catch
            {
                //MessageBox.Show("Текущий DC не определен, необходимо указать вручную.");
                return null;
            }
        }

        /// <summary>
        /// Проверка имени пользователя и пароля
        /// </summary>
        /// <param name="sUserName">Имя пользователя</param>
        /// <param name="sPassword">Пароль</param>
        /// <returns>Возвращает true, если имя и пароль верны</returns>
        public static bool ValidateCredentials(string sUserName, string sPassword)
        {
            return GetPrincipalContext().ValidateCredentials(sUserName, sPassword);
        }

        /// <summary>
        /// Проверка срока действия учетной записи
        /// </summary>
        /// <param name="sUserName">Имя пользователя</param>
        /// <returns>Возвращает true, если срок действия истек</returns>
        public static bool IsUserExpired(string sUserName)
        {
            return GetUser(sUserName).AccountExpirationDate == null;
        }

        /// <summary>
        /// Проверка существования пользователя в AD
        /// </summary>
        /// <param name="sUserName">Имя пользователя</param>
        /// <returns>Возвращает true, если пользователь существует</returns>
        public static bool IsUserExisiting(string sUserName)
        {
            return GetUser(sUserName) != null;
        }

        /// <summary>
        /// Проверяет блокировку пользователя
        /// </summary>
        /// <param name="sUserName">Имя пользователя</param>
        /// <returns>Возвращает true, если учетная запись заблокирована</returns>
        public static bool IsAccountLocked(string sUserName)
        {
            return GetUser(sUserName).IsAccountLockedOut();
        }

        #endregion

        #region Методы поиска

        /// <summary>
        /// Получить указанного пользователя Active Directory
        /// </summary>
        /// <param name="sUserName">Имя пользователя для извлечения</param>
        /// <returns>Объект UserPrincipal</returns>
        public static UserPrincipal GetUser(string sUserName)
        {
            PrincipalContext oPrincipalContext = GetPrincipalContext();
            return UserPrincipal.FindByIdentity(oPrincipalContext, IdentityType.SamAccountName, sUserName);
        }

        /// <summary>
        /// Получить группу Active Directory
        /// </summary>
        /// <param name="sGroupName">Группа для получения</param>
        /// <returns>Возвращает объект GroupPrincipal</returns>
        public static GroupPrincipal GetGroup(string sGroupName)
        {
            PrincipalContext oPrincipalContext = GetPrincipalContext();
            return GroupPrincipal.FindByIdentity(oPrincipalContext, sGroupName);
        }

        #endregion

        #region Методы управления учетными записями

        /// <summary>
        /// Установка нового пароля
        /// </summary>
        /// <param name="sUserName">Имя пользователя</param>
        /// <param name="sNewPassword">Новый пароль</param>
        /// <param name="sMessage">Описание ошибки (если возникла)</param>
        public static void SetUserPassword(string sUserName, string sNewPassword, out string sMessage)
        {
            try
            {
                GetUser(sUserName).SetPassword(sNewPassword);
                sMessage = string.Empty;
            }
            catch (Exception ex)
            {
                sMessage = ex.Message;
            }
        }

        /// <summary>
        /// Включить учетную запись пользователя
        /// </summary>
        /// <param name="sUserName">Имя пользователя</param>
        public static void EnableUserAccount(string sUserName)
        {
            using (UserPrincipal oUserPrincipal = GetUser(sUserName))
            {
                oUserPrincipal.Enabled = true;
                oUserPrincipal.Save();
            }
        }

        /// <summary>
        /// Отключить учетную запись пользователя
        /// </summary>
        /// <param name="sUserName">Имя пользователя</param>
        public static void DisableUserAccount(string sUserName)
        {
            using (UserPrincipal oUserPrincipal = GetUser(sUserName))
            {
                oUserPrincipal.Enabled = false;
                oUserPrincipal.Save();
            }
        }

        /// <summary>
        /// Установить признак истечения срока действия пароля
        /// </summary>
        /// <param name="sUserName">Имя пользователя с "истекающим" сроком действия</param>
        public static void ExpireUserPassword(string sUserName)
        {
            using (UserPrincipal oUserPrincipal = GetUser(sUserName))
            {
                oUserPrincipal.ExpirePasswordNow();
                oUserPrincipal.Save();
            }
        }

        /// <summary>
        /// Разблокировка заблокированного пользователя
        /// </summary>
        /// <param name="sUserName">Имя пользователя для снятия lock'а</param>
        public static void UnlockUserAccount(string sUserName)
        {
            using (UserPrincipal oUserPrincipal = GetUser(sUserName))
            {
                oUserPrincipal.UnlockAccount();
                oUserPrincipal.Save();
            }
        }

        /// <summary>
        /// Создание нового пользователя Active Directory
        /// </summary>
        /// <param name="sOU">OU создания нового пользователя</param>
        /// <param name="sUserName">Имя пользователя</param>
        /// <param name="sPassword">Пароль</param>
        /// <param name="sGivenName">Имя</param>
        /// <param name="sSurName">Фамилия</param>
        /// <returns>Возвращает объект UserPrincipal</returns>
        public static UserPrincipal CreateNewUser(string sOU, string sUserName, string sPassword, string sGivenName,
            string sSurName)
        {
            if (IsUserExisiting(sUserName))
                return GetUser(sUserName);
            else
            {
                PrincipalContext oPrincipalContext = GetPrincipalContext(sOU);

                UserPrincipal oUserPrincipal = new UserPrincipal(oPrincipalContext, sUserName, sPassword, true)
                {
                    UserPrincipalName = sUserName,
                    GivenName = sGivenName,
                    Surname = sSurName
                };

                oUserPrincipal.Save();

                return oUserPrincipal;
            }
        }

        /// <summary>
        /// Удаление пользователя Active Directory
        /// </summary>
        /// <param name="sUserName">Имя пользователя для удаления</param>
        /// <returns>Возвращает true, если удаление прошло успешно</returns>
        public static bool DeleteUser(string sUserName)
        {
            try
            {
                using (UserPrincipal oUserPrincipal = GetUser(sUserName))
                {
                    oUserPrincipal.Delete();
                }
                return true;
            }
            catch
            {
                return false;
            }
        }

        #endregion

        #region Методы для работы с группами

        /// <summary>
        /// Создание новой группы Active Directory
        /// </summary>
        /// <param name="sOU">OU, где будет создана новая группа</param>
        /// <param name="sGroupName">Имя группы</param>
        /// <param name="sDescription">Описание группы</param>
        /// <param name="oGroupScope">Область группы</param>
        /// <param name="bSecurityGroup">True - группа безопасности, false - группа рассылки</param>
        /// <returns>Возвращает объект GroupPrincipal</returns>
        public static GroupPrincipal CreateNewGroup(string sOU, string sGroupName, string sDescription,
            GroupScope oGroupScope, bool bSecurityGroup)
        {
            PrincipalContext oPrincipalContext = GetPrincipalContext(sOU);

            GroupPrincipal oGroupPrincipal = new GroupPrincipal(oPrincipalContext, sGroupName)
            {
                Description = sDescription,
                GroupScope = oGroupScope,
                IsSecurityGroup = bSecurityGroup
            };

            oGroupPrincipal.Save();

            return oGroupPrincipal;
        }

        /// <summary>
        /// Добавляет пользователя в указанную группу
        /// </summary>
        /// <param name="sUserName">Имя добавляемого пользователя</param>
        /// <param name="sGroupName">Группа</param>
        /// <returns>В случае успеха возвращает true</returns>
        public static bool AddUserToGroup(string sUserName, string sGroupName)
        {
            try
            {
                using (UserPrincipal oUserPrincipal = GetUser(sUserName))
                using (GroupPrincipal oGroupPrincipal = GetGroup(sGroupName))
                {
                    if (oUserPrincipal != null && oGroupPrincipal != null)
                    {
                        if (!IsUserGroupMember(sUserName, sGroupName))
                        {
                            oGroupPrincipal.Members.Add(oUserPrincipal);
                            oGroupPrincipal.Save();
                        }
                    }
                }
                return true;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// Удаляет пользователя из указанной группы
        /// </summary>
        /// <param name="sUserName">Имя удаляемого пользователя</param>
        /// <param name="sGroupName">Группа</param>
        /// <returns>Возвращает true в случае успеха</returns>
        public static bool RemoveUserFromGroup(string sUserName, string sGroupName)
        {
            try
            {
                using (UserPrincipal oUserPrincipal = GetUser(sUserName))
                using (GroupPrincipal oGroupPrincipal = GetGroup(sGroupName))
                {
                    if (oUserPrincipal != null && oGroupPrincipal != null)
                    {
                        if (IsUserGroupMember(sUserName, sGroupName))
                        {
                            oGroupPrincipal.Members.Remove(oUserPrincipal);
                            oGroupPrincipal.Save();
                        }
                    }
                }
                return true;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// Проверка на вхождение пользователя в группу
        /// </summary>
        /// <param name="sUserName">Имя пользователя</param>
        /// <param name="sGroupName">Группа</param>
        /// <returns>Возвращает true, если пользователь входит в группу</returns>
        public static bool IsUserGroupMember(string sUserName, string sGroupName)
        {
            bool bResult = false;

            using (UserPrincipal oUserPrincipal = GetUser(sUserName))
            using (GroupPrincipal oGroupPrincipal = GetGroup(sGroupName))
            {
                if (oUserPrincipal != null && oGroupPrincipal != null)
                {
                    bResult = oGroupPrincipal.Members.Contains(oUserPrincipal);
                }
            }

            return bResult;
        }

        /// <summary>
        /// Возвращает список групп, в которых состоит пользователь
        /// </summary>
        /// <param name="sUserName">Имя пользователя</param>
        /// <returns>Возвращает List со всеми группами пользователя</returns>
        public static List<string> GetUserGroups(string sUserName)
        {
            List<string> myItems = new List<string>();
            UserPrincipal oUserPrincipal = GetUser(sUserName);

            using (PrincipalSearchResult<Principal> oPrincipalSearchResult = oUserPrincipal.GetGroups())
            {
                foreach (Principal oResult in oPrincipalSearchResult)
                {
                    myItems.Add(oResult.Name);
                }
            }

            return myItems;
        }

        /// <summary>
        /// Возвращает список авторизационных групп пользователя
        /// </summary>
        /// <param name="sUserName">Имя пользователя</param>
        /// <returns>Возвращает List содержащий авторизационные группы пользователя</returns>
        public static List<string> GetUserAuthorizationGroups(string sUserName)
        {
            List<string> myItems = new List<string>();
            UserPrincipal oUserPrincipal = GetUser(sUserName);

            using (PrincipalSearchResult<Principal> oPrincipalSearchResult = oUserPrincipal.GetAuthorizationGroups())
            {
                foreach (Principal oResult in oPrincipalSearchResult)
                {
                    myItems.Add(oResult.Name);
                }
            }

            return myItems;
        }

        #endregion

        #region Вспомогательные методы

        /// <summary>
        /// Получить базовый основной контекст
        /// </summary>
        /// <returns>Возвращает объект PrincipalContext</returns>
        public static PrincipalContext GetPrincipalContext()
        {
            return new PrincipalContext(ContextType.Domain, sDomain, sDefaultRootOU, sServiceUser, sServicePassword);
        }

        /// <summary>
        /// Получить основной контекст указанного OU
        /// </summary>
        /// <param name="sOU">OU для которого нужно получить основной контекст</param>
        /// <returns>Возвращает объект PrincipalContext</returns>
        public static PrincipalContext GetPrincipalContext(string sOU)
        {
            return new PrincipalContext(ContextType.Domain, sDomain, string.IsNullOrEmpty(sOU) ? sDefaultOU : sOU,
                sServiceUser, sServicePassword);
        }

        #endregion
    }
}

//      Now this is how to use it.

//ADMethodsAccountManagement ADMethods = new ADMethodsAccountManagement();

//UserPrincipal myUser = ADMethods.GetUser("Test");
//myUser.GivenName = "Given Name";
//myUser.Surname = "Surname";
//myUser.MiddleName = "Middle Name";
//myUser.EmailAddress = "Email Address";
//myUser.EmployeeId = "Employee ID";
//myUser.Save();