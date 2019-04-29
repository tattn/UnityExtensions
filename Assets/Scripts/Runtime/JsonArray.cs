using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UniExt
{
    [Serializable]
    public class JsonArray<T>
    {
        [SerializeField]
        private T[] array;

        public JsonArray(T[] array)
        {
            this.array = array;
        }

        public JsonArray(List<T> list)
        {
            this.array = list.ToArray();
        }

        public T[] Array
        {
            get
            {
                return this.array;
            }
        }

        public List<T> ToList()
        {
            return new List<T>(array);
        }
    }
}
