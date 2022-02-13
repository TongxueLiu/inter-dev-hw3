using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Timer : MonoBehaviour
{
    float time;
    bool started;

    public TMP_Text titleText;

    // Start is called before the first frame update
    void Start()
    {
        time = 0;
        started = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            started = true;
        }

        if (started)
        {
            time += Time.deltaTime;
        }

        titleText.text = "Time Used: " + (int)time + " sec";
    }
}
