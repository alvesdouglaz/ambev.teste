namespace Ambev.DeveloperEvaluation.Domain.Contracts
{
    public interface IProductContract
    {
        public string Name { get; set; }
        public string? Description { get; set; }
        public double? Price { get; set; }
        public string? Category { get; set; }
        public string? Image { get; set; }
    }
}
