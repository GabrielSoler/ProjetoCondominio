//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProjetoCondominio
{
    using System;
    using System.Collections.Generic;
    
    public partial class MaterialManuntecaoCusto
    {
        public int IDMaterial { get; set; }
        public int IDManutencao { get; set; }
        public int IDCusto { get; set; }
        public int IDRelatorioCusto { get; set; }
        public int Quantidade { get; set; }
    
        public virtual Custos Custos { get; set; }
        public virtual Manutencao Manutencao { get; set; }
        public virtual Material Material { get; set; }
    }
}
