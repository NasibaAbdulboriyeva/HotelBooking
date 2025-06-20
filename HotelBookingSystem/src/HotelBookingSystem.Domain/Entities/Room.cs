﻿namespace HotelBookingSystem.Domain.Entities;

public class Room
{
    public long RoomId { get; set; }
    public int RoomNumber { get; set; }
    public string RoomType { get; set; }
    public decimal Price { get; set; }
    public bool IsAvailable { get; set; } = true;
    public bool IsDeleted { get; set; } = false;
    public long HotelId { get; set; }
    public Hotel Hotel { get; set; }

    public List<BookingRoom> BookingRooms { get; set; } = new List<BookingRoom>();
}
