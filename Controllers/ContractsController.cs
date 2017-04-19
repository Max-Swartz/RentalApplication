using Microsoft.AspNetCore.Mvc;
using RentalApplicationAPI.Data;
using RentalApplicationAPI.Models;

[Route("api/contracts")]

public class ContractsController : Controller
{

    private readonly PropertyContext db;

    public ContractsController(PropertyContext context){
        db = context;
    }

    //Post api/contracts
    [HttpPost]
    public IActionResult Post([FromBody]Contract contract){
        var newContract = db.Contracts.Add(contract);
        db.SaveChanges();
        return CreatedAtRoute ("GetContract", new {id=contract.Id}, contract);
    }   

    //Get api/contracts
    [HttpGet]
    public IActionResult GetContracts(){
        return Ok (db.Contracts);
    }

    //Get api/contracts/5
    [HttpGet("{id}", Name = "GetContracts")]
    public IActionResult Get (int id)
    {
        return Ok (db.Contracts.Find(id));
    }

    //PUT Api/contracts/id
    [HttpPut("{id}")]

    public IActionResult Put (int id, [FromBody] Contract contract)
    {
        var newContract = db.Contracts.Find(id);
        if(newContract == null){
            return NotFound();
        }
        newContract=contract;
        db.Contracts.Update(newContract);
        db.SaveChanges();
        return Ok(newContract);
    }

    //Delete api/contract/
    [HttpDelete("{id}")]
    
    public IActionResult Delete(int id)
    {
        var contractToDelete = db.Contracts.Find(id);
        if (contractToDelete== null){
            return NotFound();
        }
        db.Contracts.Remove(contractToDelete);
        db.SaveChangesAsync();
        return NoContent();
    }
}