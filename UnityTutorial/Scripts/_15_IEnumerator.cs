using System.Collections;
using UnityEngine;

public class _15_IEnumerator : MonoBehaviour
{
    public int adet;
    public int rakamlarToplam;
    void Start()
    {
        StartCoroutine(AdetArttir());
    }

    IEnumerator AdetArttir()
    {
        print("...0 dan 9 kadar rakamlar toplamý hesaplanýyor...");
        rakamlarToplam = 0;
        for (int i = 0; i < 10; i++)
        {
            rakamlarToplam += i;
        }

        yield return new WaitForSeconds(3f);
        print("Toplam = " + rakamlarToplam);
    }
}
