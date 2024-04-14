using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowPrompt : MonoBehaviour
{
    public Canvas promptCanvas; // Reference to the Canvas that says 'Random prompt'
    public Text textObject; // Reference to the Text object in the canvas
    public string[] texts; // Array of texts to display

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Player Entered");
            // Show prompt
            promptCanvas.enabled = true;
            // Display random text
            DisplayRandomText();
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Player Exits");
            // Hide prompt
            promptCanvas.enabled = false;
        }
    }

    void DisplayRandomText()
    {
        // Check if there are any texts in the array
        if (texts.Length > 0)
        {
            // Select a random index
            int randomIndex = Random.Range(0, texts.Length);

            // Set the text of the Text object to the randomly selected text
            textObject.text = texts[randomIndex];
        }
        else
        {
            Debug.LogError("No texts to display!");
        }
    }
}

