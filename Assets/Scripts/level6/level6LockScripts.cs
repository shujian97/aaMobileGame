using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class level6LockScripts : MonoBehaviour
{
    public GameObject thisObject;
    // Start is called before the first frame update
    void Start()
    {
        if (PlayerPrefs.GetInt("level") < 6)
        {
            thisObject.active = true;
        }
        else
        {
            thisObject.active = false;
        }
    }
}
