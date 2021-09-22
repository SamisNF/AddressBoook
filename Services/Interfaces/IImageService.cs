using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AddressBoook.Services.Interfaces
{
    public interface IImageService
    {
        public Task<byte[]> ConvertFileToByteArrayAsync(IFormFile file);
        public string ConvertByteArrayToFile(byte[] fileData, string extension);
    }
}

//This interface is an input & output for the database.
    // public Task<byte[]> is the database input.
    // public ConvertByteArrayToFile() is the database output

//Task<byte[]> represents an asynchronous operation that returns a byte[] value.