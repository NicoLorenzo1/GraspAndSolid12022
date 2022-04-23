namespace Full_GRASP_And_SOLID.Library
{
    /// <summary>
    /// Clase "RecipeCost" la cual se le asignó la responsabilidad de calcular todos los costos para realizar una receta. cumple con el patron SRP ya que su unica función es calcular los costos y en un futuro si se quiere cambiar la forma de calcular los costos
    /// o hacer algun otro cambio similar solamente se vería afectada esta clase sin tener que hacer grandes cambios en el resto del programa.
    /// A la hora de clacular los costos por hora, dividí el tiempo entre 60 ya que asumí que el tiempo que se ingresa es en minutos, (no se podria demorar 120 horas en hacer un café)
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