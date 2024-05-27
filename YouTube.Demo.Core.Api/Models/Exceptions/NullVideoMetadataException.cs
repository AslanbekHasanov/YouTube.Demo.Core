// ---------------------------------------------------------------
// Copyright (c) Coalition of the Good-Hearted Engineers
// FREE TO USE TO CONNECT THE WORLD
// ---------------------------------------------------------------

using Xeptions;

namespace YouTube.Demo.Core.Api.Models.Exceptions
{
    public class NullVideoMetadataException : Xeption
    {
        public NullVideoMetadataException() 
            : base(message: "Video Metadata is null.")
        { }
    }
}