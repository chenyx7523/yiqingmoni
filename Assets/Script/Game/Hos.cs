using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hos : MonoBehaviour
{

    private int nowbednum;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    //初始化医院床位
    public void InitInfo(int num)
    {
        nowbednum = num;
    }


    //医院中添加人
    public bool AddPerson()
    {
        if (nowbednum > 0)
        {
            --nowbednum;
            return true ;
        }
        return false;
    }
}
