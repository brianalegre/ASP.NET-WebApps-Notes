@page
@model IndexModel
@{
  ViewData["Title"] = "Home page";
}

< div class= "jumbotron jumbotron-fluid" id = "chef-jumbotron" >
  < div id = "request-info" >
    < em > RequestMethod </ em >: @Model.RequestMethod<em> RequestInfo</em>: @Model.RequestValues
  </ div >
  < div id = "jumbotron-main-text" >
    < h1 > Chef's Blog</h1>
    < p > A place for the best recipes! </ p >
  </ div >
</ div >

< div class= "row" >
  < div class= "col" >
    < h1 > Write a new post</h1>
    < hr >
    < !--Form start-- >


    < !--Form end-- >
  </ div >

  < div class= "col" >
    < h1 > Recent posts </ h1 >
    < hr >
    < !--Page model properties displayed here -->
    <div class= "blog-post" >
      < h2 class= "blog-post-title" > @Model.Title </ h2 >
      < p class= "blog-post-meta" > Posted on @Model.Date.ToShortDateString()</ p >
      < p > @Model.Body </ p >
    </ div >
  </ div >
</ div >


