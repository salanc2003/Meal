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
    
    public partial class restaurant
    {
        public restaurant()
        {
            this.mealkind = new HashSet<mealkind>();
            this.mealstate = new HashSet<mealstate>();
            this.ordermeal = new HashSet<ordermeal>();
        }
    
        public int ID { get; set; }
        public string Name { get; set; }
        public string Telephone { get; set; }
        public string Adrs { get; set; }
        public string URL { get; set; }
        public int BlocID { get; set; }
    
        public virtual bloc bloc { get; set; }
        public virtual ICollection<mealkind> mealkind { get; set; }
        public virtual ICollection<mealstate> mealstate { get; set; }
        public virtual ICollection<ordermeal> ordermeal { get; set; }
    }
}
