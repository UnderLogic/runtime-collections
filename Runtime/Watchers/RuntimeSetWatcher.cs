using UnityEngine;
using UnityEngine.Events;

namespace UnderLogic.Collections.Watchers
{
    public abstract class RuntimeSetWatcher<T, TSet> : MonoBehaviour where TSet : RuntimeSet<T>
    {
        [SerializeField] private TSet collectionSet;

        [Header("Behavior")]
        [SerializeField] private bool raiseOnAwake;
        [SerializeField] private bool raiseOnEnable;
        [SerializeField] private bool raiseOnStart;
        
        [Space]
        public UnityEvent<T> onItemAdded;

        [Space]
        public UnityEvent<T> onItemRemoved;
        
        [Space]
        public UnityEvent onItemsChanged;

        public void RaiseItemAdded(T value) => onItemAdded.Invoke(value);
        public void RaiseItemRemoved(T value) => onItemRemoved?.Invoke(value);
        public void RaiseItemsChanged() => onItemsChanged?.Invoke();

        private void Awake()
        {
            if (raiseOnAwake)
                RaiseItemsChanged();
        }

        private void Start()
        {
            if (raiseOnEnable)
                RaiseItemsChanged();
        }

        private void OnEnable()
        {
            if (collectionSet != null)
            {
                collectionSet.ItemAdded += RaiseItemAdded;
                collectionSet.ItemRemoved += RaiseItemRemoved;
                collectionSet.ItemsChanged += RaiseItemsChanged;
            }

            if (raiseOnStart)
                RaiseItemsChanged();
        }

        private void OnDisable()
        {
            if (collectionSet == null)
                return;

            collectionSet.ItemAdded -= RaiseItemAdded;
            collectionSet.ItemRemoved -= RaiseItemRemoved;
            collectionSet.ItemsChanged -= RaiseItemsChanged;
        }
    }
}