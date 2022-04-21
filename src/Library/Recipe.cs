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
        /// Metodo que se encarga de devolver el costo de los ingredientes que se utilizaron para la receta.
        /// </summary>
        /// <returns></returns>
        public double GetProductionIngredientsCost()
        {
            double totalIngredientsCost = 0;
            foreach (Step step in this.steps)
            {
                totalIngredientsCost += Costo.CostoInsumos(step);
            }
            return totalIngredientsCost;
        }
        /// <summary>
        /// Metodo que se encarga de devolver el costo del equipamiento que se utilizó para la receta.
        /// </summary>
        /// <returns></returns>
        public double GetProductionEquipmentCost()
        {
            double totalEquipmentCost = 0;
            foreach (Step step in this.steps)
            {
                totalEquipmentCost += Costo.CostoEquipment(step);
            }
            return totalEquipmentCost;
        }
        /// <summary>
        /// Metodo que se encarga de devolver el costo total de la receta, sumando el costo del equipamiento y el costo de los insumos.
        /// </summary>
        /// <returns></returns>
        public double GetProductionCost()
        {
            double totalProductionCost = 0;
            foreach (Step step in this.steps)
            {
                totalProductionCost += Costo.GetProductionCost(step);
            }
            return totalProductionCost;
        }
    }
}