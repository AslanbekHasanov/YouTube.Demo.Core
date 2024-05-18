// ---------------------------------------------------------------
// Copyright (c) Coalition of the Good-Hearted Engineers
// FREE TO USE TO CONNECT THE WORLD
// ---------------------------------------------------------------

using Moq;
using Tynamix.ObjectFiller;
using YouTube.Demo.Core.Api.Brokers.Loggings;
using YouTube.Demo.Core.Api.Brokers.Storages;
using YouTube.Demo.Core.Api.Models.VideoMetadatas;
using YouTube.Demo.Core.Api.Services.VideoMetadatas;

namespace Youtube.Demo.Core.Api.Tests.Unit.Services.Foundations.VideoMetadatas
{
    public partial class VideoMetadataServiceTests
    {
        private readonly Mock<IStorageBroker> storageBrokerMock;
        private readonly Mock<ILoggingBroker> loggingBrokerMock;
        private readonly IVideoMetadataService videoMetadataService;

        public VideoMetadataServiceTests()
        {
            this.storageBrokerMock = new Mock<IStorageBroker>();
            this.loggingBrokerMock = new Mock<ILoggingBroker>();

            this.videoMetadataService = new VideoMetadataService(
                storageBroker: this.storageBrokerMock.Object,
                loggingBroker: this.loggingBrokerMock.Object);
        }

        private static DateTimeOffset GetRandomDateTime() =>
            new DateTimeRange(earliestDate: DateTime.UnixEpoch).GetValue();

        private static VideoMetadata CreateRandomVideoMetadata() =>
            CreateVideoMetadataFiller().Create();

        private static Filler<VideoMetadata> CreateVideoMetadataFiller()
        {
            var filler = new Filler<VideoMetadata>();

            filler.Setup()
                .OnType<DateTimeOffset>().Use(GetRandomDateTime());

            return filler;
        }
    }
}