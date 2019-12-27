using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using wasm.Shared;

namespace wasm.Client.Pages.Question
{
    public partial class Question
    {
        [Parameter]
        public Guid Id { get; set; }

        [Inject]
        private HttpContext _http { get; set; }

        public Post Post { get; set; }

        protected override async Task OnInitializedAsync()
        {
            Post = await _http.GET<Post>($"/api/questions/{Id}");
            await base.OnInitializedAsync();
        }
    }
}