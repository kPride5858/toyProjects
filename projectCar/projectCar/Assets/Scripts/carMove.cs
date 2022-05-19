using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class carMove : MonoBehaviour
{
    public float speed;
    public float sec = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        sec += Time.deltaTime;
        if (sec >= 1 && speed < 50)
        {
            speed += 0.5f;
            sec = 0;
        }
        transform.position += new Vector3(0, 0, speed * Time.deltaTime);
    }
}
