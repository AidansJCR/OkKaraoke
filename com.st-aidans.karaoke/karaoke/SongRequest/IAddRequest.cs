using System;

namespace karaoke.SongRequest
{
    public interface IAddRequest
    {
        String SongName { get; set; }
        String Requester { get; set; }
    }
}