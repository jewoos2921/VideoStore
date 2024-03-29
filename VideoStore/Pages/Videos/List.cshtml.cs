using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;
using VideoStore.Core;
using VideoStore.Data;

namespace VideoStore.Pages.Videos
{
    public class ListModel : PageModel
    {
        private readonly IConfiguration _config;
        private readonly IVideoData _videoData;
        public string PageTitle { get; set; }
        public IEnumerable<Video> Videos { get; set; }

        public ListModel(IConfiguration config, IVideoData videoData)
        {
            _config = config;
            _videoData = videoData;
        }

        public void OnGet()
        {
            PageTitle = _config["VideoListPageTitle"];
            Videos = _videoData.ListVideos();
        }
    }
}