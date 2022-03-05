using System;
using System.Collections;
using System.Collections.Generic;

namespace CustomList.Lib
{
    public class CustomListEnumerator<T> : IEnumerator<T>
    {

        private int index;
        private readonly CustomList<T> customList;

        T IEnumerator<T>.Current => customList[index];

        object IEnumerator.Current => customList[index];

        public CustomListEnumerator(CustomList<T> customList)
        {
            this.customList = customList;
        }


        public void Dispose()
        {
            //customList.Dispose();
        }

        public bool MoveNext()
        {
            index++;
            if (index < customList.Count)
            {
                return true;
            }
            return false;
        }

        public void Reset()
        {
            index = 0;
        }
    }
}
