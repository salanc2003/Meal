//------------------------------------------------------------------------------
// <auto-generated>
//    這個程式碼是由範本產生。
//
//    對這個檔案進行手動變更可能導致您的應用程式產生未預期的行為。
//    如果重新產生程式碼，將會覆寫對這個檔案的手動變更。
// </auto-generated>
//------------------------------------------------------------------------------

namespace MealServer
{
    using System;
    using System.Collections.Generic;
    
    public partial class bloc
    {
        public bloc()
        {
            this.restaurant = new HashSet<restaurant>();
        }
    
        public int ID { get; set; }
        public string Name { get; set; }
    
        public virtual ICollection<restaurant> restaurant { get; set; }
    }
}
