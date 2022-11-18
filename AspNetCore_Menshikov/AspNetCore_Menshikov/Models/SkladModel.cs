namespace AspNetCore_Menshikov.Models
{
    public class SkladModel
    {
        public string TovarName { get; set; }
        /// <summary>
        /// Пол
        /// </summary>
        public Materials Material { get; set; }
        /// <summary>
        /// Размер
        /// </summary>
        public string Size { get; set; }
        /// <summary>
        /// Кол-во на складе
        /// </summary>
        public int Count { get; set; }
        /// <summary>
        /// Минимальное кол-во на складе
        /// </summary>
        public int MinCount { get; set; }
        /// <summary>
        /// Цена без ндс
        /// </summary>
        public double Price { get; set; }
        public void Proverka()
        {
            Random rnd = new Random();
            if ((int)Material < 0 || (int)Material > 3)
            {
                Material = Materials.Med;
            }

            if (Count < 0 || Count > 2000)
            {
                Count = rnd.Next(1001, 2000);
            }

            if (MinCount < 0|| MinCount > Count)
            {
                MinCount = rnd.Next(0, Count);
            }

            if (Price < 0 || Price > 3000)
            {
                Price = rnd.Next(0, 3000);
            }
        }
    }
}
