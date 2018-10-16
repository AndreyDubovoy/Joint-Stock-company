/********************************************************************
 *  FulcrumWeb RAD Framework - Fulcrum of your business             *
 *  Copyright (c) 2002-2010 FulcrumWeb, ALL RIGHTS RESERVED         *
 *                                                                  *
 *  THE SOURCE CODE CONTAINED WITHIN THIS FILE AND ALL RELATED      *
 *  FILES OR ANY PORTION OF ITS CONTENTS SHALL AT NO TIME BE        *
 *  COPIED, TRANSFERRED, SOLD, DISTRIBUTED, OR OTHERWISE MADE       *
 *  AVAILABLE TO OTHER INDIVIDUALS WITHOUT EXPRESS WRITTEN CONSENT  *
 *  AND PERMISSION FROM FULCRUMWEB. CONSULT THE END USER LICENSE    *
 *  AGREEMENT FOR INFORMATION ON ADDITIONAL RESTRICTIONS.           *
 ********************************************************************/

namespace Framework.Utils
{
  /// <summary>
  /// Class with static properties to hold developer-defined 
  /// application-related data (company name, application name, etc.)
  /// </summary>
  public class CxAppInfo
  {
    //-------------------------------------------------------------------------
    static protected string m_CompanyName = ""; // Name of the developer company
    static protected string m_ApplicationName = ""; // Name of the application
    // Inner name of the application, should not contain anything but letters.
    // Spaces are not allowed.
    static private string m_ApplicationCode = "";
    static private string m_LocalizationApplicationCode = "";
    static private string m_FrontendCode = "";
    static protected string m_VersionName = ""; // Name of the application version.
    static protected string m_UserName = ""; // Name of the current user
    static private string m_LanguageCode = ""; //Current language code of the application.
    static private string m_LanguageCodeToSave;
    //-------------------------------------------------------------------------

    //-------------------------------------------------------------------------
    /// <summary>
    /// Static property to hold name of the developer company (optional).
    /// </summary>
    static public string CompanyName
    {
      get { return m_CompanyName; }
      set { m_CompanyName = value; }
    }
    //-------------------------------------------------------------------------
    /// <summary>
    /// Static property to hold name of the application (optional).
    /// </summary>
    static public string ApplicationName
    {
      get { return m_ApplicationName; }
      set { m_ApplicationName = value; }
    }
    //-------------------------------------------------------------------------
    /// <summary>
    /// Static property to hold name of the application version (optional).
    /// </summary>
    static public string VersionName
    {
      get { return m_VersionName; }
      set { m_VersionName = value; }
    }
    //-------------------------------------------------------------------------
    /// <summary>
    /// Concatenated name of the application and version.
    /// </summary>
    static public string ApplicationNameAndVersion
    {
      get { return ApplicationName + " " + VersionName; }
    }
    //-------------------------------------------------------------------------
    /// <summary>
    /// Concatenated code of the application and version.
    /// </summary>
    static public string FrontendCodeAndVersion
    {
      get { return FrontendCode + " " + VersionName; }
    }
    //-------------------------------------------------------------------------
    /// <summary>
    /// Static property to hold name of the current user (optional).
    /// </summary>
    static public string UserName
    {
      get { return m_UserName; }
      set { m_UserName = value; }
    }
    //-------------------------------------------------------------------------
    /// <summary>
    /// Inner name of the application, should not contain anything but letters.
    /// Spaces are not allowed.
    /// </summary>
    public static string ApplicationCode
    {
      get { return m_ApplicationCode; }
      set { m_ApplicationCode = value; }
    }
    //-------------------------------------------------------------------------
    /// <summary>
    /// The application code to be used by the localization (multi-language) subsystem.
    /// </summary>
    public static string LocalizationApplicationCode
    {
      get { return m_LocalizationApplicationCode; }
      set { m_LocalizationApplicationCode = value; }
    }
    //-------------------------------------------------------------------------
    /// <summary>
    /// Static property to hold current language code of the application.
    /// </summary>
    public static string LanguageCode
    {
      get { return m_LanguageCode; }
      set { m_LanguageCode = value; }
    }
    //-------------------------------------------------------------------------
    /// <summary>
    /// The language code to be saved into the settings storage
    /// so that it will be used after restart.
    /// </summary>
    public static string LanguageCodeToSave
    {
      get { return m_LanguageCodeToSave ?? LanguageCode; }
      set { m_LanguageCodeToSave = value; }
    }
    //-------------------------------------------------------------------------
    /// <summary>
    /// Presentation code, means code to be used whenever we store the frontend-specific settings.
    /// </summary>
    public static string FrontendCode
    {
      get { return m_FrontendCode; }
      set { m_FrontendCode = value; }
    }
    //-------------------------------------------------------------------------
    /// <summary>
    /// Initializes static properties with company name, application name and version name.
    /// </summary>
    /// <param name="companyName">company name to store in the static property</param>
    /// <param name="applicationName">application name to store in the static property</param>
    /// <param name="applicationCode">application inner name</param>
    /// <param name="frontendCode">frontend code</param>
    /// <param name="versionName">application name to store in the static property</param>
    static public void Init(
      string companyName, 
      string applicationName, 
      string applicationCode,
      string frontendCode,
      string versionName)
    {
      CompanyName = companyName;
      ApplicationName = applicationName;
      ApplicationCode = applicationCode;
      FrontendCode = frontendCode;
      VersionName = versionName;
    }
    //-------------------------------------------------------------------------
  }
}