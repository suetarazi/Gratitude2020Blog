using System;
using Xunit;
using Blog.Models;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using Blog.Data;
using Microsoft.AspNetCore.Mvc;
using Blog.Models.Services;
using Blog;
using NuGet.Frameworks;
using Microsoft.EntityFrameworkCore.InMemory;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void CanAddPostTitle()
        {
            Post post = new Post();
            post.Title = "testTitle";
            Assert.Equal("testTitle", post.Title);

        }

        [Fact]
        public void CanAddPostAuthor()
        {
            Post post = new Post();
            post.Author = "testAuthor";
            Assert.Equal("testAuthor", post.Author);

        }

        [Fact]
        public void CanAddPostBody()
        {
            Post post = new Post();
            post.Body = "testBody: This is the body of my test post.";
            Assert.Equal("testBody: This is the body of my test post.", post.Body);

        }

        [Fact]
        public async Task<Post> CanAddPostToDb()
        {
            DbContextOptions<AppDbContext> testPost = new DbContextOptionsBuilder<AppDbContext>()
                .("CanAddPostToDb")
                .testPost;

            using (AppDbContext context = new AppDbContext(testPost))
            {
                Post post = new Post()
                {
                    Id = 1,
                    Author = "testAuthor",
                    Title = "testTitle",
                    Body = "this is the test body of my test post"
                };

                //put the post in the db
                var result = await context.Add(post);

                //see if the post exists in the db directly
                var data = context.Posts.Find(post.Id);

                Assert.Equal(result, data);
            }
        }

        [Fact]
        public async Task CanDeletePost()
        {
            DbContextOptions<AppDbContext> testPost = new DbContextOptionsBuilder<AppDbContext>()
                .UseInMemory

            Post post = new Post();
            post.Body = "testBody: This is the body of my test post.";
            Assert.Equal("testBody: This is the body of my test post.", post.Body);

        }

    }
}
