using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.Models.Interfaces
{
    public interface IPost
    {
        public Post GetPostById(int Id);
        List<Post> GetAllPosts();
        Post AddPost(Post post);
        Post UpdatePost(Post post);
        Post DeletePost(int Id);


    }
}
