@page
@model IndexModel
@{
  ViewData["Title"] = "Continent List";
}

<div class="jumbotron p-3 d-flex align-items-center">
  <h1 class="display-4 flex-grow-1">
    Continent List
  </h1>
  <a class="btn btn-primary btn-sm" asp-page="./Edit">
    Create
  </a>
</div>

<div class="d-flex bg-primary text-white">
  <div class="p-2" style="flex:0 0 10%">
    Code
  </div>
  <div class="p-2" style="flex:1 0 auto">
    Name
  </div>
  <div class="p-2" style="flex:0 0 25%">
    Options
  </div>
</div>

@foreach (var item in Model.Continents) {
  <div class="d-flex border-left border-right border-bottom border-primary">
    <div class="p-2" style="flex:0 0 10%">
      @item.ID
    </div>
    <div class="p-2" style="flex:1 0 auto">
      @item.Name
    </div>
    <div class="p-2 btn-group" style="flex:0 0 25%" role="group" >
      <a class="btn btn-primary btn-sm" asp-page="./Detail" asp-route-id="@item.ID">
        Details
      </a>
      <a class="btn btn-primary btn-sm" asp-page="./Edit" asp-route-id="@item.ID">
        Edit
      </a>
    </div>
  </div>
}