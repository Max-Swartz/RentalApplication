using System;

namespace RentalApplicationAPI.Models {
    public class Rental{
        public int Id {get; set;}
        public string StreetAddress {get; set;}
        public string City {get; set;}
        public string State {get; set;}
        public int ZipCode {get; set;}
        public decimal RentAmt { get; set;}        
        public int NumBaths {get; set;}
        public int  NumbBeds {get; set;}       
        public int SqaureFootage {get; set;}
        public string LeaseDuration {get; set;}
        public string AddtlComments{get; set;}
        public DateTime ListDate {get; set;}
    }

}