using API.Models;
using HotChocolate.Types;


namespace API.GraphQL.Types
{
    public class NewsTypes : ObjectType<News>
    {
        protected override void Configure(IObjectTypeDescriptor<News> news)
        {
            news.Field(t => t.Id).Type<IntType>();
            news.Field(t => t.Hat).Type<StringType>().Description("news hat example");
            news.Field(t => t.Title).Type<StringType>().Description("news title example");
            news.Field(t => t.Description).Type<StringType>().Description("news description example");
        }
    }
}
