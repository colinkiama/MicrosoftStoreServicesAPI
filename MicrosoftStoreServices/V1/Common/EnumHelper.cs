using System.Reflection;
using System.Runtime.Serialization;

namespace WindowsStoreServices.V1.Common
{
    /// <summary>
    /// Helper for Enums
    /// </summary>
    public static class EnumHelper
    {
        /// <summary>
        /// Get the string representation of the Enum value
        /// </summary>
        /// <typeparam name="T">Enum type</typeparam>
        /// <param name="enumValue">Enum value</param>
        /// <returns>The string representation of the Enum value</returns>
        public static string AsString<T>(this T enumValue)
        {
            var result = enumValue.ToString();

            var enumType = typeof(T);
            var enumMemberAttribute = enumType.GetRuntimeField(result).GetCustomAttribute<EnumMemberAttribute>();
            if (enumMemberAttribute != null)
            {
                result = enumMemberAttribute.Value;
            }

            return result;
        }
    }
}
