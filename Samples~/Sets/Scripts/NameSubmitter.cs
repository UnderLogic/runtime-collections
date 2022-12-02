using UnityEngine;
using UnityEngine.UI;

namespace UnderLogic.Collections.Samples
{
    public class NameSubmitter : MonoBehaviour
    {
        [SerializeField] private StringSet namesSet;

        [Header("Input")]
        [SerializeField] private InputField nameInput;
        [SerializeField] private Text errorLabel;

        [Header("Buttons")]
        [SerializeField] private Button submitButton;
        [SerializeField] private Button removeButton;

        public void Submit()
        {
            if (nameInput != null)
                Submit(nameInput.text);
        }

        public void Submit(string value)
        {
            if (namesSet != null && !string.IsNullOrWhiteSpace(value))
                namesSet.Add(value.Trim());

            if (nameInput == null)
                return;

            nameInput.text = string.Empty;
            nameInput.Select();
        }

        public void RequestRemove()
        {
            if (namesSet == null || nameInput == null)
                return;

            if (namesSet.Remove(nameInput.text.Trim()))
                nameInput.Select();
        }

        private void Update()
        {
            var inputText = nameInput != null ? nameInput.text.Trim() : string.Empty;
            var canSubmit = !string.IsNullOrWhiteSpace(inputText);
            var alreadyExists = false;
            var errorMessage = string.Empty;

            if (namesSet != null)
            {
                alreadyExists = namesSet.Contains(inputText);
                errorMessage = alreadyExists ? "Name has already been submitted" : string.Empty;
            }

            SetErrorMessage(errorMessage);
            UpdateButtons(canSubmit, alreadyExists);
        }

        private void SetErrorMessage(string message)
        {
            if (errorLabel == null)
                return;

            errorLabel.gameObject.SetActive(!string.IsNullOrWhiteSpace(message));
            errorLabel.text = message;
        }

        private void UpdateButtons(bool canSubmit, bool alreadyExists)
        {
            if (removeButton != null)
                removeButton.gameObject.SetActive(alreadyExists);

            if (submitButton != null)
            {
                submitButton.gameObject.SetActive(!alreadyExists);
                submitButton.interactable = canSubmit && !alreadyExists;
            }
        }
    }
}
