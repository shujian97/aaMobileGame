using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class level5ButtonScripts : MonoBehaviour
{
    public GameObject thisObject;
    private void OnMouseDown()
    {
        SceneManager.LoadScene("levelScene5");
    }
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("the level : " + PlayerPrefs.GetInt("level"));
        if (PlayerPrefs.GetInt("level") > 4)
        {
            thisObject.active = true;
        }
        else
        {
            thisObject.active = false;
        }
    }
}
