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

    //清除
    public void CreatePreson(int num)
    {
        StartCoroutine(BeginCreate(num));
    }


    public IEnumerator BeginCreate(int num)
    {
        Loading.instance.showtile("数据生成中.....");
        yield return 0;
        InfectionNum = 0;
        
        //清空
        for (int i = 0; i < Persons.Count; i++)
        {
            Destroy(Persons[i].gameObject);
            if (i % 200 == 0)
                yield return 0; 
        }
        Persons.Clear();







        Loading.instance.showtile("模拟将在3秒后开始!!");
        yield return new WaitForSeconds(1f);
        Loading.instance.showtile("模拟将在2秒后开始!!");
        yield return new WaitForSeconds(1f);
        Loading.instance.showtile("模拟将在1秒后开始!!");
        yield return new WaitForSeconds(1f);
        Loading.instance.showtile("开始!!");
        yield return new WaitForSeconds(1f);
        Loading.instance.Hidetile();



        for (int i = 0; i < num; i++)
        {
            //创建对象 = 克隆出来(查找资源中挂载person的物品)
            //GameObject obj = Instantiate(Resources.Load<GameObject>("Person"));
            GameObject obj = Instantiate(People);
            obj.transform.SetParent(this.transform, false);
            //obj.transform.parent = this.transform;
            obj.transform.localScale = Vector3.one;
            obj.transform.localPosition = Vector3.zero;
            //记录
            Person p = obj.GetComponent<Person>();
            Persons.Add(p);


            //赋予人物状态和位置
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
