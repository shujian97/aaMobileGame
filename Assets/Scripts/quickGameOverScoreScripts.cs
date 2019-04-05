using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class quickGameOverScoreScripts : MonoBehaviour
{
    public GameObject currentScore;
    public GameObject highScore;

    private TextMesh csText;
    private TextMesh hsText;
    // Start is called before the first frame update
    void Start()
    {
        csText = currentScore.GetComponent<TextMesh>();
        hsText = highScore.GetComponent<TextMesh>();

        csText.text = System.Convert.ToString(PlayerPrefs.GetInt("currentScore"));
        if(PlayerPrefs.GetInt("currentScore") > PlayerPrefs.GetInt("highScore"))
        {
            PlayerPrefs.SetInt("highScore", PlayerPrefs.GetInt("currentScore"));
        }

        hsText.text = System.Convert.ToString(PlayerPrefs.GetInt("highScore"));
    }


  
}
