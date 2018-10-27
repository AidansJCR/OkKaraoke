using System;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json.Serialization;

namespace karaoke.SongRequest
{
    public interface IAddResponse
    {
        String Error { get; set; }
                
    }
}