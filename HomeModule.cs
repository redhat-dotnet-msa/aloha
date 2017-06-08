using Nancy;

public class HomeModule : NancyModule
    {
        public HomeModule()
        {
            Get("/", args => "Aloha from .NET, using the NancyFX framework.");

            Get("/os", x =>
            {
                return System.Runtime.InteropServices.RuntimeInformation.OSDescription;
            });
        }
    }
