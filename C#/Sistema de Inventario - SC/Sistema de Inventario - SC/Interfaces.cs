using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sistema_de_Inventario_SC
{
    public interface IForm
    {
        void ActualizarMGP(string txtValue);
        void ActualizarMGM(string txtValue);
    }
    //
    //----------------------------------------------------------------------------------------------------------------------------------------------------------------------
    //
    public interface IBuscar
    {
        void PonerCodigoVentas(string txtValue);
        void PonerCodigoCompras(string txtValue);
        void PonerCodigoDevVentas(string txtValue);
        void PonerCodigoDevCompras(string txtValue);
    }
    //
    public interface IBuscar2
    {
        void PonerCodigo(string txtValue);
    }
    //
    //----------------------------------------------------------------------------------------------------------------------------------------------------------------------
    //
    public interface IForm2
    {
        void RefrescarFormulario(string txtValue);
    }
    //
    //----------------------------------------------------------------------------------------------------------------------------------------------------------------------
    //
    public interface IBuscar3
    {
        void PonerCodigoEditar(string txtValue);
        void PonerCodigoEliminar(string txtValue);
    }
    //
}