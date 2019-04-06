Feature: AddItemsToCart
	

@Chrome
Scenario: Agregar items a carrito
	Given El usuario ingresa a la pagina "https://www.ebay.com/"
	When el usuario ingresa la palabra "dress"
	And el usuario hace click en el boton buscar
	And cuando se muestre la pagina de resultados
	And  el usuario hace click en el primer elemento de la lista
	And se muestra la pagina del item seleccionado
	And el usuario selecciona el color "Red"
	And el usuario seleccionar el size "US 4/S"
	And el usuario hace click en el boton agregar al carro
	And se muestra la pagina de resultados del carrito
	And el usuario ingresa la palabra "dress"
	And el usuario hace click en el boton buscar
	And cuando se muestre la pagina de resultados
	And el usuario hace click en el segundo elemento de la lista
	And se muestra la pagina del item seleccionado
	And el usuario selecciona el color "A#"
	And el usuario seleccionar el size "S"
	And el usuario hace click en el boton agregar al carro
	And se muestra la pagina de resultados del carrito 
	Then verifico los nombres de los elementos agregados al carrito



