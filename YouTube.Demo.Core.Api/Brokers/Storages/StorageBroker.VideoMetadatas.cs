// ---------------------------------------------------------------
// Copyright (c) Coalition of the Good-Hearted Engineers
// FREE TO USE TO CONNECT THE WORLD
// ---------------------------------------------------------------

using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using YouTube.Demo.Core.Api.Models.VideoMetadatas;

namespace YouTube.Demo.Core.Api.Brokers.Storages
{
    internal partial class StorageBroker
    {
        public DbSet<VideoMetadata> VideoMetadatas { get; set; }

        public async ValueTask<VideoMetadata> InsertVideoMetadataAsync(VideoMetadata videoMetadata)
        {
            await this.AddAsync(videoMetadata);
            await this.SaveChangesAsync();

            return videoMetadata;
        }
    }
}
