using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Globalization;

namespace Framework
{
    /// <summary>
    /// Class MappingTool
    /// </summary>
    public static class MappingTool
    {
            #region Constants

            /// <summary>
            /// Valeur par défaut d'un objet de type <c>string</c>
            /// </summary>
            public static readonly string DefaultStringValue = string.Empty;

            /// <summary>
            /// Valeur par défaut d'un objet de type <c>int</c>
            /// </summary>
            public const int DefaultIntValue = int.MinValue;

            /// <summary>
            /// Valeur par défaut d'un objet de type <c>long</c>
            /// </summary>
            public const long DefaultLongValue = long.MinValue;

            /// <summary>
            /// Valeur par défaut d'un objet de type <c>double</c>
            /// </summary>
            public const double DefaultDoubleValue = double.MinValue;

            /// <summary>
            /// Valeur par défaut d'un objet de type <c>float</c>
            /// </summary>
            public const float DefaultFloatValue = float.MinValue;

            /// <summary>
            /// Valeur par défaut d'un objet de type <c>decimal</c>
            /// </summary>
            public const decimal DefaultDecimalValue = decimal.MinValue;

            /// <summary>
            /// Valeur par défaut d'un objet de type <c>DateTime</c>
            /// </summary>
            public static readonly DateTime DefaultDateTimeValue = DateTime.MinValue;

            /// <summary>
            /// Valeur par défaut d'un objet de type <c>bool</c>
            /// </summary>
            public const bool DefaultBoolValue = false;

            /// <summary>
            /// Valeur par défaut d'un objet de type <c>byte[]</c>
            /// </summary>
            public const byte[] DefaultBinaryValue = null;

            #endregion

            #region Static Methods

            /// <summary>
            /// Récupère la valeur de l'objet ou <c>DefaultString</c> si l'objet est null.
            /// </summary>
            /// <param name="value">L'objet à traiter</param>
            /// <returns>La valeur de l'objet ou <c>DefaultString</c> s'il est null.</returns>
            public static string CatchNull(object value)
            {
                if (value == null || value == DBNull.Value)
                {
                    return DefaultStringValue;
                }
                else
                {
                    return value.ToString();
                }
            }

            /// <summary>
            /// Récupère la valeur de l'objet ou <c>Guid.Empty</c> si l'objet est null.
            /// </summary>
            /// <param name="value">L'objet à traiter</param>
            /// <returns>La valeur de l'objet ou <c>Guid.Empty</c> s'il est null.</returns>
            public static Guid CatchGuid(object value)
            {
                if (value is Guid)
                {
                    return (Guid)value;
                }
                if (value == null || value == DBNull.Value || value as string == string.Empty)
                {
                    return Guid.Empty;
                }

                return new Guid(value.ToString());
            }

            /// <summary>
            /// Récupère la valeur de l'objet ou <c>DefaultInt</c> si l'objet est null.
            /// </summary>
            /// <param name="value">L'objet à traiter</param>
            /// <returns>La valeur de l'objet ou <c>DefaultInt</c> s'il est null.</returns>
            public static int CatchIntNull(object value)
            {
                return CatchIntNull(value, DefaultIntValue);
            }

            /// <summary>
            /// Récupère la valeur de l'objet ou la valeur par défaut donnée si l'objet est null.
            /// </summary>
            /// <param name="value">L'objet à traiter</param>
            /// <param name="defaultValue">Valeur par défaut si l'objet est null.</param>
            /// <returns>La valeur de l'objet ou la valeur par défaut donnée s'il est null.</returns>
            public static int CatchIntNull(object value, int defaultValue)
            {
                if (value == null || value == DBNull.Value || string.IsNullOrEmpty(value.ToString()) || value.ToString() == "null")
                {
                    return defaultValue;
                }
                else
                {
                    return int.Parse(value.ToString(), CultureInfo.CurrentCulture);
                }
            }

            /// <summary>
            /// Récupère la valeur de l'objet ou <c>DefaultLong</c> si l'objet est null.
            /// </summary>
            /// <param name="value">L'objet à traiter</param>
            /// <returns>La valeur de l'objet ou <c>DefaultLong</c> s'il est null.</returns>
            public static long CatchLongNull(object value)
            {
                if (value == null || value == DBNull.Value || string.IsNullOrEmpty(value.ToString()))
                {
                    return DefaultLongValue;
                }
                else
                {
                    return long.Parse(value.ToString(), CultureInfo.CurrentCulture);
                }
            }

            /// <summary>
            /// Récupère la valeur de l'objet ou <c>DefaultFloat</c> si l'objet est null.
            /// </summary>
            /// <param name="value">L'objet à traiter</param>
            /// <returns>La valeur de l'objet ou <c>DefaultFloat</c> s'il est null.</returns>
            public static float CatchFloatNull(object value)
            {
                if (value == null || value == DBNull.Value)
                {
                    return DefaultFloatValue;
                }
                else
                {
                    return float.Parse(value.ToString(), CultureInfo.CurrentCulture);
                }
            }

            /// <summary>
            /// Récupère la valeur de l'objet ou <c>DefaultDouble</c> si l'objet est null.
            /// </summary>
            /// <param name="value">L'objet à traiter</param>
            /// <returns>La valeur de l'objet ou <c>DefaultDouble</c> s'il est null.</returns>
            public static double CatchDblNull(object value)
            {
                if (value == null || value == DBNull.Value)
                {
                    return DefaultDoubleValue;
                }
                else
                {
                    return double.Parse(value.ToString(), CultureInfo.CurrentCulture);
                }
            }

            /// <summary>
            /// Récupère la valeur de l'objet ou <c>DefaultDecimal</c> si l'objet est null.
            /// </summary>
            /// <param name="value">L'objet à traiter</param>
            /// <returns>La valeur de l'objet ou <c>DefaultDecimal</c> s'il est null.</returns>
            public static decimal CatchDecNull(object value)
            {
                if (value == null || value == DBNull.Value || string.IsNullOrEmpty(value.ToString()))
                {
                    return DefaultDecimalValue;
                }
                else
                {
                    return decimal.Parse(value.ToString(), CultureInfo.CurrentCulture);
                }
            }

            /// <summary>
            /// Récupère la valeur de l'objet ou la valeur par défaut donnée si l'objet est null.
            /// </summary>
            /// <param name="value">L'objet à traiter</param>
            /// <param name="defaultValue">Valeur par défaut si l'objet est null.</param>
            /// <returns>La valeur de l'objet ou la valeur par défaut donnée s'il est null.</returns>
            public static decimal CatchDecNull(object value, decimal defaultValue)
            {
                if (value == null || value == DBNull.Value || string.IsNullOrEmpty(value.ToString()))
                {
                    return defaultValue;
                }
                else
                {
                    return decimal.Parse(value.ToString(), CultureInfo.CurrentCulture);
                }
            }

            /// <summary>
            /// Récupère la valeur de l'objet ou <c>null</c> si l'objet est null.
            /// </summary>
            /// <param name="value">L'objet à traiter</param>
            /// <returns>La valeur de l'objet ou <c>null</c> s'il est null.</returns>
            public static decimal? CatchDecNullable(object value)
            {
                if (value == null || value == DBNull.Value || string.IsNullOrEmpty(value.ToString()))
                {
                    return null;
                }
                else
                {
                    return decimal.Parse(value.ToString(), CultureInfo.CurrentCulture);
                }
            }

            /// <summary>
            /// Récupère la valeur de l'objet ou <c>DefaultDateTime</c> si l'objet est null.
            /// </summary>
            /// <param name="value">L'objet à traiter</param>
            /// <returns>La valeur de l'objet ou <c>DefaultDateTime</c> s'il est null.</returns>
            public static DateTime CatchDateNull(object value)
            {
                DateTime test;
                if ((value == null || value == DBNull.Value || string.IsNullOrEmpty(value.ToString())) || (!DateTime.TryParse(value.ToString(), out test)))
                {
                    return DefaultDateTimeValue;
                }
                else
                {
                    return DateTime.Parse(value.ToString(), CultureInfo.CurrentCulture);
                }
            }

            /// <summary>
            /// Récupère la valeur de l'objet ou <c>DefaultBool</c> si l'objet est null.
            /// </summary>
            /// <param name="value">L'objet à traiter</param>
            /// <returns>La valeur de l'objet ou <c>DefaultBool</c> s'il est null.</returns>
            public static bool CatchBoolNull(object value)
            {
                return CatchBoolNull(value, DefaultBoolValue);
            }

            /// <summary>
            /// Récupère la valeur de l'objet ou la valeur par défaut donnée si l'objet est null.
            /// </summary>
            /// <param name="value">L'objet à traiter</param>
            /// <param name="defaultValue">Valeur par défaut si l'objet est null.</param>
            /// <returns>La valeur de l'objet ou la valeur par défaut donnée s'il est null.</returns>
            public static bool CatchBoolNull(object value, bool defaultValue)
            {
                if (value == null || value == DBNull.Value || string.IsNullOrEmpty(value.ToString()))
                {
                    return defaultValue;
                }
                else
                {
                    try
                    {
                        return bool.Parse(value.ToString());
                    }
                    catch
                    {
                        return defaultValue;
                    }
                }
            }

            /// <summary>
            /// Récupère la valeur de l'objet ou <c>DefaultBinary</c> si l'objet est null.
            /// </summary>
            /// <param name="value">L'objet à traiter</param>
            /// <returns>La valeur de l'objet ou <c>DefaultBinary</c> s'il est null.</returns>
            public static byte[] CatchBinaryNull(object value)
            {
                return CatchBinaryNull(value, DefaultBinaryValue);
            }

            /// <summary>
            /// Récupère la valeur de l'objet ou la valeur par défaut donnée si l'objet est null.
            /// </summary>
            /// <param name="value">L'objet à traiter</param>
            /// <param name="defaultValue">Valeur par défaut si l'objet est null.</param>
            /// <returns>La valeur de l'objet ou la valeur par défaut donnée s'il est null.</returns>
            public static byte[] CatchBinaryNull(object value, byte[] defaultValue)
            {
                if (value == null || value == DBNull.Value || string.IsNullOrEmpty(value.ToString()))
                {
                    return defaultValue;
                }
                else
                {
                    return (byte[])value;
                }
            }

            #endregion

            /// <summary>
            /// Vérifie si la date donnée et renvoie null si elle vaut <c>DateTime.MinValue</c>.
            /// </summary>
            /// <param name="dateTime">Date à vérifier.</param>
            /// <returns>La valeur <c>null</c> si la date vaut <c>DateTime.MinValue</c>, la date elle-même sinon.</returns>
            public static object CheckDateTime(DateTime dateTime)
            {
                if (dateTime == DateTime.MinValue)
                {
                    return null;
                }
                else
                {
                    return dateTime;
                }
            }
        }
    }
