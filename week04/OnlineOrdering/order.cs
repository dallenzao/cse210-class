class Order{
    private List<Product> _products = new List<Product>();
    private Customer _customer;

    public Order(List<Product> products, Customer cust){
        _products = products;
        _customer = cust;
    }

    public double GetPriceBeforeShip(){
        double total = 0;
        foreach(Product p in _products){
            total += p.GetTotalPrice();
        }
        return total;
    }
    public int ShipPrice(){
        if(_customer.InUnitedStates()){
            return 5;
        }
        else{
            return 35;
        }
    }

    public double GetTotal(){
        return GetPriceBeforeShip() + ShipPrice();
    }

    public string PackingLabel(){
        string label = "";
        foreach(Product p in _products){
            label += $"Name: {p.GetName()} | PID: {p.GetId()} | Quantity: {p.GetQuantity()} | Price Each: ${p.GetIndPrice()}\n";
        }
        label +=$"\n\nPrice Before Shipment: ${GetPriceBeforeShip()}\nShipping Price: ${ShipPrice()}\nTotalPrice: ${GetTotal()}";
        return label;
    }
    
    public string ShippingLabel(){
        return $"Ship To:\n{_customer.GetName()}\n\n{_customer.GetAddress()}";
    }
}