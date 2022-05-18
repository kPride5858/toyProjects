using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraLookAt : MonoBehaviour
{
    GameObject target;
    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.Find("target");
    }

    // Update is called once per frame
    void Update()
    {
        
        transform.LookAt(target.transform.position);
        transform.position = new Vector3(this.transform.position.x, target.transform.position.y + 10,this.transform.position.z);
    }
}
