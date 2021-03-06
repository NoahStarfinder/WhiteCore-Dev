﻿namespace WhiteCore.Modules.Web.Translators
{
    public class SpanishTranslation : ITranslator
    {
        public string LanguageName
        {
            get { return "es"; }
        }

        public string GetTranslatedString(string key)
        {
            switch (key)
            {
                // Generic
                case "No": return "No";
                case "Yes": return "Sí";
                case "Submit": return "Enviar";
                case "Accept": return "Aceptar";
                case "Save": return "Guardar";
                case "FirstText": return "Primera";
                case "BackText": return "Volver";
                case "NextText": return "Siguiente";
                case "LastText": return "Última";
                case "CurrentPageText": return "La página actual";
                case "MoreInfoText": return "Más info";
                case "NoDetailsText": return "No se encontraron datos...";
            case "ObjectNameText": return "Objeto";
            case "LocationText": return "Ubicación";
            case "UUIDText": return "UUID";
            case "DetailsText": return "Descripción";
            case "NotesText": return "Notas";
            case "SaveUpdates": return "Guardar cambios";
            case "ActiveText": return "Activo";
            case "CheckedText": return "Comprobado";
            case "CategoryText": return "Categoria";
            case "SummaryText": return "Resumen";
                
                // Status information
                case "GridStatus": return "Estato de la Grid";
                case "Online": return "En Linea";
                case "Offline": return "Offline";
                case "TotalUserCount": return "total de Usuarios";
                case "TotalRegionCount": return "Cuenta Total Región";
                case "UniqueVisitors": return "Visitantes únicos últimos 30 días";
                case "OnlineNow": return "En línea ahora";
                case "HyperGrid": return "HyperGrid (HG)";
                case "Voice": return "Voz";
                case "Currency": return "Moneda";
                case "Disabled": return "Discapacitado";
                case "Enabled": return "Habilitado";
                case "News": return "Nuevas";
                case "Region": return "Región";

                //User login
                case "Login": return "Iniciar sesión";
                case "UserName": return "Nombre de usuario";
                case "UserNameText": return "Nombre de usuario";
                case "Password": return "Contraseña";
                case "PasswordText": return "Contraseña";
                case "PasswordConfirmation": return "Password Confirmation";
                case "ForgotPassword": return "¿Olvidó su contraseña?";


                // Special windows
                case "SpecialWindowTitleText": return "Special Info Window Title";
                case "SpecialWindowTextText": return "Special Info Window Text";
                case "SpecialWindowColorText": return "Special Info Window Color";
                case "SpecialWindowStatusText": return "Special Info Window Status";
                case "WelcomeScreenManagerFor": return "Welcome Screen Manager For";
                case "ChangesSavedSuccessfully": return "Changes Saved Successfully";

                // User registration
                case "AvatarNameText": return "Avatar Name";
                case "AvatarScopeText": return "Avatar Scope ID";
                case "FirstNameText": return "Your First Name";
                case "LastNameText": return "Your Last Name";
                case "UserAddressText": return "Your Address";
                case "UserZipText": return "Your Zip Code";
                case "UserCityText": return "Your City";
                case "UserCountryText": return "Your Country";
                case "UserDOBText": return "Your Date Of Birth (Month Day Year)";
                case "UserEmailText": return "Your Email";
                case "UserHomeRegionText": return "Región Home";
                case "RegistrationText": return "Avatar registration";
                case "RegistrationsDisabled": return "Registrations are currently disabled, please try again soon.";
                case "TermsOfServiceText": return "Terms of Service";
                case "TermsOfServiceAccept": return "Do you accept the Terms of Service as detailed above?";
                case "AvatarNameError": return "No ha introducido el nombre de avatar!";
                case "AvatarPasswordError": return "Contraseña está vacío o que no coincida con!";
                case "AvatarEmailError": return "Se requiere una dirección de correo electrónico para recuperar la contraseña! ('none' si no se conoce)";
                case "AvatarNameSpacingError": return "Su nombre avatar debe ser 'Nombre Apellido'!";

                // news
                case "OpenNewsManager":
                    return "Open the news manager";
                case "NewsManager":
                    return "News Manager";
                case "EditNewsItem":
                    return "Edit news item";
                case "AddNewsItem":
                    return "Add new news item";
                case "DeleteNewsItem":
                    return "Delete news item";
                case "NewsDateText":
                    return "News Date";
                case "NewsTitleText":
                    return "News Title";
                case "NewsItemTitle":
                    return "News Item Title";
                case "NewsItemText":
                    return "News Item Text";
                case "AddNewsText":
                    return "Add News";
                case "DeleteNewsText":
                    return "Delete News";
                case "EditNewsText":
                    return "Edit News";

                // Users
                case "UserProfileFor":
                    return "User Profile For";
                case "UsersGroupsText": return "Grupos unidos";
                case "GroupNameText": return "Grupo";
                case "UsersPicksText": return "Selecciones para";
                case "ResidentSince":
                    return "Resident Since";
                case "AccountType":
                    return "Account Type";
                case "PartnersName":
                    return "Partner's Name";
                case "AboutMe":
                    return "About Me";
                case "IsOnlineText":
                    return "User Status";
                case "OnlineLocationText":
                    return "User Location";

                case "RegionInformationText":
                    return "Region Information";
                case "OwnerNameText":
                    return "Owner Name";
                case "RegionLocationText":
                    return "Region Location";
                case "RegionSizeText":
                    return "Region Size";
                case "RegionNameText":
                    return "Region Name";
                case "RegionTypeText":
                    return "Region Type";
                case "RegionTerrainText":
                    return "Región Terreno";
                case "ParcelsInRegionText":
                    return "Parcels In Region";
                case "ParcelNameText":
                    return "Parcel Name";
                case "ParcelOwnerText":
                    return "Parcel Owner's Name";

                // Region Page
                case "RegionInfoText":
                    return "Region Info";
                case "RegionListText":
                    return "Region List";
                case "RegionLocXText":
                    return "Region X";
                case "RegionLocYText":
                    return "Region Y";
                case "SortByLocX":
                    return "Sort By Region X";
                case "SortByLocY":
                    return "Sort By Region Y";
                case "SortByName":
                    return "Sort By Region Name";
                case "RegionMoreInfo":
                    return "More Information";
                case "RegionMoreInfoTooltips":
                    return "More info about";
                case "OnlineUsersText":
                    return "Online Users";
                case "RegionOnlineText":
                    return "Region Status";
                case "RegionMaturityText":
                    return "Access Rating";
                case "NumberOfUsersInRegionText":
                    return "Number of Users in region";

                // Menu Buttons
                case "MenuHome": return "Inicio";
                case "MenuLogin": return "Iniciar sesión";
                case "MenuLogout": return "Salir";
                case "MenuRegister": return "Registro";
                case "MenuForgotPass": return "Olvidó su contraseña?";
                case "MenuNews": return "Noticias";
                case "MenuWorld": return "Mundial";
                case "MenuWorldMap": return "Mapa del Mundo";
                case "MenuRegion": return "lista Región";
                case "MenuUser": return "User";
                case "MenuOnlineUsers": return "Online Users";
                case "MenuUserSearch": return "User Search";
                case "MenuRegionSearch": return "Region Search";
                case "MenuChat": return "Chat";
                case "MenuHelp": return "Help";
                case "MenuChangeUserInformation": return "Change User Information";
                case "MenuWelcomeScreenManager": return "Welcome Screen Manager";
                case "MenuNewsManager": return "News Manager";
                case "MenuUserManager": return "User Manager";
                case "MenuFactoryReset": return "Factory Reset";
                case "ResetMenuInfoText": return "Resets the menu items back to the most updated defaults";
                case "ResetSettingsInfoText": return "Resets the Web Interface settings back to the most updated defaults";
                case "MenuPageManager": return "Page Manager";
                case "MenuSettingsManager": return "Settings Manager";
                case "MenuManager": return "Manejo";
                case "MenuSettings": return "Ajustes";
                case "MenuRegionManager": return "Gerente de Región";
                case "MenuManagerSimConsole": return "Simulador de consola";
                case "MenuPurchases": return "Usuario compra";
                case "MenuMyPurchases": return "Mis Compras";
                case "MenuTransactions": return "Transacciones de usuario";
                case "MenuMyTransactions": return "Mis Transacciones";
                case "MenuStatistics": return "Visor de estadísticas";
                case "MenuGridSettings": return "Configuración de la cuadrícula";

                // Tooltips Menu Buttons
                case "TooltipsMenuHome": return "Inicio";
                case "TooltipsMenuLogin": return "Iniciar sesión";
                case "TooltipsMenuLogout": return "Salir";
                case "TooltipsMenuRegister": return "Registro";
                case "TooltipsMenuForgotPass": return "Olvidó su contraseña?";
                case "TooltipsMenuNews": return "Noticias";
                case "TooltipsMenuWorld": return "Mundial";
                case "TooltipsMenuWorldMap": return "Mapa del Mundo";
                case "TooltipsMenuUser": return "User";
                case "TooltipsMenuOnlineUsers": return "Online Users";
                case "TooltipsMenuUserSearch": return "User Search";
                case "TooltipsMenuRegionSearch": return "Region Search";
                case "TooltipsMenuChat": return "Chat";
                case "TooltipsMenuHelp": return "Help";
                case "TooltipsMenuChangeUserInformation": return "Change User Information";
                case "TooltipsMenuWelcomeScreenManager": return "Welcome Screen Manager";
                case "TooltipsMenuNewsManager": return "News Manager";
                case "TooltipsMenuUserManager": return "User Manager";
                case "TooltipsMenuFactoryReset": return "Factory Reset";
                case "TooltipsMenuPageManager": return "Page Manager";
                case "TooltipsMenuSettingsManager": return "Settings Manager";
                case "TooltipsMenuManager": return "Admin Management";
                case "TooltipsMenuSettings": return "WebUI Ajustes";
                case "TooltipsMenuRegionManager": return "Región crear / editar";
                case "TooltipsMenuManagerSimConsole": return "Consola Simulador Online";
                case "TooltipsMenuPurchases": return "Información Realizar compra";
                case "TooltipsMenuTransactions": return "La información de transacciones";
                case "TooltipsMenuStatistics": return "Visor de estadísticas";
                case "TooltipsMenuGridSettings": return "Configuración de la cuadrícula";

                // Menu Region
                case "MenuRegionTitle": return "Región";
                case "MenuParcelTitle": return "Parcel";
                case "MenuOwnerTitle": return "Owner";
                case "TooltipsMenuRegion": return "Detalles Región";
                case "TooltipsMenuParcel": return "Parcelas Región";
                case "TooltipsMenuOwner": return "Propietario Estate";

                // Menu Profile
                case "MenuProfileTitle": return "Profil";
                case "MenuGroupTitle": return "Group";
                case "MenuPicksTitle": return "Picks";
                case "MenuRegionsTitle": return "Regiones";
                case "TooltipsMenuProfile": return "Perfil del usuario";
                case "TooltipsMenuGroups": return "Grupos de usuarios";
                case "TooltipsMenuPicks": return "Selecciones de usuario";
                case "UserGroupNameText": return "Grupo de usuarios";
                case "TooltipsMenuRegions": return "Regiones usuario";
                case "PickNameText": return "Escoja el nombre";
                case "PickRegionText": return "Ubicación";

                // Urls
                case "WelcomeScreen":
                    return "Welcome Screen";

                // Tooltips Urls
                case "TooltipsWelcomeScreen":
                    return "Welcome Screen";
                case "TooltipsWorldMap":
                    return "World Map";

                // Style Switcher
                case "styles1":
                    return "Default Minimalist";
                case "styles2":
                    return "Light Degarde";
                case "styles3":
                    return "Blue Night";
                case "styles4":
                    return "Dark Degrade";
                case "styles5":
                    return "Luminus";

                case "StyleSwitcherStylesText":
                    return "Styles";
                case "StyleSwitcherLanguagesText":
                    return "Languages";
                case "StyleSwitcherChoiceText":
                    return "Choice";

                // Language Switcher Tooltips
                case "en":
                    return "Inglés";
                case "fr":
                    return "Francés";
                case "de":
                    return "Alemán";
                case "it":
                    return "Italiano";
                case "es":
                    return "Español";
                case "nl":
                    return "Holandés";

                // Index Page
                case "HomeText":
                    return "Home";
                case "HomeTextWelcome":
                    return "This is our New Virtual World! Join us now, and make a difference!";
                case "HomeTextTips":
                    return "New presentations";
                case "WelcomeToText":
                    return "Welcome to";

                // World Map Page
                case "WorldMap":
                    return "World Map";
                case "WorldMapText":
                    return "Full Screen";

                // Chat Page
                case "ChatText":
                    return "Chat Support";

                // Help Page
                case "HelpText":
                    return "Ayudar";
                case "HelpViewersConfigText":
                    return "Configuración del Visor";
                case "AngstromViewer":
                    return "Angstrom Viewer";
                case "AstraViewer":
                    return "Astra Viewer";
                case "FirestormViewer":
                    return "Firestorm Viewer";
                case "KokuaViewer":
                    return "Kokua Viewer";
                case "ImprudenceViewer":
                    return "Imprudence Viewer";
                case "PhoenixViewer":
                    return "Phoenix Viewer";
                case "SingularityViewer":
                    return "Singularity Viewer";
                case "VoodooViewer":
                    return "Voodoo Viewer";
                case "ZenViewer":
                    return "Zen Viewer";

                //Logout page
                case "LoggedOutSuccessfullyText":
                    return "You have been logged out successfully.";
                case "Logout":
                    return "Logout";

                //Change user information page
                case "ChangeUserInformationText":
                    return "Change User Information";
                case "ChangePasswordText":
                    return "Change Password";
                case "NewPasswordText":
                    return "New Password";
                case "NewPasswordConfirmationText":
                    return "New Password (Confirmation)";
                case "ChangeEmailText":
                    return "Change Email Address";
                case "NewEmailText":
                    return "New Email Address";
                case "DeleteUserText":
                    return "Delete My Account";
                case "DeleteText":
                    return "Delete";
                case "DeleteUserInfoText":
                    return
                        "This will remove all information about you in the grid and remove your access to this service. If you wish to continue, enter your name and password and click Delete.";
                case "EditText":
                    return "Edit";
                case "EditUserAccountText":
                    return "Edit User Account";

                //Maintenance page
                case "WebsiteDownInfoText":
                    return "Website is currently down, please try again soon.";
                case "WebsiteDownText":
                    return "Website offline";

                //http_404 page
                case "Error404Text":
                    return "Error code";
                case "Error404InfoText":
                    return "404 Page Not Found";
                case "HomePage404Text":
                    return "home page";

                //http_505 page
                case "Error505Text":
                    return "Error code";
                case "Error505InfoText":
                    return "505 Internal Server Error";
                case "HomePage505Text":
                    return "home page";

                //user_search page
                case "Search":
                    return "Search";
                case "SearchText":
                    return "Search";
                case "SearchForUserText":
                    return "Search For A User";
                case "UserSearchText":
                    return "User Search";
                case "SearchResultForUserText":
                    return "Search Result For User";

                //region_search page
                case "SearchForRegionText":
                    return "Search For A Region";
                case "RegionSearchText":
                    return "Region Search";
                case "SearchResultForRegionText":
                    return "Search Result For Region";

                //Edit user page
                case "AdminDeleteUserText":
                    return "Delete User";
                case "AdminDeleteUserInfoText":
                    return "This deletes the account and destroys all information associated with it.";
                case "BanText":
                    return "Ban";
                case "UnbanText":
                    return "Unban";
                case "AdminTempBanUserText":
                    return "Temp Ban User";
                case "AdminTempBanUserInfoText":
                    return "This blocks the user from logging in for the set amount of time.";
                case "AdminBanUserText":
                    return "Ban User";
                case "AdminBanUserInfoText":
                    return "This blocks the user from logging in until the user is unbanned.";
                case "AdminUnbanUserText":
                    return "Unban User";
                case "AdminUnbanUserInfoText":
                    return "Removes temporary and permanent bans on the user.";
                case "AdminLoginInAsUserText":
                    return "Login as User";
                case "AdminLoginInAsUserInfoText":
                    return
                        "You will be logged out of your admin account, and logged in as this user, and will see everything as they see it.";
                case "TimeUntilUnbannedText":
                    return "Time until user is unbanned";
                case "DaysText":
                    return "Days";
                case "HoursText":
                    return "Hours";
                case "MinutesText":
                    return "Minutes";
                case "EdittingText":
                    return "Editting";
                case "BannedUntilText":
                    return "User banned until:";
                case "KickAUserText":
                    return "Kick A User (Logs them out within 30 seconds)";
                case "KickMessageText":
                    return "Message To User";
                case "KickUserText":
                    return "Kick User";

                //factory_reset
                case "FactoryReset":
                    return "Factory Reset";
                case "ResetMenuText":
                    return "Reset Menu To Factory Defaults";
                case "ResetSettingsText":
                    return "Reset Web Settings (Settings Manager page) To Factory Defaults";
                case "Reset":
                    return "Reset";
                case "Settings":
                    return "Settings";
                case "Pages":
                    return "Pages";
                case "DefaultsUpdated":
                    return
                        "defaults updated, go to Factory Reset to update or Settings Manager to disable this warning.";

                //page_manager
                case "PageManager":
                    return "Page Manager";
                case "SaveMenuItemChanges":
                    return "Save Menu Item";
                case "SelectItem":
                    return "Select Item";
                case "DeleteItem":
                    return "Delete Item";
                case "AddItem":
                    return "Add Item";
                case "PageLocationText":
                    return "Page Location";
                case "PageIDText":
                    return "Page ID";
                case "PagePositionText":
                    return "Page Position";
                case "PageTooltipText":
                    return "Page Tooltip";
                case "PageTitleText":
                    return "Page Title";
                case "RequiresLoginText":
                    return "Requires Login To View";
                case "RequiresLogoutText":
                    return "Requires Logout To View";
                case "RequiresAdminText":
                    return "Requires Admin To View";

                // grid settings
                case "GridSettingsManager": return "Rejilla Settings Manager ";
                case "GridnameText": return "Nombre de cuadrícula ";
                case "GridnickText": return "Apodo Cuadrícula ";
                case "WelcomeMessageText": return "Ingresa mensajes de bienvenida ";
                case "SystemEstateNameText": return "Nombre raíces Sistema ";
                case "SystemEstateOwnerText": return "Sistema de nombre de propietario de la finca";

                //settings manager page
                case "WebRegistrationText":
                    return "Registros Web permitidas";
                case "GridCenterXText":
                    return "Grid Center Location X";
                case "GridCenterYText":
                    return "Grid Center Location Y";
                case "GoogleMapAPIKeyText":
                    return "Google Maps API Key";
                case "GoogleMapAPIKeyHelpText":
                    return "The google maps v2 api key generated here";
                case "SettingsManager":
                    return "Settings Manager";
                case "IgnorePagesUpdatesText":
                    return "Ignore pages update warning until next update";
                case "IgnoreSettingsUpdatesText":
                    return "Ignore settings update warning until next update";

                // Transactions
                case "TransactionsText": return "Transacciones";
                case "DateInfoText": return "Seleccione un rango de fechas";
                case "DateStartText": return "Fecha comenzando";
                case "DateEndText": return "Fecha de clausura";
                case "30daysPastText": return "Últimos 30 días";
                case "TransactionDateText": return "Fecha";
                case "TransactionDetailText": return "Descripción";
                case "TransactionAmountText": return "Importe";
                case "TransactionBalanceText": return "Saldo";
                case "NoTransactionsText": return "No hay transacciones encontraron...";
                case "PurchasesText": return "Las compras";
                case "LoggedIPText": return "Dirección IP registrada";
                case "NoPurchasesText": return "No se encontraron compras...";
                case "PurchaseCostText": return "Costo";

                // Sim Console
                case "SimConsoleText": return "Sim Command Console";
                case "SimCommandText": return "Command";

                // statistics
                case "StatisticsText": return "Visor de estadísticas";
                case "ViewersText": return "Uso del Visor";
                case "GPUText": return "Tarjetas gráficas";
                case "PerformanceText": return "Promedios de rendimiento ";
                case "FPSText": return "Cuadros / segundo";
                case "RunTimeText": return "El tiempo de ejecución";
                case "RegionsVisitedText": return "Regiones visitadas";
                case "MemoryUseageText": return "Uso de la memoria";
                case "PingTimeText": return "Tiempo Ping";
                case "AgentsInViewText": return "Agentes de vista";
                case "ClearStatsText": return "Borrar datos estadísticas";
 
                // abuse reports
            case "MenuAbuse": return "Abuso Informes";
            case "TooltipsMenuAbuse": return "Usuario abuso informes";
            case "AbuseReportText": return "Reportar abuso";
            case "AbuserNameText": return "Abusador";
            case "AbuseReporterNameText": return "Reportero";
            case "AssignedToText": return "Asignado a";
                
                //Times
                case "Sun":
                    return "Sun";
                case "Mon":
                    return "Mon";
                case "Tue":
                    return "Tue";
                case "Wed":
                    return "Wed";
                case "Thu":
                    return "Thu";
                case "Fri":
                    return "Fri";
                case "Sat":
                    return "Sat";
                case "Sunday":
                    return "Sunday";
                case "Monday":
                    return "Monday";
                case "Tuesday":
                    return "Tuesday";
                case "Wednesday":
                    return "Wednesday";
                case "Thursday":
                    return "Thursday";
                case "Friday":
                    return "Friday";
                case "Saturday":
                    return "Saturday";

                case "Jan_Short":
                    return "Jan";
                case "Feb_Short":
                    return "Feb";
                case "Mar_Short":
                    return "Mar";
                case "Apr_Short":
                    return "Apr";
                case "May_Short":
                    return "May";
                case "Jun_Short":
                    return "Jun";
                case "Jul_Short":
                    return "Jul";
                case "Aug_Short":
                    return "Aug";
                case "Sep_Short":
                    return "Sep";
                case "Oct_Short":
                    return "Oct";
                case "Nov_Short":
                    return "Nov";
                case "Dec_Short":
                    return "Dec";

                case "January":
                    return "January";
                case "February":
                    return "February";
                case "March":
                    return "March";
                case "April":
                    return "April";
                case "May":
                    return "May";
                case "June":
                    return "June";
                case "July":
                    return "July";
                case "August":
                    return "August";
                case "September":
                    return "September";
                case "October":
                    return "October";
                case "November":
                    return "November";
                case "December":
                    return "December";

                // User types
                case "UserTypeText":
                    return "Tipo de usuario";
                case "AdminUserTypeInfoText":
                    return "El tipo de usuario (en la actualidad se utiliza para el pago de estipendios periódicos).";
                case "Guest":
                    return "Invitado";
                case "Resident":
                    return "Residente";
                case "Member":
                    return "Miembro";
                case "Contractor":
                    return "Contratista";
                case "Charter_Member":
                    return "Miembro fundador";

                // ColorBox
                case "ColorBoxImageText":
                    return "Image";
                case "ColorBoxOfText":
                    return "of";
                case "ColorBoxPreviousText":
                    return "Previous";
                case "ColorBoxNextText":
                    return "Next";
                case "ColorBoxCloseText":
                    return "Close";
                case "ColorBoxStartSlideshowText":
                    return "Start Slide Show";
                case "ColorBoxStopSlideshowText":
                    return "Stop Slide Show";

                // Maintenance
                case "NoAccountFound":
                    return "No se han encontrado cuenta";
                case "DisplayInMenu":
                    return "Pantalla en el menú";
                case "ParentText":
                    return "Menú principalt";
                case "CannotSetParentToChild":
                    return "No se puede establecer elemento de menú como un niño a sí mismo.";
                case "TopLevel":
                    return "Nivel superior";
                case "HideLanguageBarText":
                    return "Barra de selección de idioma Ocultar";
                case "HideStyleBarText":
                    return "Ocultar barra de selección de estilo";
                case "HideSlideshowBarText":
                    return "Bar diapositivas Ocultar";
                case "LocalFrontPageText":
                    return "Primera página Local";
                case "LocalCSSText":
                    return "Hoja de estilos CSS Local";


            }
            return "UNKNOWN CHARACTER";
        }
    }
}