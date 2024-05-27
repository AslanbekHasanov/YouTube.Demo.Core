// ---------------------------------------------------------------
// Copyright (c) Coalition of the Good-Hearted Engineers
// FREE TO USE TO CONNECT THE WORLD
// ---------------------------------------------------------------

using System;
using Xeptions;

namespace YouTube.Demo.Core.Api.Models.Exceptions
{
    public class AlreadyExitsVideoMetadataException : Xeption
    {
        public AlreadyExitsVideoMetadataException(string message, Exception innerException) 
            : base(message: message, innerException: innerException)
        { }
    }
}