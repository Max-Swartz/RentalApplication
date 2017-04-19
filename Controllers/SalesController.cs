using Microsoft.AspNetCore.Mvc;
using RentalApplicationAPI.Data;
using RentalApplicationAPI.Models;

[Route("api/sales")]

public class SalesController : Controller
{

    private readonly PropertyContext db;

    public SalesController(PropertyContext context){
        db = context;
    }

    //Post api/sales
    [HttpPost]
    public IActionResult Post([FromBody]Sale sale){
        var newSale = db.Sales.Add(sale);
        db.SaveChanges();
        return CreatedAtRoute ("GetSale", new {id=sale.Id}, sale);
    }   

    //Get api/sales
    [HttpGet]
    public IActionResult GetSales(){
        return Ok (db.Sales);
    }

    //Get api/sales/5
    [HttpGet("{id}", Name = "GetSales")]
    public IActionResult Get (int id)
    {
        return Ok (db.Sales.Find(id));
    }

    //PUT Api/sales/id
    [HttpPut("{id}")]

    public IActionResult Put (int id, [FromBody] Sale sale)
    {
        var newSale = db.Sales.Find(id);
        if(newSale == null){
            return NotFound();
        }
        newSale=sale;
        db.Sales.Update(newSale);
        db.SaveChanges();
        return Ok(newSale);
    }

    //Delete api/sales/
    [HttpDelete("{id}")]
    
    public IActionResult Delete(int id)
    {
        var saleToDelete = db.Sales.Find(id);
        if (saleToDelete== null){
            return NotFound();
        }
        db.Sales.Remove(saleToDelete);
        db.SaveChangesAsync();
        return NoContent();
    }
}