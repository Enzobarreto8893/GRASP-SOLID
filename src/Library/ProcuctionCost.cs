using System;
using System.Collections;



namespace Full_GRASP_And_SOLID.Library
{
    public class ProductionCost
    {
        public ProductionCost(Step preparacion)
        {
            this.Prep = preparacion;  
        }
        public Step Prep {get;set;}

        public double CostoInsumos()
        {
            double costoInsumos = 0;
            costoInsumos =  this.Prep.Input.UnitCost;
            return costoInsumos;
        }
        public double CostoEquipo()
        {
            double costoEquipo = 0;
            costoEquipo += this.Prep.Time * this.Prep.Equipment.HourlyCost / 60;
            return costoEquipo;
        }

        //public string CostoProducto { get; set; }
        //public double CantidadProducto { get; set; }

        public string CalCost()
        {
            double subTotalEquipo = CostoEquipo();
            double subTotalMateriales = CostoInsumos();
            double costoFinal = subTotalEquipo+subTotalMateriales;
            string costoFinalStr = $"Preparar {this.Prep.Input.Description}: Costo Equipo ${subTotalEquipo.ToString()} + Costo Materiales ${subTotalMateriales.ToString()} = Costo ${costoFinal.ToString()}";
            return costoFinalStr;
        }
    }
}