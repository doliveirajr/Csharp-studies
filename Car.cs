using System;

public class Car
{
	private string _name;
	private string _description;
	public Car(string description, string name)
	{
		_description = description;
		_name = name;
	}

	public string theCar()
	{
		return $"The car is a {_description} {_name}";
	}
}
