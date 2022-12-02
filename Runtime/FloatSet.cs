using UnityEngine;

namespace UnderLogic.Collections
{
    [CreateAssetMenu(menuName = "Collections/Sets/Float Set")]
    public class FloatSet : RuntimeSet<float>
    {
        public void Add(int value) => Add((float)value);
        public bool Remove(int value) => Remove((float)value);
    }
}