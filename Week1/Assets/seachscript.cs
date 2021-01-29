using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class seachscript : MonoBehaviour
{
    public Button searchword;
    public InputField wordinput;
    public Text wordsresalt2;
    public string[] worddata = new string[5];
    // Start is called before the first frame update
    void Start()
    {
        worddata[0] = "test1";
        worddata[1] = "test2";
        worddata[2] = "test3";
        worddata[3] = "test4";
        worddata[4] = "test5";
    }
    // Update is called once per frame
    void Update()
    {
    }
    public void clicksearch()
    {
        if (worddata[0] == wordinput.text)
        {
            showresalt();
        }
        else if (worddata[1] == wordinput.text)
        {
            showresalt();
        }
        else if (worddata[2] == wordinput.text)
        {
            showresalt();
        }
        else if (worddata[3] == wordinput.text)
        {
            showresalt();
        }
        else if (worddata[4] == wordinput.text)
        {
            showresalt();
        }
        else
        {
            showresalt2();
        }
    }
    public void showresalt()
    {
        wordsresalt2.color = Color.green;
        wordsresalt2.text = "<color=White> [ </color>" + wordinput.text + "<color=White> ] </color>" + "<color=White> Is Found </color>";
    }
    public void showresalt2()
    {
        wordsresalt2.color = Color.red;
        wordsresalt2.text = "<color=White> [ </color>" + wordinput.text + "<color=White> ] </color>" + "<color=White> Is Not Found </color>";
    }
}

