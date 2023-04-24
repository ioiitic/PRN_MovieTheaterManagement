using System;
using System.Collections.Generic;

#nullable disable

namespace ObjectLibrary.ObjectLibrary
{
    public partial class Room
    {
        public int Id { get; set; }
        public int RoomNumber { get; set; }
        public int NumberOfSeat { get; set; }
        public int TheaterId { get; set; }
    }
}
