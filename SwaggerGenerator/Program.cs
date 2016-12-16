using NJsonSchema;
using NSwag.CodeGeneration.CodeGenerators.CSharp;
using NSwag.CodeGeneration.SwaggerGenerators.WebApi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwaggerGenerator
{
    class Program
    {
        static void Main(string[] args)
        {

            var swaggerSettings = new WebApiToSwaggerGeneratorSettings
            {
                DefaultPropertyNameHandling = NJsonSchema.PropertyNameHandling.CamelCase,
                DefaultUrlTemplate = "api/v0.1/{controller}/{id}",
                GenerateKnownTypes = true,
                TypeNameGenerator = new DefaultTypeNameGenerator(),     
            };
            var swaggerGenerator = new WebApiToSwaggerGenerator(swaggerSettings);

            var document = swaggerGenerator.GenerateForController<Controllers.CountriesController>();

            string json = document.ToJson();

            Console.WriteLine(json);

            System.IO.File.WriteAllText("CFlowSwagger.json", json);

            Console.ReadKey();

        }

    }
}
