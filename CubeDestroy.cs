using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeDestroy : MonoBehaviour
{
    public GameObject floor;
    public GameObject kubi;
    bool hasCollided = false;

    void Start()
    {
        
    }


    void Update()
    {
      /*  if (hasCollided == true)
        {
            Destroy(kubi);
        }*/
        
    }
    public void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag=="GroundCube")
        {
            Destroy(this.gameObject);
        }
       // hasCollided = true;
    }
}
