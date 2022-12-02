using UnityEngine;
using UnityEngine.UI;

namespace UnderLogic.Collections.Samples
{
    public class NameListDisplay : MonoBehaviour
    {
        [SerializeField] private StringSet namesSet;

        [Header("UI")]
        [SerializeField] private Text headerText;
        [SerializeField] private RectTransform container;
        [SerializeField] private Transform nameTextPrefab;

        private void OnEnable()
        {
            if (namesSet == null)
                return;

            namesSet.ItemAdded += OnNameAdded;
            namesSet.ItemRemoved += OnNameRemoved;
        }

        private void OnDisable()
        {
            if (namesSet == null)
                return;

            namesSet.ItemAdded -= OnNameAdded;
            namesSet.ItemRemoved -= OnNameRemoved;
        }

        private void OnNameAdded(string value)
        {
            Debug.Log($"Name added: {value}");
            UpdateHeader();

            if (container == null || nameTextPrefab == null)
                return;

            var newInstance = Instantiate(nameTextPrefab, container);
            newInstance.name = $"Name - {value}";

            if (newInstance.TryGetComponent<Text>(out var textField))
                textField.text = value;
        }

        private void OnNameRemoved(string value)
        {
            Debug.Log($"Name removed: {value}");
            UpdateHeader();

            if (container == null)
                return;

            var child = container.Find($"Name - {value}");
            if (child != null)
                Destroy(child.gameObject);
        }

        private void UpdateHeader()
        {
            if (namesSet != null && headerText != null)
                headerText.text = $"Names Submitted ({namesSet.Count})";
        }
    }
}