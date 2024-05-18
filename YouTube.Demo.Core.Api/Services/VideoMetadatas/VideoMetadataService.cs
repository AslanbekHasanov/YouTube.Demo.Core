// ---------------------------------------------------------------
// Copyright (c) Coalition of the Good-Hearted Engineers
// FREE TO USE TO CONNECT THE WORLD
// ---------------------------------------------------------------

using System;
using System.Threading.Tasks;
using YouTube.Demo.Core.Api.Brokers.Loggings;
using YouTube.Demo.Core.Api.Brokers.Storages;
using YouTube.Demo.Core.Api.Models.VideoMetadatas;

namespace YouTube.Demo.Core.Api.Services.VideoMetadatas
{
    internal class VideoMetadataService : IVideoMetadataService
    {
        private readonly IStorageBroker storageBroker;
        private readonly ILoggingBroker loggingBroker;

        public VideoMetadataService(
            IStorageBroker storageBroker, 
            ILoggingBroker loggingBroker)
        {
            this.storageBroker = storageBroker;
            this.loggingBroker = loggingBroker;
        }

        public async ValueTask<VideoMetadata> AddVideoMetadataAsync(VideoMetadata videoMetadata) =>
           await this.storageBroker.InsertVideoMetadataAsync(videoMetadata);
    }
}
