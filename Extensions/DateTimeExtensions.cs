using System;

namespace SkeletonDotNetCore.WebAPI.Extensions
{
    public static class DateTimeExtensions
    {
        public static long Timestamp(this DateTime date)
        {
            var sTime = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
 
            var timestamp = (long) (date - sTime).TotalSeconds;

            return timestamp;
        }
    }
}