using UnityEngine;
using TMPro;

public class CoordinateTracker : MonoBehaviour
{
    public Transform Player;
    public TextMeshProUGUI heightText;
    public float Highscore;

    public GameObject Cage1;
    public int Cage1Height = 20;
    public GameObject Cage2;
    public int Cage2Height = 40;
    public GameObject Cage3;
    public int Cage3Height = 100;


    void Update()
    {
        // Get the player's current Y position
        float playerY = Player.position.y - 0.1f;

        // If Y position is highest, update Highscore

        if (playerY > Highscore)
        {
            Highscore = playerY;
        }

        if (Input.GetKey(KeyCode.P))
        {
            Highscore = 500f;
        }

        // Format the position into a string
        string Heighttextonscreen = "Current Height: " + playerY.ToString("F1")+ " Units\n Maximum Height: " + Highscore.ToString("F1")+ " Units" ;

        // Update UI Text element
        heightText.text = Heighttextonscreen;


        // Unlock Part 1
        if (Highscore > Cage1Height) {
            Cage1.SetActive(false);
        }

        // Unlock Part 2
        if (Highscore > Cage2Height)
        {
            Cage2.SetActive(false);
        }

        // Unlock Part 3
        if (Highscore > Cage3Height)
        {
            Cage3.SetActive(false);
        }
    }
}