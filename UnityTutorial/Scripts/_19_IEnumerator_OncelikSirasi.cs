using System.Collections;
using UnityEngine;

public class _18_IEnumerator_OncelikSirasi : MonoBehaviour
{
    IEnumerator IEnumeratorRakamlariTopla()
    {
        int sonuc = 0;
        for (int i = 0; i < 50; i++) { sonuc += i; }
        yield return new WaitForSeconds(6.0f);
        print("Toplam = " + sonuc);
    }
    IEnumerator IEnumeratorRakamlariCarp()
    {
        int sonuc = 1;
        for (int i = 1; i < 6; i++) { sonuc *= i; }
        yield return new WaitForSeconds(2.0f);
        print("Carpim sonucu = " + sonuc);
    }
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            StartCoroutine(IEnumeratorRakamlariTopla());//6sn
            StartCoroutine(IEnumeratorRakamlariCarp());//2sn
            //Önce çarpma sonucu gelir 2 saniye biter çünkü
        }
    }
}
