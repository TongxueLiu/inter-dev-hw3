using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger_1 : MonoBehaviour
{
    Vector3 pos = new Vector3(0, -4.56f, -10);

    bool triggered = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player" && !triggered)
        {
            Camera.main.gameObject.transform.position = pos;
            triggered = true;
        }
    }
}
