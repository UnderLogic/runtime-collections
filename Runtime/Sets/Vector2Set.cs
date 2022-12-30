using UnityEngine;

namespace UnderLogic.Collections.Sets
{
    [CreateAssetMenu(menuName = "Collections/Sets/Vector2 Set")]
    public class Vector2Set : RuntimeSet<Vector2>
    {
        public void Add(Vector2Int value) => base.Add(new Vector2(value.x, value.y));
        public bool TryAdd(Vector2Int value) => base.TryAdd(new Vector2(value.x, value.y));
        public bool Remove(Vector2Int value) => base.Remove(new Vector2(value.x, value.y));
    }
}
