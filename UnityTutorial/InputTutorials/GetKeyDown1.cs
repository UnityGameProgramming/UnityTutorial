using UnityEngine;

public class GetKeyDown1 : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            print("A tu�una basmaktas�n�z");
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            print("Space tu�una bast�n�z");
        }
        if (Input.GetKeyUp(KeyCode.Space))
        {
            print("Space tu�unu b�rakt�n�z");
        }
        
        
    }
}
