using API.Models;
using API.Services;
using System.Collections.Generic;

namespace API.GraphQL
{
    public class Query
    {
        public News NewsById(int id) => new NewsService().GetById(id);
        public IEnumerable<News> News => new NewsService().GetAll();

    }
}
