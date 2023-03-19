using Microsoft.EntityFrameworkCore;
using System.Globalization;
using TimeBooking.Data.Context;
using TimeBooking.Data.Interfaces;
using TimeBooking.Data.Models;

namespace TimeBooking.Data.Services
{
    public class BookingService : IBookingService
    {
        public readonly zeiterfassungContext Context;

        public BookingService(zeiterfassungContext context)
        {
            Context = context;
        }

        public async Task<List<DailyBooking>> GetBookingsByEmployeeAsync(Guid id, DateTime date)
        {
            var startOfWeek = GetWeekToDisplay(date);

            var bookings = await Context.Bookings.Include(x => x.Process).Include(x => x.Process.Project).Where(x => x.EmployeeId == id && startOfWeek.Date <= x.BookingDate.Date && x.BookingDate.Date <= startOfWeek.AddDays(7).Date).OrderBy(x => x.BookingDate.Date).ToListAsync();

            if (bookings == null)
            {
                throw new InvalidDataException("No bookings for employee found");
            }
            var dateTimeFormat = new CultureInfo("de-DE").DateTimeFormat;



            return Enumerable.Range(0, 7).Select(i => new DailyBooking()
            {
                Weekday = startOfWeek.AddDays(i).ToString("dddd", dateTimeFormat),
                Date = startOfWeek.AddDays(i),
                Details = bookings.Where(d => d.BookingDate.Date == startOfWeek.AddDays(i).Date).Select(entry => new BookingDetails()
                {
                    Id = entry.BookingId,
                    Title = entry.BookingComment,
                    Hours = (decimal)(entry.BookingTill - entry.BookingFrom).TotalHours,
                    Project = entry.Process.Project.ProjectName
                }).ToList()
            }).ToList();

        }

        public async Task InsertBooking(DailyBookingEntry booking)
        {
            if (booking != null)
            {
                var newBooking = new Booking
                {
                    BookingId = Guid.NewGuid(),
                    ProcessId = booking.ProcessId,
                    EmployeeId = booking.EmployeeId,
                    BookingDate = booking.BookingDate,
                    BookingFrom = DateTime.UnixEpoch,
                    BookingTill = DateTime.UnixEpoch.AddHours((double)booking.Hours),
                    BookingComment = booking.Comment,
                    Hours = true

                };
                await Context.AddAsync(newBooking);
                await Context.SaveChangesAsync();

            }

           
        }

        private static DateTime GetWeekToDisplay(DateTime date)
        {
            var startOfWeek = date.AddDays(
                  (int)CultureInfo.CurrentCulture.DateTimeFormat.FirstDayOfWeek -
                  (int)date.DayOfWeek);

            return startOfWeek;
        }


    }
}
