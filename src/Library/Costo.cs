namespace Full_GRASP_And_SOLID.Library
{
    /// <summary>
    /// Clase Costo la cual se encarga de calcular todos los costos para realizar una receta. cumple con el patron SRP ya que lo unico que hace es calcular los costos.
    /// </summary>
    public class Costo
    {

        public static double CostoEquipment(Step step)
        {
            double costoEquipment = step.Equipment.HourlyCost * (step.Time / 60);
            return costoEquipment;
        }

        public static double CostoInsumos(Step step)
        {
            double costoInsumos = step.Input.UnitCost;
            return costoInsumos;
        }

        public static double GetProductionCost(Step step)
        {
            double ProductionCost = step.Input.UnitCost + step.Equipment.HourlyCost * (step.Time / 60);
            return ProductionCost;
        }
    }
}