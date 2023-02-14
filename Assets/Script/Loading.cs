using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Loading : MonoBehaviour
{
    public Text tile;
    public static Loading instance;

    public void Awake()
    {
        instance = this;
        Hidetile();
    }

    public void showtile(string Info)
    {
        this.gameObject.SetActive(true);
        tile.text = Info;
    }


    public void Hidetile()
    {
        this.gameObject.SetActive(false);
    }





}
