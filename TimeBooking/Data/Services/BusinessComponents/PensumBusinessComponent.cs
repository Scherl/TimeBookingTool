using TimeBooking.Data.Interfaces;

namespace TimeBooking.Data.Services.BusinessComponents
{
    public class PensumBusinessComponent
    {
        private readonly IPensumService _pensumService;

        public PensumBusinessComponent(IPensumService pensumService)
        {
            _pensumService = pensumService;
        }

        public async Task<decimal> GetWeeklyWorkloadByEmployeeAsync(Guid id)
        {
            if (id == Guid.Empty) return decimal.Zero;
            var pensum = await _pensumService.GetWeeklyWorkloadByEmployeeAsync(id);
            return pensum;
        }
    }
}
