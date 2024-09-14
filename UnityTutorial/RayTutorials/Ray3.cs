using UnityEngine;

public class Ray3 : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Ray ray = new Ray();
            ray.origin = Vector3.zero;
            ray.direction = Vector3.forward;

            RaycastHit hit;
            if (Physics.Raycast(ray,out hit ,10))
            {
                print("hit the "+hit.collider.name);
            }
        }
    }
}
