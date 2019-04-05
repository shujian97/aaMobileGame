using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class quickPlayButtonScripts : MonoBehaviour
{
    private void OnMouseDown()
    {
        SceneManager.LoadScene("quickPlayScene");
    }
}
