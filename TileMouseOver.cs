using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileMouseOver : MonoBehaviour
{
    public Color highlightColor;
    Color normalColor;
    public Camera cam;


    void Start()
    {
        normalColor = GetComponent<Renderer>().material.color;
    }
    void Update()
    {
        Ray ray = GetComponent<Camera>().ScreenPointToRay( Input.mousePosition);

        
    }
    
    
    /*  void OnMouseOver()
    {
        GetComponent<Renderer>().material.color = Color.blue;
    }
    void OnMouseExit()
    {
        GetComponent<Renderer>().material.color = Color.grey;
    }*/
}
