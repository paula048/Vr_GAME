using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro; // Import the TMPro namespace


public class QuizButton_test : MonoBehaviour
{
    public Button yourButton; // Reference to your button
    public TextMeshProUGUI winText; // Reference to the TextMeshProUGUI component

    void Start()
    {
        Button btn = yourButton.GetComponent<Button>();
        // Attach the Click() method to be called when the button is clicked
        btn.onClick.AddListener(Click);
    }

    void Click()
    {
		Debug.Log("YOU click me");
        // Set the text to "You WIN!" when the button is clicked
        winText.text = "You WIN!";
			

    }
}






