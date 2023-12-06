public class ProductViewModel
{
    public int Id { get; set; }
    public string CategoryName { get; set; }
    public string ProductName { get; set; }
    public decimal UnitPrice { get; set; }
    public int Discount { get; set; }
    public bool DiscountApplied { get; set; }
}

//Business'a ihtiyaç var
// Soyutlama teknikleri hemen hemen tüm desenlerde var.
public abstract class ProductBuilder
{
    public abstract void GetProductData();
    public abstract void UpdateProductData();

}

class NewCustomerProductBuilder : ProductBuilder
{
    ProductViewModel model = new ProductViewModel();
    public override void GetProductData()
    {
        model.Id = 1;
        model.CategoryName = "Test";
        model.ProductName = "TestProduct";
        model.UnitPrice = 20;
    }

    public override void UpdateProductData()
    {
        //sıralı olmasının önemi
        
    }
}

class OldCustomerProductBuilder : ProductBuilder
{
    public override void GetProductData()
    {
        throw new NotImplementedException();
    }

    public override void UpdateProductData()
    {
        throw new NotImplementedException();
    }
}