using System.Collections;
using UnityEngine;

public class _16_IEnumerator_ForDongusu_HerSaniyeCalisan : MonoBehaviour
{
    public int adet;

    void Start()
    {
        StartCoroutine(ForAdetArttirmali());
    }

    IEnumerator ForAdetArttirmali()
    {
        for (int i = 0; i < 100; i++) 
        {
            yield return new WaitForSeconds(1.0f);
            print(adet++);  //1 sn bekler yazd�r�r.
        }
    }
    IEnumerator WhileAdetArttirmali()
    {
        int sayi = 0;
        while (true)
        {
            print("Her saniye �al���yor --> " + "Sayi de�eri = " + sayi++);
            yield return new WaitForSeconds(1.0f);
        }
    }
}
