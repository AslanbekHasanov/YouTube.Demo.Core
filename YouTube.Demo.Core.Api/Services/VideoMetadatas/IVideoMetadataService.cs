// ---------------------------------------------------------------
// Copyright (c) Coalition of the Good-Hearted Engineers
// FREE TO USE TO CONNECT THE WORLD
// ---------------------------------------------------------------

using System.Threading.Tasks;
using YouTube.Demo.Core.Api.Models.VideoMetadatas;

namespace YouTube.Demo.Core.Api.Services.VideoMetadatas
{
    internal interface IVideoMetadataService
    {
        ValueTask<VideoMetadata> AddVideoMetadataAsync(VideoMetadata videoMetadata);
    }
}