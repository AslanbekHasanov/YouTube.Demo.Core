// ---------------------------------------------------------------
// Copyright (c) Coalition of the Good-Hearted Engineers
// FREE TO USE TO CONNECT THE WORLD
// ---------------------------------------------------------------
using Microsoft.Extensions.Logging;

namespace YouTube.Demo.Core.Api.Brokers.Loggings
{
    public class LoggingBroker : ILoggingBroker
    {
        private readonly ILogger<LoggingBroker> logger;

        public LoggingBroker(ILogger<LoggingBroker> logger)=>
            this.logger = logger;

        public void LogCritical(Exception exception) =>
            this.logger.LogCritical(exception.Message, exception);

        public void LogError(Exception exception)=>
            this.logger.LogError(exception.Message,exception);
    }
}
