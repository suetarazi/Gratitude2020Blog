using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.Models.Interfaces
{
    public interface IPost
    {
        public Task<Post> GetPostById(int id);
        public Task<List<Post>> GetAllPosts();
        public Task<Post> AddPost(Post post);
        public Task<Post> UpdatePost(Post post);
        public Task DeletePost(int id);


    }
}
