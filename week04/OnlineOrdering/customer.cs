class Customer{
    private string _name;
    private Address _address;

    public Customer(string name, Address addr){
        _name = name;
        _address = addr;
    }

    public string GetName(){ return _name; }
    public string GetAddress(){return _address.ReadableAddress();}
    public bool InUnitedStates(){ return _address.InUnitedStates();}

}