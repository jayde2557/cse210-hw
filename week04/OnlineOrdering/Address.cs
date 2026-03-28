using System;

public class Address
{
    private string _streetAddress;
    private string _city;
    private string _state;
    private string _country;


    public Address(string streetadress, string city, string state, string country)
    {
        _streetAddress = streetadress;
        _city = city;
        _state =state;
        _country = country;
    }

    public bool IsInUSA()
    {
        return _country.Trim().ToUpper() == "USA";
    }

    public string GetFullAddress()
    {
        return $"{_streetAddress}\n{_city}, {_state}\n{_country}";
    }
}