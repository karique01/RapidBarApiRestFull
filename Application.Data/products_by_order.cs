//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Application.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class products_by_order
    {
        public int id { get; set; }
        public int productId { get; set; }
        public int orderId { get; set; }
        public int quantity { get; set; }
    
        public virtual orders orders { get; set; }
        public virtual products products { get; set; }
    }
}
