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
    //��ʼ��ҽԺ��λ
    public void InitInfo(int num)
    {
        nowbednum = num;
    }


    //ҽԺ�������
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
