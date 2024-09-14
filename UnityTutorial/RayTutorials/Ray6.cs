using UnityEngine;

public class Ray6 : MonoBehaviour
{
    void Update()
    {
        //Fareyle týklama
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit))
            {
                if (hit.collider != null)
                {
                    hit.collider.enabled = false;
                }
                print(hit.collider.name);
            }
        }
    }
}
