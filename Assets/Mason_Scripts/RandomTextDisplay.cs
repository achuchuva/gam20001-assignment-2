using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class RandomTextDisplay : MonoBehaviour
{
    public string[] texts; // Array to hold random texts
    public float displayDistance = 5f; // Distance at which text should start displaying
    private bool playerInRange = false; // Flag to track if player is in range

    private TextMeshPro textMesh; // Reference to TextMeshPro component

    void Start()
    {
        // Get reference to TextMeshPro component
        textMesh = GetComponent<TextMeshPro>();
        // Disable text display initially
        HideText();
    }

    void Update()
    {
        // Check if the player is in range
        if (playerInRange)
        {
            // Display random text
            DisplayRandomText();
        }
        else
        {
            // Hide text if player is not in range
            HideText();
        }
    }

    void OnTriggerEnter(Collider other)
    {
        // Check if the colliding object is the player
        if (other.CompareTag("Player"))
        {
            playerInRange = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        // Check if the colliding object is the player
        if (other.CompareTag("Player"))
        {
            playerInRange = false;
        }
    }

    void DisplayRandomText()
    {
        // Choose a random text from the array
        string randomText = texts[Random.Range(0, texts.Length)];
        // Display the text on the object
        textMesh.text = randomText;
    }

    void HideText()
    {
        // Hide the text
        textMesh.text = "";
    }
}
