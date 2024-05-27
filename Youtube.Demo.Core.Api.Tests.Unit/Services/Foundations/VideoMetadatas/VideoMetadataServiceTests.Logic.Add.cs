// ---------------------------------------------------------------
// Copyright (c) Coalition of the Good-Hearted Engineers
// FREE TO USE TO CONNECT THE WORLD
// ---------------------------------------------------------------

using FluentAssertions;
using Force.DeepCloner;
using Moq;
using YouTube.Demo.Core.Api.Models.VideoMetadatas;

namespace Youtube.Demo.Core.Api.Tests.Unit.Services.Foundations.VideoMetadatas
{
    public partial class VideoMetadataServiceTests
    {
        [Fact]
        public async Task ShouldAddVideoMetadataAsync()
        {
            //given
            VideoMetadata randomVideoMetadata = CreateRandomVideoMetadata();
            VideoMetadata inputVideoMetadata = randomVideoMetadata;
            VideoMetadata persistedVideoMetadata = inputVideoMetadata;
            VideoMetadata expectedVideoMetadata = persistedVideoMetadata.DeepClone();

            this.storageBrokerMock.Setup(broker =>
                broker.InsertVideoMetadataAsync(inputVideoMetadata))
                    .ReturnsAsync(persistedVideoMetadata);
            //when
            VideoMetadata actualVideoMetadata = await this.videoMetadataService
                .AddVideoMetadataAsync(inputVideoMetadata);

            //then
            actualVideoMetadata.Should().BeEquivalentTo(
                expectedVideoMetadata);

            this.storageBrokerMock.Verify(broker =>
                broker.InsertVideoMetadataAsync(inputVideoMetadata),
                    Times.Once());
            this.storageBrokerMock.VerifyNoOtherCalls();
            this.loggingBrokerMock.VerifyNoOtherCalls();
        }
    }
}