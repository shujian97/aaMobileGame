using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class level7LockScripts : MonoBehaviour
{
    public GameObject thisObject;
    // Start is called before the first frame update
    void Start()
    {
        if (PlayerPrefs.GetInt("level") < 7)
        {
            thisObject.active = true;
        }
        else
        {
            thisObject.active = false;
        }
    }
}
