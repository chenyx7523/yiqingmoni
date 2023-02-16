using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public enum person_Type
{
    Herlthy,
    Hide,
    Burs,
    Hospital,
}



public class Person : MonoBehaviour
{
    

    private person_Type PType;
    private SpaceManager mySpace;

    private Image img;


    void Awake()
    {
        img = this.GetComponent<Image>();
    }

    //随机移动
    public void RandomMove()
    {

    }


    //传染
    public void Infection()
    {

    }

    //定时更新

    //人物状态


    //人物改变状态
    public void ChangeType(person_Type type)
    {
        switch (type) 
        {
            case person_Type.Herlthy:
                img.color = Color.white;
                break;
            case person_Type.Hide:
                img.color = Color.yellow;
                break;
            case person_Type.Burs:
                img.color = Color.red;
                break;
            case person_Type.Hospital:
                img.color = Color.green;
                break;
        }

        PType = type;


    }
    //改变人物空间
    public void ChangeSpace(SpaceManager NewSpace)
    {
        mySpace = NewSpace;
        //随机位置
        this.transform.localPosition = new Vector3(NewSpace.centerX - NewSpace.centerW / 2 + Random.Range(0, NewSpace.centerW),
                                                     NewSpace.centerY - NewSpace.centerH / 2 + Random.Range(0, NewSpace.centerH), 0);




    }


}
