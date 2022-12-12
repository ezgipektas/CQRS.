namespace CQRS.İEA.CQRS.Results.ProductResults
{
    public class GetProductQueryResult
    {
        //Depocu için veri getirme alanı
        public int ProductID { get; set; }
        public string Name { get; set; }
        public int Stock { get; set; }
        public string Storage { get; set; }
        public string Shelf { get; set; }
    }
}
