using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace UnderLogic.Collections
{
    public abstract class RuntimeSet<T> : ScriptableObject, ICollection<T>
    {
        [SerializeField] private bool isReadOnly;
        [SerializeField] private List<T> initialItems = new();
        [SerializeField] private List<T> items;

        public event UnityAction<T> ItemAdded;
        public event UnityAction<T> ItemRemoved;
        public event UnityAction ItemsChanged;

        public bool IsReadOnly => isReadOnly;
        public IReadOnlyCollection<T> InitialItems => initialItems;

        public int Count => items.Count;
        public T this[int index] => items[index];

        public bool Contains(T value) => items.Contains(value);

        public int IndexOf(T value) => items.IndexOf(value);

        public bool TryGet(int index, out T value)
        {
            value = default;

            if (index < 0 || index >= items.Count)
                return false;

            value = items[index];
            return true;
        }

        public void Add(T value)
        {
            if (IsReadOnly)
                throw new InvalidOperationException("Collection is readonly, cannot add items");

            if (Contains(value))
                return;

            items.Add(value);
            OnItemAdded(value);
        }

        public bool Remove(T value)
        {
            if (IsReadOnly)
                throw new InvalidOperationException("Collection is readonly, cannot remove items");

            if (!items.Remove(value))
                return false;

            OnItemRemoved(value);
            return true;
        }

        public bool TryReplace(T searchValue, T replaceValue)
        {
            if (IsReadOnly)
                throw new InvalidOperationException("Collection is readonly, cannot replace items");

            if (!Remove(searchValue))
                return false;
            
            Add(replaceValue);
            return true;
        }

        public void Clear()
        {
            if (IsReadOnly)
                throw new InvalidOperationException("Collection is readonly, cannot clear items");

            for (var i = Count - 1; i >= 0; i--)
            {
                var removedItem = items[i];
                items.RemoveAt(i);

                OnItemRemoved(removedItem);
            }
        }

        public void CopyTo(T[] array, int arrayIndex) => items.CopyTo(array, arrayIndex);

        public void MakeReadOnly() => isReadOnly = true;

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
        public IEnumerator<T> GetEnumerator() => items.GetEnumerator();

        public void RaiseItemsChanged() => ItemsChanged?.Invoke();

        private void OnItemAdded(T value)
        {
            ItemAdded?.Invoke(value);
            ItemsChanged?.Invoke();
        }

        private void OnItemRemoved(T value)
        {
            ItemRemoved?.Invoke(value);
            ItemsChanged?.Invoke();
        }

        private void OnEnable()
        {
            items = new List<T>();
            
            foreach (var item in initialItems)
                if (!items.Contains(item))
                    items.Add(item);
        }

        private void OnValidate() => RaiseItemsChanged();
    }
}
