using Microsoft.EntityFrameworkCore;
using System.Globalization;
using TimeBooking.Data.Context;
using TimeBooking.Data.Interfaces;
using TimeBooking.Data.Models;

namespace TimeBooking.Data.Services
{
    public class BuchungsService : IBuchungsService
    {
        public readonly zeiterfassungContext Context;

        public BuchungsService(zeiterfassungContext context)
        {
            Context = context;
        }

        public async Task<List<DailyBooking>> GetBookingsByEmployeeAsync(Guid id, DateTime date)
        {
            var list = new List<DailyBooking>();

            var startOfWeek = GetWeekToDisplay(date);

            var bookings = await Context.Buchungs.Include(x => x.Vorgang).Include(x => x.Vorgang.Projekt).Where(x => x.MitarbeiterId == id && startOfWeek.Date <= x.BuchungDatum.Date && x.BuchungDatum.Date <= startOfWeek.AddDays(7).Date).OrderBy(x => x.BuchungDatum.Date).ToListAsync();

            if (bookings == null)
            {
                throw new InvalidDataException("No bookings for employee found");
            }
            var dateTimeFormat = new CultureInfo("de-DE").DateTimeFormat;



            return Enumerable.Range(0, 7).Select(i => new DailyBooking()
            {
                Weekday = startOfWeek.AddDays(i).ToString("dddd", dateTimeFormat),
                Date = startOfWeek.AddDays(i),
                Details = bookings.Where(d => d.BuchungDatum.Date == startOfWeek.AddDays(i).Date).Select(entry => new BookingDetails()
                {
                    Id = entry.BuchungId,
                    Title = entry.BuchungText,
                    Hours = (decimal)(entry.BuchungZeitBis - entry.BuchungZeitVon).TotalHours,
                    Project = entry.Vorgang.Projekt.ProjektBezeichnung
                }).ToList()
            }).ToList();


            //return list;
        }

        public async Task CreateProduct(DailyBooking booking)
        {
            var test = booking;
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
