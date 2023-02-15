using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Rimg : MonoBehaviour
{
    public InputField cityP;
    public InputField chushiP;
    public InputField chuanboValue;
    public InputField quanfuTime;
    public InputField Hosbed;
    public InputField HosTime;
    public InputField Go;

    public Button StarButton;

    public static Rimg intance;

    private void Awake()
    {
        intance = this;

        Debug.Log("2222");
        Debug.Log(cityP.text);
    }

    public void StarB()
    {
        Debug.Log("开始");
        
        //重置病毒数据
        //Restlimg();
        //创建人
        city.instance.CreatePreson(int.Parse(cityP.text));
       


    }


    //将输入的数据传入
    private void Restlimg()
    {
        virus.chushiP = int.Parse(chushiP.text);
        virus.chuanboValue = int.Parse(chuanboValue.text);
        virus.qianfuTime = int.Parse(quanfuTime.text);
        virus.HosBed = int.Parse(Hosbed.text);
        virus.HosTIme = int.Parse(HosTime.text);
        virus.GoValue = int.Parse(Go.text);







    }






}
