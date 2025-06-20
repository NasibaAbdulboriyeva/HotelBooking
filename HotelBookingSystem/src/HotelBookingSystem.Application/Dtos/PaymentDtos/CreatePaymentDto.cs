﻿using HotelBookingSystem.Domain.Enums;

namespace HotelBookingSystem.Application.Dtos.PaymentDtos;
public class CreatePaymentDto
{
    public decimal PaidAmount { get; set; }
    public PaymentMethod PaymentMethod { get; set; }
    public long BookingId { get; set; }
    public long CardId { get; set; }
    public long UserId { get; set; }
}
