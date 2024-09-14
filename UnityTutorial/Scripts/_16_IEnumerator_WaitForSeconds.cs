using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _16_IEnumerator_WaitForSeconds : MonoBehaviour
{

    public int sayi = 10;
    IEnumerator IEnumerator_Print()
    {
        print("sayi : " + sayi);
        yield return new WaitForSeconds(2.0f);

        if (sayi % 2 == 0) print("sayi deðeri çift sayidir");
        else print("sayi deðeri tek sayidir.");
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            StartCoroutine(IEnumerator_Print());
        }
    }
}
