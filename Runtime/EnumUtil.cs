using System;
using System.Collections.Generic;
using System.Linq;

namespace UniExt
{
    public static class EnumUtil
    {
        public static IEnumerable<T> GetValues<T>() => Enum.GetValues(typeof(T)).Cast<T>();

        public static T ToEnum<T>(int value) => (T)Enum.ToObject(typeof(T), value);
    }
}

