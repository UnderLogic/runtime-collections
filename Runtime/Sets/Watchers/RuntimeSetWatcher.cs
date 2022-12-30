using UnityEngine;
using UnityEngine.Events;

namespace UnderLogic.Collections.Sets.Watchers
{
    public abstract class RuntimeSetWatcher<T, TSet> : MonoBehaviour where TSet : RuntimeSet<T>
    {
        [SerializeField] private TSet collection;

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

        public TSet Collection => collection;

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
            if (collection != null)
            {
                collection.ItemAdded += RaiseItemAdded;
                collection.ItemRemoved += RaiseItemRemoved;
                collection.ItemsChanged += RaiseItemsChanged;
            }

            if (raiseOnStart)
                RaiseItemsChanged();
        }

        private void OnDisable()
        {
            if (collection == null)
                return;

            collection.ItemAdded -= RaiseItemAdded;
            collection.ItemRemoved -= RaiseItemRemoved;
            collection.ItemsChanged -= RaiseItemsChanged;
        }
    }
}
