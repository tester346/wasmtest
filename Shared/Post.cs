using System;

namespace wasm.Shared
{
    public class Post
    {
        public Guid Id { get; set; } = Guid.NewGuid();

        public DateTime CreationDate { get; set; } = DateTime.Now;

        public string Title { get; set; }

        public string Content { get; set; }
    }
}
