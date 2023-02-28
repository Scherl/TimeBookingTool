namespace TimeBooking.Data.Models
{
    public class Globals
    {
        private Guid? EmployeeId;

        public Guid Id
        {
            get => EmployeeId ?? Guid.Empty;
            set
            {
                EmployeeId = value;
                NotifyStateChanged();
            }
        }

        private bool OpenEditForm;

        public bool OpenTimeEditForm
        {
            get => OpenEditForm;
            set
            {
                OpenEditForm = value;
                NotifyStateChanged();
            }
        }



        public event Action? OnChange;
        private void NotifyStateChanged() => OnChange?.Invoke();
    }
}
