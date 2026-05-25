using MauiAppHotel.Models;
using Microsoft.Extensions.DependencyInjection;

namespace MauiAppHotel
{
    public partial class App : Application
    {
        public List<Quarto> listas_quartos = new List<Quarto>
        {
            new Quarto()
            {
                Descricao = "Suíte custo beneficio",
                ValorDiariaAdulto = 110.0,
                ValorDiariaCrianca = 55.0
            },
            new Quarto()
            {
                Descricao = "Suíte Luxo",
                ValorDiariaAdulto = 300.0,
                ValorDiariaCrianca = 180.0
            },
            new Quarto()
            {
                Descricao = "Suíte Single",
                ValorDiariaAdulto = 120.0,
                ValorDiariaCrianca = 65.0
            },
            new Quarto()
            {
                Descricao = "Suíte crise",
                ValorDiariaAdulto = 65.0,
                ValorDiariaCrianca = 35.0
            }

        };
        public App()
        {
            InitializeComponent();
            
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {

            var window = new Window(new NavigationPage(new Views.ContratacaoHospedagem()));

            window.Width = 400;
            window.Height = 600;
            return window;
        }
    }
}