@page
@model PizzaModel
@{
}

<h1 class="text-center">Codecademy Pizza</h1>
<br>
<div class="card mx-auto" style="width: 18rem;">
  <img src="https://image.flaticon.com/icons/svg/1404/1404945.svg" class="card-img-top" alt="pizza icon">
  <div class="card-body">
    <h4 class="card-title text-center">Confirm your order</h4>
    <br>
		<h5>Pizza for: @Model.Customer</h5>
		<h5>Order: @Model.Order</h5>
    <h5>Extra Cheese: @Model.ExtraCheese</h5>
		<h5>Total: $@String.Format("{0:0.00}", Model.Total)</h5>
    <br>
    <a href="#" class="btn btn-primary">Place Order</a>
  </div>
</div>
