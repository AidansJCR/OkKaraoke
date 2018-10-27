using System;

namespace karaoke.SongRequest
{
    class AddRequest : IAddRequest
    {
        private String SongName { get; set; }
        private String Requester { get; set; }
    }
}