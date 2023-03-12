using System;

namespace FitnessApp.BL.Model
{
    [Serializable]
    public class Food
    {
        public string Name { get; }
        /// <summary>
        /// Белки.
        /// </summary>
        public double Proteins { get; }
        /// <summary>
        /// Жиры.
        /// </summary>
        public double Fats { get; }
        /// <summary>
        /// Углеводы.
        /// </summary>
        public double Carbohydrates { get; }
        /// <summary>
        /// Калории за 100 грамм продукта.
        /// </summary>
        public double Calories { get; }
        private double CaloriesOneGramm { get { return Calories / 100.0; } }
        private double ProteinsOneGramm { get { return Proteins / 100; } }
        private double FatsOneGramm { get { return  Fats /  100; } }
        private double CarbohydratesOneGramm { get { return Carbohydrates / 100; }}

        public Food (string name) : this(name, 0, 0, 0, 0) { }
        
        public Food(string name, double calories, double proteins, double fats, double carbohydrates)
        {
            // TODO: Проверка.

            Name = name;
            Calories = calories / 100;
            Proteins = proteins / 100;
            Fats = fats / 100;
            Carbohydrates = carbohydrates / 100;           
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
