using System.Globalization;

namespace Revit.Shared
{ 
    public interface ILocaleCulture
    { 
        CultureInfo GetCurrentCultureInfo();
         
        void SetLocale(CultureInfo ci);

        string GetString(string key);
    }
}