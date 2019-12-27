using Microsoft.AspNetCore.Components;
using System.Collections.Generic;
using System.Threading.Tasks;
using wasm.Shared;

namespace wasm.Client.Pages.Index
{
    public partial class Index
    {
        [Inject]
        private HttpContext _http { get; set; }

        public List<Post> Posts { get; set; } = new List<Post>();

        protected override async Task OnInitializedAsync()
        {
            Posts = await _http.GET<List<Post>>("/api/questions/");
            await base.OnInitializedAsync();
        }
    }
}