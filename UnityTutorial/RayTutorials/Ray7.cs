using UnityEngine;

public class Ray7 : MonoBehaviour
{
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            Vector3 ray = transform.TransformDirection(Vector3.forward);

            if (Physics.Raycast(transform.position, ray, 10))
                print("Hit the object!");
        }
        
    }
}
