using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Limg : MonoBehaviour
{
    public Text JkP;
    public Text qfP;
    public Text BfP;
    public Text HbP;

    public static Limg instance;

    public void Awake()
    {
        instance = this;
    }

    public void SetJKnum(int num)
    {
        JkP.text = num + "人";
    }

    public void SetQFnum(int num)
    {
        JkP.text = num + "人";
    }

    public void SetBFnum(int num)
    {
        JkP.text = num + "人";
    }

    public void SetHBnum(int num)
    {
        JkP.text = num + "人";
    }











}
