﻿using LibraryAggregator.Common.Interface;
using LibraryAggregator.DataLayer.Entities;
using LibraryAggregator.DataLayer.Entities.Enum;
using Microsoft.AspNetCore.Mvc;

namespace LibraryAggregator.API.Controllers
{
    public class BookingController : ApiBaseController
    {
        private readonly IBookingService _bookingService;

        public BookingController(IBookingService bookingService)
        {
            _bookingService = bookingService;
        }

        [HttpGet(Name = "BookingList")]
        public async Task<IEnumerable<Booking>> GetListAsync()
        {
            return await _bookingService.GetBookingListAsync();
        }

        [HttpGet("{id}")]
        public async Task<Booking> GetByIdAsync(int id)
        {
            return await _bookingService.GetBookingByIdAsync(id);
        }

        [HttpGet("book/{id}")]
        public async Task<IEnumerable<BooksLibrary>> GetAvailableBookingByBookIdAsync(int id)
        {
            return await _bookingService.GetAvailableBookingByBookIdAsync(id);
        }

        [HttpPost]
        public async Task CreateAsync(Booking booking)
        {
            await _bookingService.CreateBookingAsync(booking);
        }

        [HttpDelete("{id}")]
        public async Task DeleteAsync(int id)
        {
            await _bookingService.DeleteBookingAsync(id);
        }

        //TODO: PUT and Attribute authorize
        [HttpPut]
        public async Task UpdateAsync(int id , BookingStatuses bookingStatuses)
        {
            await _bookingService.UpdateBookingAsync(id , bookingStatuses);
        }
    }
}
