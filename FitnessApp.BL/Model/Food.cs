using System;
using System.Collections;
using System.Collections.Generic;

namespace FitnessApp.BL.Model
{
    [Serializable]
    public class Food
    {
        public int Id { get; set; }
        public string Name { get; set; }
        /// <summary>
        /// Белки.
        /// </summary>
        public double Proteins { get; set; }
        /// <summary>
        /// Жиры.
        /// </summary>
        public double Fats { get; set; }
        /// <summary>
        /// Углеводы.
        /// </summary>
        public double Carbohydrates { get; set; }
        /// <summary>
        /// Калории за 100 грамм продукта.
        /// </summary>
        public double Calories { get; set; }
        private double CaloriesOneGramm { get { return Calories / 100.0; } }
        private double ProteinsOneGramm { get { return Proteins / 100; } }
        private double FatsOneGramm { get { return  Fats /  100; } }
        private double CarbohydratesOneGramm { get { return Carbohydrates / 100; }}

        public virtual ICollection<Eating> Eatings { get; set; }
        public Food() { }

        public Food (string name) : this(name, 0, 0, 0, 0) { }
        
        public Food(string name, double calories, double proteins, double fats, double carbohydrates)
        {
            // TODO: Проверка.

            Name = name;
            Calories = calories / 100.0;
            Proteins = proteins / 100.0;
            Fats = fats / 100.0;
            Carbohydrates = carbohydrates / 100.0;           
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
