namespace Core.Utilities.Language
{
    public interface ISystemLanguageService
    {

        string DocumentText();
        string LinkedContentText();
        string SearchText();
        string DarkModeText();
        string KeywordText();

        string UrlKeywordText();
        string UpdatedAtText();
    }
}