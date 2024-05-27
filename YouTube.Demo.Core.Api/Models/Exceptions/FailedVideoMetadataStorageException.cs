// ---------------------------------------------------------------
// Copyright (c) Coalition of the Good-Hearted Engineers
// FREE TO USE TO CONNECT THE WORLD
// ---------------------------------------------------------------

using System;
using Xeptions;
using Azure.Messaging;

namespace YouTube.Demo.Core.Api.Models.Exceptions
{
    public class FailedVideoMetadataStorageException : Xeption
    {
        public FailedVideoMetadataStorageException(string message, Exception innerException) 
            : base(message, innerException)
        { }
    }
}