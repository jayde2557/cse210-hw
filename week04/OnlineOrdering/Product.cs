using System;


public class Product
{
    private string _productName;
    private string _productID;
    private int _price;
    private int _quantity;

    public Product(string pName, string pID, int price)
    {
      _productName = pName;
      _productID = pID;
      _price = price;
      _quantity = 1;  
    }

    public Product(string pName, string pID, int price, int quantity)
    {
      _productName = pName;
      _productID = pID;
      _price = price;
      _quantity = quantity;  
    }


    public int totalCost()
    {
      return _price* _quantity;
    }

    public string GetName() 
    {
      return _productName;
    }
    public string GetID() 
    {
      return _productID; 
    }
}