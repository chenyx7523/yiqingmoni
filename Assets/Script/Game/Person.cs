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

    //����ƶ�
    public void RandomMove()
    {

    }


    //��Ⱦ
    public void Infection()
    {

    }

    //��ʱ����

    //����״̬


    //����ı�״̬
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
    //�ı�����ռ�
    public void ChangeSpace(SpaceManager NewSpace)
    {
        mySpace = NewSpace;
        //���λ��
        this.transform.localPosition = new Vector3(NewSpace.centerX - NewSpace.centerW / 2 + Random.Range(0, NewSpace.centerW),
                                                     NewSpace.centerY - NewSpace.centerH / 2 + Random.Range(0, NewSpace.centerH), 0);




    }


}
