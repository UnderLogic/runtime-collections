using System.Globalization;
using UnityEngine;

namespace UnderLogic.Collections
{
    [CreateAssetMenu(menuName = "Collections/Sets/String Set")]
    public class StringSet : RuntimeSet<string>
    {
        public void Add(bool value) => Add(value.ToString());
        public void Add(int value) => Add(value.ToString());
        public void Add(float value) => Add(value.ToString(CultureInfo.CurrentCulture));
        public void Add(double value) => Add(value.ToString(CultureInfo.CurrentCulture));

        public bool Remove(bool value) => Remove(value.ToString());
        public bool Remove(int value) => Remove(value.ToString());
        public bool Remove(float value) => Remove(value.ToString(CultureInfo.CurrentCulture));
        public bool Remove(double value) => Remove(value.ToString(CultureInfo.CurrentCulture));
    }
}