namespace Full_GRASP_And_SOLID.Library
{
    /// <summary>
    /// Clase "RecipeCost" la cual se le asignó la responsabilidad de calcular todos los costos para realizar una receta. cumple con el patron SRP ya que su unica función es calcular los costos.
    /// </summary>
    public class RecipeCost
    {

        public static double EquipmentCost(Step step)
        {
            double EquipmentCost = step.Equipment.HourlyCost * (step.Time / 60);
            return EquipmentCost;
        }

        public static double InsumosCost(Step step)
        {
            double InsumosCost = step.Input.UnitCost;
            return InsumosCost;
        }

        public static double GetProductionCost(Step step)
        {
            double ProductionCost = step.Input.UnitCost + step.Equipment.HourlyCost * (step.Time / 60);
            return ProductionCost;
        }
    }
}