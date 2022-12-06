using UnityEngine;

namespace UnderLogic.Collections
{
    [CreateAssetMenu(menuName = "Collections/Sets/Vector3 Set")]
    public class Vector3Set : RuntimeSet<Vector3>
    {
        public void Add(Vector2Int value) => base.Add(new Vector3(value.x, value.y));
        public void Add(Vector2 value) => base.Add(new Vector3(value.x, value.y));
        
        public bool TryAdd(Vector2Int value) => base.TryAdd(new Vector3(value.x, value.y));
        public bool TryAdd(Vector2 value) => base.TryAdd(new Vector3(value.x, value.y));
        
        public bool Remove(Vector2Int value) => base.Remove(new Vector3(value.x, value.y));
        public bool Remove(Vector2 value) => base.Remove(new Vector3(value.x, value.y));
    }
}
