using UnityEngine;

namespace UnderLogic.Collections
{
    [CreateAssetMenu(menuName = "Collections/Sets/Vector4 Set")]
    public class Vector4Set : RuntimeSet<Vector4>
    {
        public void Add(Vector2Int value) => base.Add(new Vector4(value.x, value.y));
        public void Add(Vector2 value) => base.Add(new Vector4(value.x, value.y));
        public void Add(Vector3 value) => base.Add(new Vector4(value.x, value.y, value.z));
        
        public bool TryAdd(Vector2Int value) => base.TryAdd(new Vector4(value.x, value.y));
        public bool TryAdd(Vector2 value) => base.TryAdd(new Vector4(value.x, value.y));
        public bool TryAdd(Vector3 value) => base.TryAdd(new Vector4(value.x, value.y, value.z));
        
        public bool Remove(Vector2Int value) => base.Remove(new Vector4(value.x, value.y));
        public bool Remove(Vector2 value) => base.Remove(new Vector4(value.x, value.y));
        public bool Remove(Vector3 value) => base.Remove(new Vector4(value.x, value.y, value.z));
    }
}
