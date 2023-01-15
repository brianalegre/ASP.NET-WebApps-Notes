@page "{id?}"
@model EditModel
@{
  ViewData["Title"] = "Continent Edit";
}

< div class= "jumbotron p-3" >
  < div class= "d-flex align-items-center" >
    < h1 class= "display-4 flex-grow-1" >
      Continent Edit
    </ h1 >
    < a class= "btn btn-primary btn-sm" asp - page = "./Index" >
      Back to List
    </a>
  </div>
</div>