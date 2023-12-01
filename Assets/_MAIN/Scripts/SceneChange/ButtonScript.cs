using UnityEngine;
using UnityEngine.UI;

public class ButtonClickHandler : MonoBehaviour
{
    private Button button;

    private void Start()
    {
        // Get the Button component attached to this GameObject
        button = GetComponent<Button>();

        // Add a listener for the button click
        if (button != null)
        {
            button.onClick.AddListener(OnClick);
        }
        else
        {
            Debug.LogError("Button component not found!");
        }
    }

    private void OnClick()
    {
        // This method will be called when the button is clicked
        Debug.Log("Button clicked!");
        // Add your custom code or scene changing logic here
    }
}

