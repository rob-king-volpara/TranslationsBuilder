namespace TranslationsBuilder.Models
{
    public interface IStatusCalback
    {
        void updateLoadingStatus(string TranslationType, string ObjectName, string OriginalText, string TranslatedText);
    }
}
