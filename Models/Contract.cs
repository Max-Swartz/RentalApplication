using System;

namespace RentalApplicationAPI.Models {
    public class Contract{

        public int Id {get; set;}
        public string FName1 {get; set;}
        public string LName1 {get; set;}
        public string FName2 {get; set;}
        public string LName2 {get; set;}
        public int PropertyID {get; set;}
        public string type {get; set;}
        public DateTime DateCreated { get; set;}

    }
}