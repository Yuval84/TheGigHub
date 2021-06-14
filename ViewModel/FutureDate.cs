using System;
using System.ComponentModel.DataAnnotations;
using System.Globalization;

namespace TheGigHub.ViewModel
{
    public class FutureDate : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            var isValid = DateTime.TryParseExact(Convert.ToString(value), "dd mm yyyy", CultureInfo.CurrentCulture,
                DateTimeStyles.None, out var dateTime);

            return isValid && dateTime > DateTime.Now;
        }
    }
}