using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class level1ButtonScripts : MonoBehaviour
{
    private void OnMouseDown()
    {
        SceneManager.LoadScene("levelScene1");
    }
}
