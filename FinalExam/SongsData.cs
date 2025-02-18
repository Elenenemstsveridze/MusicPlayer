using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace FinalExam
{
    public class SongsData
    {
        [JsonPropertyName("songs")]
        public List<Song> Songs { get; set; }
    }
}
