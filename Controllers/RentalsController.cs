using Microsoft.AspNetCore.Mvc;
using RentalApplicationAPI.Data;
using RentalApplicationAPI.Models;

[Route("api/rentals")]

public class RentalsController : Controller
{

    private readonly PropertyContext db;

    public RentalsController(PropertyContext context){
        db = context;
    }

    //Post api/rentals
    [HttpPost]
    public IActionResult Post([FromBody]Rental rental){
        var newRental = db.Rentals.Add(rental);
        db.SaveChanges();
        return CreatedAtRoute ("GetRental", new {id=rental.Id}, rental);
    }   

    //Get api/rentals
    [HttpGet]
    public IActionResult GetRentals(){
        return Ok (db.Rentals);
    }

    //Get api/rentals/5
    [HttpGet("{id}", Name = "GetRentals")]
    public IActionResult Get (int id)
    {
        return Ok (db.Rentals.Find(id));
    }

    //PUT Api/rentals/id
    [HttpPut("{id}")]

    public IActionResult Put (int id, [FromBody] Rental rental)
    {
        var newRental = db.Rentals.Find(id);
        if(newRental == null){
            return NotFound();
        }
        newRental=rental;
        db.Rentals.Update(newRental);
        db.SaveChanges();
        return Ok(newRental);
    }

    //Delete api/rentals/
    [HttpDelete("{id}")]
    
    public IActionResult Delete(int id)
    {
        var rentalToDelete = db.Rentals.Find(id);
        if (rentalToDelete== null){
            return NotFound();
        }
        db.Rentals.Remove(rentalToDelete);
        db.SaveChangesAsync();
        return NoContent();
    }
}