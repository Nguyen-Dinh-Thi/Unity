using UnityEngine;
using UnityEngine.UI;
using System.Collections;

namespace CompleteProject
{
    public class ScoreManager : MonoBehaviour
    {
        public static int score;        // The player's score.
        public GameObject Si;
        public int j;
        PlayerMovement playerMovement;                              // Reference to the player's movement.
        PlayerShooting playerShooting;
        Text text;                      // Reference to the Text component.


        void Awake ()
        {
            // Set up the reference.
            text = GetComponent <Text> ();
            playerMovement = GetComponent<PlayerMovement>();
            playerShooting = GetComponentInChildren<PlayerShooting>();
            // Reset the score.
            score = 0;
         
        }


        void Update ()
        {
            // Set the displayed text to be the word "Score" followed by the score value.
            text.text = "Score: " + score;

            if (score >= j)
            {
                Si.SetActive(true);
                Time.timeScale = 0;
                
            }
        }
    }
}