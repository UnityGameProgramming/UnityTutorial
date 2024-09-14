using UnityEngine;

public class RayDeneme2 : MonoBehaviour
{
    public GameObject go;
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = new Ray(transform.position, Vector3.forward);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit,10)) 
            {
                go = hit.collider.gameObject;
                go.GetComponent<MeshRenderer>().material.color = Color.blue;
                Debug.LogWarning(go);
            }
        }
        if (Input.GetMouseButtonDown(1)) {
            if (go != null)
            {
                go.GetComponent<MeshRenderer>().material.color = Color.white;
                go = null;
                Debug.LogWarning("Gameobject is null");
            }
        }
    }
}
