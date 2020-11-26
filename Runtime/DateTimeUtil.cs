using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UniExt
{
    public static class DateTimeExtension
    {
        private static DateTime unixEpoch = new DateTime(1970, 1, 1, 0, 0, 0, 0);

        public static long GetUnixTime(this DateTime source) => (long)(source - unixEpoch).TotalSeconds;

        public static DateTime GetDateTime(long unixTime) => unixEpoch.AddSeconds(unixTime);
    }
}

