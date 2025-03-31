using System;
// 12
class Person
{
    public string? name { get; set; }
    public Address? address { get; set; } // Here. Address is data type and address is field name.
}
class Address
{
    public string? houseNumber { get; set; }
    public string? roadNumber { get; set; }
    public string? area { get; set; }
    public string? postCode { get; set; }
    public string? district { get; set; }
}
class OneToOneAssociationRelationship
{
    public static void Main(string[] args)
    {
        Address address1 = new Address();
        address1.houseNumber = "H-101";
        address1.roadNumber = "R-101";
        address1.area = "Rayerbag";
        address1.postCode = "P-101";
        address1.district = "Dhaka";

        Person person1 = new Person();
        person1.name = "Anis";
        person1.address = address1;

        Console.WriteLine($"Name: {person1.name}, House Number: {person1.address.houseNumber}, Road Number: {person1.address.roadNumber}");

    }
}