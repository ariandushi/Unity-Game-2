using UnityEngine;

public class ColliderEnabled : MonoBehaviour
{
    Collider m_Collider;
    bool hasCollided = false;
    void Start()
    {
        //Fetch the GameObject's Collider (make sure it has a Collider component)
        m_Collider = GetComponent<Collider>();
    }

    void Update()
    {
        if (hasCollided==true)
        {
            //Toggle the Collider on and off when pressing the space bar
            m_Collider.enabled = true;

            //Output to console whether the Collider is on or not
            Debug.Log("Collider.enabled = " + m_Collider.enabled);
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        hasCollided = true;
    }
}