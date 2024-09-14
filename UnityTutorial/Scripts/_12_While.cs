using UnityEngine;

public class _12_While : MonoBehaviour
{
    void Print_WhileDongusu()
    {
        int adet = 6;
        while (adet>=0) {
            print(adet);
            adet--;
        }
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0)) {
            Print_WhileDongusu();
        }
    }
}
