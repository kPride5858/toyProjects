using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextChanger : MonoBehaviour
{
    public Text textBox;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        List<int> obj = GameObject.Find("gameMaster").GetComponent <gameRule>().obj;
        textBox.text = obj[int.Parse(this.name)].ToString();
    }
}
