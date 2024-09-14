using UnityEngine;

public class Ray1 : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Ray ray = new Ray(transform.position, transform.forward);
            if (Physics.Raycast(ray, 10))
            {
                print("hit the object");
            }
        }
    }    
}
