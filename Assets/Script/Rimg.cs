using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Rimg : MonoBehaviour
{
    public InputField cityp;
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
        StarButton.onClick.AddListener(StarB);
        Debug.Log("2222");
    }

    public void StarB()
    {
        Debug.Log("1111");
    }









    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
