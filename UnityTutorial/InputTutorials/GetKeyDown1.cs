using UnityEngine;

public class GetKeyDown1 : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            print("A tuþuna basmaktasýnýz");
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            print("Space tuþuna bastýnýz");
        }
        if (Input.GetKeyUp(KeyCode.Space))
        {
            print("Space tuþunu býraktýnýz");
        }
        
        
    }
}
