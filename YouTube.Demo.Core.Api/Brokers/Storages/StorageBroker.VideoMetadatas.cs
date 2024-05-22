// ---------------------------------------------------------------
// Copyright (c) Coalition of the Good-Hearted Engineers
// FREE TO USE TO CONNECT THE WORLD
// ---------------------------------------------------------------

using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;
using YouTube.Demo.Core.Api.Models.VideoMetadatas;

namespace YouTube.Demo.Core.Api.Brokers.Storages
{
    internal partial class StorageBroker
    {
        public DbSet<VideoMetadata> VideoMetadatas { get; set; }

        public async ValueTask<VideoMetadata> InsertVideoMetadataAsync(VideoMetadata videoMetadata) =>
            await InsertAsync(videoMetadata);

        public async ValueTask<VideoMetadata> DeleteVideoMetadataAsync(VideoMetadata videoMetadata)=>
            await DeleteAsync(videoMetadata);

        public IQueryable<VideoMetadata> SelectAllVideoMetadataAsync()=>
            SelectAll<VideoMetadata>();

        public async ValueTask<VideoMetadata> SelectVideoMetadataByIdAsync(Guid videoMetadataId) =>
            await SelectAsync<VideoMetadata>(videoMetadataId);


        public async ValueTask<VideoMetadata> UpdateVideoMetadataAsync(VideoMetadata videoMetadata)=>
            await UpdateAsync(videoMetadata);
    }
}
