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
    
    public partial class Material
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Material()
        {
            this.MaterialManuntecaoCusto = new HashSet<MaterialManuntecaoCusto>();
        }
    
        public int IDMaterial { get; set; }
        public string NMMaterial { get; set; }
        public Nullable<double> ValorUnitario { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MaterialManuntecaoCusto> MaterialManuntecaoCusto { get; set; }

		public override string ToString()
		{
			return NMMaterial;
		}
	}
}
