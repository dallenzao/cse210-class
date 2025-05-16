class Address{
    private string _streetaddr;
    private string _city;
    private string _state;
    private string _country;
    
    public Address(string street, string city, string state, string country){
        _streetaddr = street;
        _city = city;
        _state = state;
        _country = country;
    }

    public string ReadableAddress(){
        return $"{_streetaddr}\n{_city}, {_state}\n{_country}";
    }

    public bool InUnitedStates(){
        if(_country == "USA" || _country == "United States"){
            return true;
        }
        return false;
    }
}