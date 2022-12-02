using UnityEngine;

namespace UnderLogic.Collections.Samples
{
    public class SelectionController : MonoBehaviour
    {
        [SerializeField] private TransformSet selectedTransforms;
        
        // Invoked by the square
        public void HandleSquareClicked(Transform t)
        {
            if (selectedTransforms == null || !t.TryGetComponent<ClickableSquare>(out var square))
                return;

            if (!selectedTransforms.Remove(square.transform))
                selectedTransforms.Add(square.transform);
        }

        // Invoked by the watcher
        public void OnSquareSelected(Transform t)
        {
            if (!t.TryGetComponent<ClickableSquare>(out var square))
                return;
            
            square.SetSelected(true);
            Debug.Log($"Selected: {square.name}");
        }
        
        // Invoked by the watcher
        public void OnSquareDeselected(Transform t)
        {
            if (!t.TryGetComponent<ClickableSquare>(out var square))
                return;
            
            square.SetSelected(false);
            Debug.Log($"Deselected: {square.name}");
        }
    }
}