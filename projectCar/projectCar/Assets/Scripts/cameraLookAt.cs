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
        transform.position += new Vector3(0, target.transform.position.y + 10, 0);
    }

    // Update is called once per frame
    void Update()
    {
        float speed = target.GetComponent<carMove>().speed;
        transform.LookAt(target.transform.position);
        transform.position = new Vector3(this.transform.position.x, this.transform.position.y, this.transform.position.z + speed * Time.deltaTime);
    }
}
