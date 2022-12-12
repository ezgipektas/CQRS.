namespace CQRS.İEA.CQRS.Results.ProductResults
{
    public class GetProductQueryResult2
    {
        //Depocu için veri getirme alanı
        public int ProductID { get; set; }
        public string Name { get; set; }
        public int Stock { get; set; }
        public decimal PurchasePrice { get; set; }
        public decimal SalePrice { get; set; }
        public int Tax { get; set; }
    }
}
