using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Revit.Application.Styles
{
    internal class StylesDictionary : ResourceDictionary
    {
        private const string DictionaryUri = "pack://application:,,,/Revit.Application;component/Styles/Styles.xaml";

        /// <summary>
        /// Initializes a new instance of the <see cref="StylesDictionary"/> class.
        /// Default constructor defining <see cref="ResourceDictionary.Source"/> of the <c>RevitLookup UI</c> controls dictionary.
        /// </summary>
        public StylesDictionary()
        {
            Source = new Uri(DictionaryUri, UriKind.Absolute);
        }
    }
}
