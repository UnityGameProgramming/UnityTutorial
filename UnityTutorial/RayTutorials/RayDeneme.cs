using UnityEngine;

public class RayDeneme : MonoBehaviour
{
    Ray ray = new Ray();
    void Start()
    {
        ray.origin = transform.position;
        ray.direction = transform.forward;
    }
    
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit, 10))
            {
                print(hit.collider.name);
                hit.collider.GetComponent<MeshRenderer>().material.color = Color.blue;
            }
        } 
        if (Input.GetMouseButtonDown(1))
        {
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit, 10))
            {
                print(hit.collider.name);
                hit.collider.GetComponent<MeshRenderer>().material.color = Color.red;
            }
        }
       
        
    }
}
