namespace Viserion.Domain;

public class ProductOwner : Entity
{
    public ProductOwner()
    {
        Products = new List<Product>();
    }

    public Guid UserId { get; set; }
    public ICollection<Product> Products { get; set; }
}