using System;
using System.Collections.Generic;

#nullable disable

namespace ObjectLibrary.ObjectLibrary
{
    public partial class Ticket
    {
        public int Id { get; set; }
        public bool Status { get; set; }
        public decimal Price { get; set; }
        public int SeatId { get; set; }
        public byte[] BuyTime { get; set; }
        public int RoomId { get; set; }
        public int NovieId { get; set; }
        public int UserId { get; set; }
        public int ShowtimeId { get; set; }
    }
}
