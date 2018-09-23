using System;

namespace SkeletonDotNetCore.WebAPI.Helpers
{
    public static class Extensions
    {
        public static long CalculateTimestamp(this DateTime date)
        {
            var sTime = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
 
            var timestamp = (long) (date - sTime).TotalSeconds;

            return timestamp;
        }
    }
}