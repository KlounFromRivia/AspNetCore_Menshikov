using System.ComponentModel;

namespace AspNetCore_Menshikov.Models
{
    public enum Materials
    {
        /// <summary>
        /// Медь
        /// </summary>
        [Description("Медь")]
        Med,
        /// <summary>
        /// Сталь
        /// </summary>
        [Description("Сталь")]
        Stal,
        /// <summary>
        /// Сталь
        /// </summary>
        [Description("Железо")]
        Iron,
        /// <summary>
        /// Сталь
        /// </summary>
        [Description("Хром")]
        Hrom,
    }
}
