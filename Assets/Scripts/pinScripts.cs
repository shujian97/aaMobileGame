using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class pinScripts : MonoBehaviour
{
    public float flySpeed = 20f;

    private Rigidbody2D pinBody;
    private bool shouldFly;
    // Start is called before the first frame update
    void Start()
    {
        shouldFly = true;
        pinBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(shouldFly == true)
        {
            pinBody.MovePosition(pinBody.position + Vector2.up * flySpeed * Time.deltaTime);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "target")
        {
            shouldFly = false;
            transform.SetParent(collision.gameObject.transform);
        }
        else if(collision.tag == "pin")
        {
            SceneManager.LoadScene("quickGameoverScene");
        }
    }
}
