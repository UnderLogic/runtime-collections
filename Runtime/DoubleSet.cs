using UnityEngine;

namespace UnderLogic.Collections
{
    [CreateAssetMenu(menuName = "Collections/Sets/Double Set")]
    public class DoubleSet : RuntimeSet<double>
    {
        public void Add(int value) => Add((double)value);
        public void Add(float value) => Add((double)value);

        public bool Remove(int value) => Remove((double)value);
        public bool Remove(float value) => Remove((double)value);
    }
}
