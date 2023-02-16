using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class city : SpaceManager

{
    public static city instance;
    public GameObject People;
    public List<Person> Persons = new List<Person>();
    public Hos hos;


    private int InfectionNum = 0;




    void Awake()
    {
        instance = this;
        centerX = -100;
        centerY = 0;
        centerH = 250;
        centerW = 250;

        
    }

    public void test(int sum)
    {
        
    }

    //���
    public void CreatePreson(int num)
    {
        StartCoroutine(BeginCreate(num));
    }


    public IEnumerator BeginCreate(int num)
    {
        Loading.instance.showtile("����������.....");
        yield return 0;
        InfectionNum = 0;
        
        //���
        for (int i = 0; i < Persons.Count; i++)
        {
            Destroy(Persons[i].gameObject);
            if (i % 200 == 0)
                yield return 0; 
        }
        Persons.Clear();







        Loading.instance.showtile("ģ�⽫��3���ʼ!!");
        yield return new WaitForSeconds(1f);
        Loading.instance.showtile("ģ�⽫��2���ʼ!!");
        yield return new WaitForSeconds(1f);
        Loading.instance.showtile("ģ�⽫��1���ʼ!!");
        yield return new WaitForSeconds(1f);
        Loading.instance.showtile("��ʼ!!");
        yield return new WaitForSeconds(1f);
        Loading.instance.Hidetile();



        for (int i = 0; i < num; i++)
        {
            //�������� = ��¡����(������Դ�й���person����Ʒ)
            //GameObject obj = Instantiate(Resources.Load<GameObject>("Person"));
            GameObject obj = Instantiate(People);
            obj.transform.SetParent(this.transform, false);
            //obj.transform.parent = this.transform;
            obj.transform.localScale = Vector3.one;
            obj.transform.localPosition = Vector3.zero;
            //��¼
            Person p = obj.GetComponent<Person>();
            Persons.Add(p);


            //��������״̬��λ��
            p.ChangeType(person_Type.Herlthy);
            
            p.ChangeSpace(this);

            if(InfectionNum < virus.chushiP)
            {
                ++InfectionNum;
                p.ChangeType(person_Type.Burs);

            }

            if (i % 200 == 0)
                yield return 0;

        }


        









    }



    public void CleanPreson()
    {
       



    }





}
