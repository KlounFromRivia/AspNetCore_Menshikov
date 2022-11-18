namespace AspNetCore_Menshikov.Models
{
    public class StatisticSklad
    {
        /// <summary>
        /// Общее кол-во товаров на складе
        /// </summary>
        public double AllTovar { get; set; }
        /// <summary>
        /// Общая сумма товаров на складе без НДС
        /// </summary>
        public double AllPriceWithoutNDS { get; set; }
        /// <summary>
        /// Общая сумма товаров на складе с НДС
        /// </summary>
        public double AllPriceNDS { get; set; }
    }
}
