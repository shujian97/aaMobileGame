using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class level6ButtonScripts : MonoBehaviour
{
    public GameObject thisObject;
    private void OnMouseDown()
    {
        SceneManager.LoadScene("levelScene6");
    }
    // Start is called before the first frame update
    void Start()
    {
        if (PlayerPrefs.GetInt("level") > 5)
        {
            thisObject.active = true;
        }
        else
        {
            thisObject.active = false;
        }
    }
}
