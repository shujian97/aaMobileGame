using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class quickPlayScoreScripts : MonoBehaviour
{
    public GameObject score;
    private TextMesh scoreText;
    public static int scoreValue;
    // Start is called before the first frame update
    void Start()
    {
        scoreText = score.GetComponent<TextMesh>();
        scoreValue = 0;
        PlayerPrefs.SetInt("currentValue", 0);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "pin")
        {
            scoreValue++;
            scoreText.text = System.Convert.ToString(scoreValue);
            PlayerPrefs.SetInt("currentScore",scoreValue);
        }
    }
}
