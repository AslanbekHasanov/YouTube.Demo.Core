// ---------------------------------------------------------------
// Copyright (c) Coalition of the Good-Hearted Engineers
// FREE TO USE TO CONNECT THE WORLD
// ---------------------------------------------------------------

using Xeptions;

namespace YouTube.Demo.Core.Api.Models.Exceptions
{
    public class VideoMetadataDependencyException : Xeption
    {
        public VideoMetadataDependencyException(string message, Xeption innerException) 
            : base(message, innerException)
        { }
    }
}