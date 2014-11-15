namespace fsharp.razor.template.Controllers

open System.Web.Http

type ValuesController() = 
    inherit ApiController()
    member this.Get() = [| "value1"; "value2" |]
    // GET api/values/5
    member this.Get(id : int) = "value"
    // POST api/values
    member this.Post([<FromBody>] value : string) = value
    // PUT api/values/5
    member this.Put(id : int, [<FromBody>] value : string) = value + id.ToString()
    // DELETE api/values/5
    member this.Delete(id : int) = "success"
