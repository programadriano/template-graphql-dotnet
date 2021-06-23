using API.Models;
using System.Collections.Generic;
using System.Linq;

namespace API.Services
{
    public class NewsService
    {


        private static readonly IList<News> News = new List<News>
        {
            new News
            {
                Id = 1,
                Hat = "Hat 1",
                Title = "Title 1",
                Description = "Description 1"
            },
            new News
            {
                Id = 2,
                Hat = "Hat 2",
                Title = "Title 2",
                Description = "Description 2"
            }
        };


        public IEnumerable<News> GetAll()
        {
            return News.ToList();
        }

        public News GetById(int id)
        {
            return News.FirstOrDefault(x => x.Id == id);
        }        

    }
}
