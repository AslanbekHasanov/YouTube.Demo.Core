// ---------------------------------------------------------------
// Copyright (c) Coalition of the Good-Hearted Engineers
// FREE TO USE TO CONNECT THE WORLD
// ---------------------------------------------------------------

using Xeptions;

namespace YouTube.Demo.Core.Api.Models.Exceptions
{
    public class VideoMetadataValidationException : Xeption
    {
        public VideoMetadataValidationException(Xeption innerException) 
            : base(message: "Student validation error occurred, fix errors and try again.", 
                  innerException: innerException)
        { }
    }
}