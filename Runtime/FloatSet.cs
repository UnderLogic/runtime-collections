using UnityEngine;

namespace UnderLogic.Collections
{
    [CreateAssetMenu(menuName = "Collections/Sets/Float Set")]
    public class FloatSet : RuntimeSet<float>
    {
        public void Add(int value) => base.Add(value);
        public bool TryAdd(int value) => base.TryAdd(value);
        public bool Remove(int value) => base.Remove(value);
    }
}
