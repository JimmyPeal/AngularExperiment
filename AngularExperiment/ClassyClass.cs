using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AngularExperiment
{
    public class HumanDomain
    {
        public List<OwnedProperty> ownedProperty  { get; set; }
        public Person person { get; set; }
    }
    public class OwnedProperty
    {
        public House house { get; set; }
        public Car car { get; set; }

    }
   public class House
    {
        public int houseId { get; set; }
        public int personId { get; set; }
        public Address address { get; set; }
    }
    public class Person
    {
        public string name { get; set; }
        public string gender { get; set; }
        public DateTime birthDate { get; set; }
        public int id { get; set; }
    }
    public class Car
    {
        public int horsePower { get; set; }
        public int doorCount { get; set; }
        public string color { get; set; }
        public string make { get; set; }
        public string model { get; set; }
        public int year { get; set; }
        public int id { get; set; }
        public int personId { get; set; }
    }
    public class Address
    {
        public string street { get; set; }
        public string city { get; set; }
        public string postalCode { get; set; }
        public string state { get; set; }
        public string country { get; set; }
        public string houseId { get; set; }
    }
}