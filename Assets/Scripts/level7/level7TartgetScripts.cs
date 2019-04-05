using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class level7TartgetScripts : MonoBehaviour
{
    public GameObject score;
    private TextMesh scoreText;
    public static int scoreValue;
    // Start is called before the first frame update
    void Start()
    {
        scoreText = score.GetComponent<TextMesh>();
        scoreValue = 0;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "pin")
        {
            scoreValue++;
            scoreText.text = System.Convert.ToString(scoreValue);
            if (scoreValue == 16)
            {
                if (PlayerPrefs.GetInt("level") < 8)
                {
                    PlayerPrefs.SetInt("level", 8);
                }
                SceneManager.LoadScene("levelSuccessScene");
            }
        }
    }
}
