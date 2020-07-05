using Blazored.LocalStorage;
using System;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace Resume.Services
{
    public interface II18nService
    {
        Task<string> GetLang();
        Task SetLang(string lang);
    }

    public class I18nService : II18nService
    {
        private readonly ILocalStorageService _localStorage;

        private readonly string LANG_STORAGE_KEY = "lang";
        private readonly string[] ACCEPTED_LANG = new string[] { "fr", "en" };
        private readonly string FALLBACK_LANG = "en";

        public I18nService(ILocalStorageService localStorage)
        {
            _localStorage = localStorage;
        }

        public async Task<string> GetLang()
        {
            // Alway in french until I write the english version
            //var lang = await _localStorage.GetItemAsync<string>(LANG_STORAGE_KEY);
            //if (ACCEPTED_LANG.Contains(lang))
            //    return lang;

            //lang = CultureInfo.CurrentCulture.TwoLetterISOLanguageName;
            //if (ACCEPTED_LANG.Contains(lang))
            //    return lang;

            //return FALLBACK_LANG;
            return "fr";
        }

        public async Task SetLang(string lang)
        {
            await _localStorage.SetItemAsync(LANG_STORAGE_KEY, lang);
        }
    }
}
