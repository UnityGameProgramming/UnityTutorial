using UnityEngine;

public class Ray4 : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Ray ray = new Ray();
            ray.origin = new Vector3(0, 0, 0);
            ray.direction = Vector3.forward;

            RaycastHit hit;
            if (Physics.Raycast(ray, out hit, 10))
            {
                print("You hit the " + hit.collider.name);
            }
        }
    }
}
