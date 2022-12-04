using UnityEngine;

namespace UnderLogic.Collections
{
    [CreateAssetMenu(menuName = "Collections/Sets/Vector2 Set")]
    public class Vector2Set : RuntimeSet<Vector2>
    {
        public void Add(Vector2Int value) => Add((Vector2)value);
        public bool Remove(Vector2Int value) => Remove((Vector2)value);
    }
}
