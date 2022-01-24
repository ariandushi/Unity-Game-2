using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class BuildMode : MonoBehaviour
{
    public Button myBut;
    public Button myBut1;
    bool isit = false;
    void Start()
    {

    }


    void Update()
    {
    
    }
    public void ButtonEnable()
    {
        if (isit==true)
        {
            myBut.gameObject.SetActive(false);
            myBut1.gameObject.SetActive(false);
            isit = false;
        }
        else
        {
            myBut.gameObject.SetActive(true);
            myBut1.gameObject.SetActive(true);
            isit = true;
        }
    }

}
