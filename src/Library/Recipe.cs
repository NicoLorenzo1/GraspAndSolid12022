using System;
using System.Collections;

namespace Full_GRASP_And_SOLID.Library
{
    public class Recipe
    {
        private ArrayList steps = new ArrayList();

        public Product FinalProduct { get; set; }

        public void AddStep(Step step)
        {
            this.steps.Add(step);
        }

        public void RemoveStep(Step step)
        {
            this.steps.Remove(step);
        }

        public void PrintRecipe()
        {
            Console.WriteLine($"Receta de {this.FinalProduct.Description}:");
            foreach (Step step in this.steps)
            {
                Console.WriteLine($"{step.Quantity} de '{step.Input.Description}' " +
                    $"usando '{step.Equipment.Description}' durante {step.Time}");
            }

            Console.WriteLine($"El costo de los ingredientes es {this.GetProductionIngredientsCost()}\nEl costo de usar el equipamiento es {this.GetProductionEquipmentCost()}\nEl costo total es {this.GetProductionCost()}");


        }

        /// <summary>
        /// Metodo que se encarga de recorrer todos los pasos de la receta y devolver el costo de los ingredientes que se utilizaron para la misma.
        /// </summary>
        /// <returns></returns>
        public double GetProductionIngredientsCost()
        {
            double totalIngredientsCost = 0;
            foreach (Step step in this.steps)
            {
                totalIngredientsCost += RecipeCost.InsumosCost(step);
            }
            return totalIngredientsCost;
        }
        /// <summary>
        /// Metodo que se encarga de recorrer todos los pasos de la receta y devolver el costo del equipamiento que se utilizó.
        /// </summary>
        /// <returns></returns>
        public double GetProductionEquipmentCost()
        {
            double totalEquipmentCost = 0;
            foreach (Step step in this.steps)
            {
                totalEquipmentCost += RecipeCost.EquipmentCost(step);
            }
            return totalEquipmentCost;
        }
        /// <summary>
        /// Metodo que se encarga de recorrer todos los pasos de la receta y devolver el costo total, sumando el costo del equipamiento y el costo de los insumos a través del metodo "GetProductionCost".
        /// </summary>
        /// <returns></returns>
        public double GetProductionCost()
        {
            double totalProductionCost = 0;
            foreach (Step step in this.steps)
            {
                totalProductionCost += RecipeCost.GetProductionCost(step);
            }
            return totalProductionCost;
        }
    }
}