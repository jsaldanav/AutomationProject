using BaseAutomation.Pages;
using System;
using TechTalk.SpecFlow;

namespace BaseAutomation
{
    [Binding]
    public class AddItemsToCartSteps
    {

        SearchItemPage searchitempage = new SearchItemPage();
        ItemResultPage itemresultpage = new ItemResultPage();
        ItemDetailsPage itemdetailspage = new ItemDetailsPage();
        CartResultPage cartpage = new CartResultPage();

        [Given(@"El usuario ingresa a la pagina ""(.*)""")]
        public void GivenElUsuarioIngresaALaPagina(string url)
        {
            searchitempage.Navigate(url);
        }
        
        [When(@"el usuario ingresa la palabra ""(.*)""")]
        public void WhenElUsuarioIngresaLaPalabra(string texto)
        {
            searchitempage.inputSearchText(texto);
        }
        
        [When(@"el usuario hace click en el boton buscar")]
        public void WhenElUsuarioHaceClickEnElBotonBuscar()
        {
            searchitempage.clickOnSearchButton();
        }
        
        [When(@"cuando se muestre la pagina de resultados")]
        public void WhenCuandoSeMuestreLaPaginaDeResultados()
        {
            itemresultpage.validatePageResult();
        }
        
        [When(@"cambio tipo de vista a lista")]


        [When(@"el usuario hace click en el primer elemento de la lista")]
        public void WhenElUsuarioHaceClickEnElPrimerElementoDeLaLista()
        {
            itemresultpage.clickFirstItem();
        }
        
        [When(@"se muestra la pagina del item seleccionado")]
        public void WhenSeMuestraLaPaginaDelItemSeleccionado()
        {
            itemdetailspage.validatePageDetailResult();
        }
        [When(@"el usuario selecciona el color ""(.*)""")]
        public void WhenElUsuarioSeleccionaElColor(string color)
        {
            itemdetailspage.selectColor(color);
        }

        [When(@"el usuario seleccionar el size ""(.*)""")]
        public void WhenElUsuarioSeleccionarElSize(string size)
        {
            itemdetailspage.selectSize(size);
        }

        [When(@"el usuario hace click en el boton agregar al carro")]
        public void WhenElUsuarioHaceClickEnElBotonAgregarAlCarro()
        {
            itemdetailspage.addItemToCart();
        }

        [When(@"se muestra la pagina de resultados del carrito")]
        public void WhenSeMuestraLaPaginaDeResultadosDelCarrito()
        {
            cartpage.validatePageDetailResult();
        }

        [When(@"el usuario hace click en el segundo elemento de la lista")]
        public void WhenElUsuarioHaceClickEnElSegundoElementoDeLaLista()
        {
            itemresultpage.clickSecondItem();
        }
        
        [Then(@"verifico los nombres de los elementos agregados al carrito")]
        public void ThenVerificoLosNombresDeLosElementosAgregadosAlCarrito()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
