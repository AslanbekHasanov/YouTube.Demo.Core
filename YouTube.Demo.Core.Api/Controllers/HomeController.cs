// ---------------------------------------------------------------
// Copyright (c) Coalition of the Good-Hearted Engineers
// FREE TO USE TO CONNECT THE WORLD
// ---------------------------------------------------------------

using Microsoft.AspNetCore.Mvc;
using RESTFulSense.Controllers;
using YouTube.Demo.Core.Api.Brokers.Storages;
using YouTube.Demo.Core.Api.Models.VideoMetadatas;

namespace YouTube.Demo.Core.Api.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class HomeController : RESTFulController
    {
        private readonly IStorageBroker storageBroker;
        public HomeController(IStorageBroker storageBroker)
        {
            this.storageBroker = storageBroker;
        }

        [HttpGet]
        public ActionResult<string> Get() =>
            Ok("Hello World. I'm Aslan.");

        [HttpPost]
        public async ValueTask<ActionResult<VideoMetadata>> Post(VideoMetadata videoMetadata)
        {
            var storageVideoMetadata =
                await this.storageBroker.InsertVideoMetadataAsync(videoMetadata);

            return Created(storageVideoMetadata);
        }

    }
}
