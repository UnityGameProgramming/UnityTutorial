using UnityEngine;

public class GetMouseButtonDown1 : MonoBehaviour
{
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("Farenin sol tu�una bast�n�z");
        }
        if (Input.GetMouseButtonDown(1))
        {
            Debug.Log("Farenin sa� tu�una bast�n�z");
        }
    }
}
