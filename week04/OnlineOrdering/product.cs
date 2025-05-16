class Product{
    private string _name;
    private int _productID;
    private double _price;
    private int _quantity;
    public Product(string name, int id, double price, int quant){
        _name = name;
        _productID = id;
        _price = price;
        _quantity = quant;
    }   

    public string GetName(){ return _name;}
    public int GetId(){ return _productID;}
    public double GetIndPrice(){ return _price;}
    public int GetQuantity(){ return _quantity;}
    public double GetTotalPrice(){
        return _quantity * _price;
    }
}