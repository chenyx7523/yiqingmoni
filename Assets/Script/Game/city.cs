using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class city : MonoBehaviour
{
    public static city instance;
    public GameObject People;
    public List<Person> Persons = new List<Person>();
    public Hos hos;

    void Awake()
    {
        instance = this;
        
    }

    public void test(int sum)
    {
        
    }

    public void CreatePreson(int num)
    {
        Debug.Log(num);
        for (int i = 0; i < num; i++)
        {
            //�������� = ��¡����(������Դ�й���person����Ʒ)
            //GameObject obj = Instantiate(Resources.Load<GameObject>("Person"));
            GameObject obj = Instantiate(People);
            obj.transform.parent = this.transform;
            obj.transform.localScale = Vector3.one;

            obj.transform.localPosition = Vector3.zero;
            //��¼
            Person p = obj.GetComponent<Person>();
            Persons.Add(p);


        }













    }



    public void CleanPreson(int num)
    {
        
    }





}
