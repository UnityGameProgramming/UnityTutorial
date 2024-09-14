using UnityEngine;

public class Ray2 : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Ray ray = new Ray();
            ray.origin = Vector3.zero;
            ray.direction = Vector3.forward;

            if (Physics.Raycast(ray, 10))
            {
                print("hit the object");
            }
        }
    }
}
