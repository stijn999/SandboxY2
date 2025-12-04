using UnityEngine;
using TMPro;

public class CoordinateTracker : MonoBehaviour
{
    public Transform Player;
    public TextMeshProUGUI heightText;

    void Update()
    {
        // Get the player's current Y position (world space)
        float playerY = Player.position.y;

        // Format the position into a string
        string yCoordString = "Height: " + playerY.ToString("F1")+ " Units";

        // Update UI Text element
        heightText.text = yCoordString;
    }
}