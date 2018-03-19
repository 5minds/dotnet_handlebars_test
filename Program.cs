namespace dotnet_handlebars_test
{
    using System;
    using HandlebarsDotNet;

    class Program
    {
        static void Main(string[] args)
        {
            string source =
@"<div class=""entry"">
    <h1>{{title}}</h1>
    <div class=""body"">
    {{body}}
    </div>
</div>";

            var template = Handlebars.Compile(source);

            var data = new {
                title = "My new post",
                body = "This is my first post!"
            };

            var result = template(data);


            Console.WriteLine(result);
        }
    }
}
