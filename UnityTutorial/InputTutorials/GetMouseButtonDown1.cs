using UnityEngine;

public class GetMouseButtonDown1 : MonoBehaviour
{
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("Farenin sol tuþuna bastýnýz");
        }
        if (Input.GetMouseButtonDown(1))
        {
            Debug.Log("Farenin sað tuþuna bastýnýz");
        }
    }
}
