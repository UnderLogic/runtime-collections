using System.Globalization;
using UnityEngine;

namespace UnderLogic.Collections
{
    [CreateAssetMenu(menuName = "Collections/Sets/String Set")]
    public class StringSet : RuntimeSet<string>
    {
        public void Add(bool value) => base.Add(value.ToString());
        public void Add(int value) => base.Add(value.ToString());
        public void Add(float value) => base.Add(value.ToString(CultureInfo.CurrentCulture));
        public void Add(double value) => base.Add(value.ToString(CultureInfo.CurrentCulture));

        public bool TryAdd(bool value) => base.TryAdd(value.ToString());
        public bool TryAdd(int value) => base.TryAdd(value.ToString());
        public bool TryAdd(float value) => base.TryAdd(value.ToString(CultureInfo.CurrentCulture));
        public bool TryAdd(double value) => base.TryAdd(value.ToString(CultureInfo.CurrentCulture));
        
        public bool Remove(bool value) => base.Remove(value.ToString());
        public bool Remove(int value) => base.Remove(value.ToString());
        public bool Remove(float value) => base.Remove(value.ToString(CultureInfo.CurrentCulture));
        public bool Remove(double value) => base.Remove(value.ToString(CultureInfo.CurrentCulture));
    }
}
