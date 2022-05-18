using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameRule : MonoBehaviour
{
    public List<int> obj = new List<int> { };
    public int score = 0;
    // Start is called before the first frame update

    // Update is called once per frame
    void Success()
    {
        obj[0] = obj[1];
        obj[1] = obj[2];
        obj[2] = Random.Range(1, 4);
        score += 100;
    }
    private void Start()
    {
        for (int i = 0; i < 3;i++)
        {
            obj.Add(Random.Range(1, 4)); 
        }
    }
    void Update()
    {
        for (int i = obj.Count; i > 3; i--)
        {
            obj.RemoveRange(3,obj.Count-3);
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow) && obj[0] == 1)
        {
            Success();
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow) && obj[0] == 2)
        {
            Success();
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow) && obj[0] == 3)
        {
            Success();
        }
    }
}
