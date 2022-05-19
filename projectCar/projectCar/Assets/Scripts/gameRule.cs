using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameRule : MonoBehaviour
{
    public List<int> obj = new List<int> { };
    public int score = 0;
    public int hp = 3;
    // Start is called before the first frame update

    // Update is called once per frame
    void Success()
    {
        obj[0] = obj[1];
        obj[1] = obj[2];
        obj[2] = Random.Range(1, 4);
        score += 100;
    }
    void failed()
    {
        hp -= 1;
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
        if (Input.GetMouseButtonDown(0))
        {
            
            Vector3 mouseP = Input.mousePosition;
            if ( mouseP.x <= Screen.width / 3 && obj[0] == 1) //¿Þ
            {
                Success();
            }
            else if ( mouseP.x >= Screen.width / 3 && mouseP.x <= Screen.width/3*2 && obj[0] == 2) //°¡
            {
                Success();
            }
            else if ( mouseP.x >= Screen.width/3*2 && obj[0] == 3) //¿À
            {
                Success();
            }

        }
        
        else
        {
            failed();
        }
    }
}
