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
            print(adet++);  //1 sn bekler yazdýrýr.
        }
    }
    IEnumerator WhileAdetArttirmali()
    {
        int sayi = 0;
        while (true)
        {
            print("Her saniye çalýþýyor --> " + "Sayi deðeri = " + sayi++);
            yield return new WaitForSeconds(1.0f);
        }
    }
}
