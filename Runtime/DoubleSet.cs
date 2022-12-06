using UnityEngine;

namespace UnderLogic.Collections
{
    [CreateAssetMenu(menuName = "Collections/Sets/Double Set")]
    public class DoubleSet : RuntimeSet<double>
    {
        public void Add(int value) => TryAdd(value);
        public void Add(float value) => base.Add(value);

        public bool TryAdd(int value) => base.TryAdd(value);
        public bool TryAdd(float value) => base.TryAdd(value);

        public bool Remove(int value) => base.Remove(value);
        public bool Remove(float value) => base.Remove(value);
    }
}
