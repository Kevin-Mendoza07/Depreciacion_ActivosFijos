using Domain.Entities;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCore.Processes
{
    public class LineaRecta : IDepreciacionModel
    {
        public List<double> Depreciacion(Activo activo)
        {
            //List<double> depreciaciones=new List<double>();

            double depreciacion = (activo.Valor - activo.ValorResidual) / activo.VidaUtil;
            return Enumerable.Repeat(depreciacion,activo.VidaUtil).ToList();


            //for(int i=1; i < activo.VidaUtil+1; i++)
            //{
            //    double depreciacion = (activo.Valor - activo.ValorResidual) / activo.VidaUtil;
            //    depreciaciones.Add(depreciacion);

            //}
            //return depreciaciones;
        }
    }
}
