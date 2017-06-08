using Nancy;

public class HomeModule : NancyModule
    {
        public HomeModule()
        {
            Get("/", args => "Aloha from .NET, using the NancyFX framework. This is version 2.0 of this program.");

            Get("/os", x =>
            {
                return System.Runtime.InteropServices.RuntimeInformation.OSDescription;
            });
        }
    }
