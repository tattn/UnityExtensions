using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UniExt
{

    public static class ColorExtension
    {
        /// <summary>
        /// Lighten by value %
        /// </summary>
        /// <param name="source"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public static Color Lighten(this Color source, float value) => Color.Lerp(source, Color.white, value);

        /// <summary>
        /// Darken by value %
        /// </summary>
        /// <param name="source"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public static Color Darken(this Color source, float value) => Color.Lerp(source, Color.black, value);

        public static float Luminance(this Color source)
        {
            // See <https://www.w3.org/TR/WCAG20/#relativeluminancedef>
            return 0.2126f * source.r + 0.7152f * source.g + 0.0722f * source.b;
        }

		public static Color WithAlpha(this Color source, float alpha)
		{
			source.a = alpha;
			return source;
		}
    }
}

