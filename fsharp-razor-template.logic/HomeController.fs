namespace fsharp.razor.template.Controllers

open System.Web.Mvc

type HomeController() = 
    inherit Controller()
    member this.Index() = 
        base.ViewData.Add("Title", "Home Page")
        base.View()
