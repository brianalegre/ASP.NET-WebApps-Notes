@page "{id?}"
@model EditModel
@{
  ViewData["Title"] = "Continent Edit";
}

<div class="jumbotron p-3">
  <div class="d-flex align-items-center">
    <h1 class="display-4 flex-grow-1">Continent Edit</h1>
    <a class="btn btn-primary btn-sm" asp-page="./Index">Back to List</a>
  </div>
</div>

<form method="post">
  <div class="form-group d-flex">
    <label asp-for="Continent.ID" class="p-2 text-right" style="flex:0 0 15%"></label>
    <input asp-for="Continent.ID" class="form-control" style="flex:1 0 auto;width:auto" />
  </div>
  <div class="form-group d-flex">
    <label asp-for="Continent.Name" class="p-2 text-right" style="flex:0 0 15%"></label>
    <input asp-for="Continent.Name" class="form-control" style="flex:1 0 auto;width:auto" />
  </div>
  <div class="d-flex flex-row-reverse">
  <input type="submit" value="Save" class="btn btn-primary btn-sm" />
</div>
</form>