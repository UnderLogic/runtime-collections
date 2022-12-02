using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

namespace UnderLogic.Collections.Samples
{
    public class ClickableSquare : MonoBehaviour, IPointerDownHandler
    {
        private RectTransform _selectedOverlay;

        [Space]
        public UnityEvent onClick;
        
        public void OnPointerDown(PointerEventData e)
        {
            if (e.button != PointerEventData.InputButton.Left)
                return;

            Debug.Log($"Clicked: {name}", this);
            onClick?.Invoke();
        }

        public void SetSelected(bool isSelected)
        {
            _selectedOverlay.gameObject.SetActive(isSelected);
        }

        private void Awake() => _selectedOverlay = transform.Find("Selected") as RectTransform;
    }
}
