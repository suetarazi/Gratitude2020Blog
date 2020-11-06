using Blog.Data;
using Blog.Models.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace Blog.Models.Services
{
    public class PostService : IPost
    {
        private AppDbContext _context { get; }

        public PostService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<Post> AddPost(Post post)
        {
            _context.Add(post);
            await _context.SaveChangesAsync();
            return post;
        }

        public async Task DeletePost(int id)
        {
            _context.Remove(id);
            await _context.SaveChangesAsync();
        }

        public async Task<List<Post>> GetAllPosts()
        {
            return await _context.Posts.ToListAsync();
        }

        public async Task<Post> GetPostById(int id)
        {
            
            return await _context.Posts.FindAsync(id);
            
        }

        public async Task<Post> UpdatePost(Post post)
        {
            _context.Posts.Update(post);
            await _context.SaveChangesAsync();
            return post;
        }
    }
}
