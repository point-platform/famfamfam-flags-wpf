/*
 * Created by Drew Noakes
 * 20 May 2009
 * https://drewnoakes.com
 */

using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;
using System.Windows.Media.Imaging;

namespace FamFamFam.Flags.Wpf
{
    /// <summary>
    /// Provides an image source for the flag of a country, as specified via the country's two letter ISO 3166-1 alpha-2 code.
    /// </summary>
    /// <remarks>
    /// Flag images used by this converter have been provided by FamFamFam and are publicly available at:
    /// http://www.famfamfam.com/lab/icons/flags/
    /// </remarks>
    /// <example>
    /// Sample code:
    /// <code>
    /// <![CDATA[
    /// <Image Source="{Binding Converter={StaticResource CountryIdToFlagImageSourceConverter}}" />
    /// ]]>
    /// </code>
    /// For the above example, an instance of the converter must be specified with key <c>CountryIdToFlagImageSourceConverter</c>,
    /// such as this:
    /// <code>
    /// <![CDATA[
    /// <Flags:CountryIdToFlagImageSourceConverter x:Key="CountryIdToFlagImageSourceConverter" />
    /// ]]>
    /// </code>
    /// And the XML namespace <c>Flags</c> defined as:
    /// <code>
    /// <![CDATA[
    /// xmlns:Flags="clr-namespace:FamFamFam.Flags.Wpf;assembly=FamFamFam.Flags.Wpf"
    /// ]]>
    /// </code>
    /// </example>
    public sealed class CountryIdToFlagImageSourceConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var countryId = value as string;

            if (countryId == null)
                return null;

            try
            {
                var path = $"/FamFamFam.Flags.Wpf;component/Images/{countryId.ToLower()}.png";
                var uri = new Uri(path, UriKind.Relative);
                var resourceStream = Application.GetResourceStream(uri);
                if (resourceStream == null)
                    return null;

                var bitmap = new BitmapImage();
                bitmap.BeginInit();
                bitmap.StreamSource = resourceStream.Stream;
                bitmap.EndInit();
                return bitmap;
            }
            catch
            {
                return null;
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotSupportedException();
        }
    }
}
