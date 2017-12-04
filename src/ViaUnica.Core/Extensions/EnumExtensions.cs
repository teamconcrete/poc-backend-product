using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;

namespace ViaUnica.Core.Extensions
{
    public static class EnumExtensions
    {
        private const string DESCRIPTION_ATTRIBUTE_NAME = "Description";
        private const string NAME_ATTRIBUTE_NAME = "Name";

        public static string GetDescriptionValue<T>(this T value)
            where T : struct, IComparable, IConvertible, IFormattable
        {
            return GetDisplayDetails(value)[DESCRIPTION_ATTRIBUTE_NAME];
        }

        public static string GetNameValue<T>(this T value) where T : struct, IConvertible
        {
            return GetDisplayDetails(value)[NAME_ATTRIBUTE_NAME];
        }

        public static Dictionary<string, string> GetDisplayDetails<T>(this T value) where T : struct, IConvertible
        {
            if (!typeof(T).GetTypeInfo().IsEnum) throw new ArgumentException("T must be an enumerated type");

            var result = new Dictionary<string, string>();
            var fieldInfo = value.GetType().GetTypeInfo().DeclaredFields.FirstOrDefault(x => x.Name.Equals(value.ToString()));

            if (fieldInfo == null) return result;

            var descriptionAttributes = fieldInfo.GetCustomAttributes(typeof(DisplayAttribute), false) as DisplayAttribute[];

            if (descriptionAttributes == null)
                return result;

            if (descriptionAttributes.Length <= 0) return result;

            result.Add("Name", descriptionAttributes[0].Name);
            result.Add("Description", descriptionAttributes[0].Description);

            return result;
        }
    }
}
