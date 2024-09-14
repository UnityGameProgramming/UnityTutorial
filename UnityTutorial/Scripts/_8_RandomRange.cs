using UnityEngine;

public class _8_RandomRange : MonoBehaviour
{
    public float quiz1,quiz2,quiz3,quiz4,ortalama = 0;
  
    void Start()
    {
        quiz1 = Random.Range(0, 101);
        quiz2 = Random.Range(0, 101);
        quiz3 = Random.Range(0, 101);
        quiz4 = Random.Range(0, 101);
        ortalama = (quiz1 + quiz2 + quiz3 + quiz4) / 4;

        if (ortalama >= 90)
        {
            print("A");
        }
        else if (ortalama >= 80)
        {
            print("B");
        }
        else if (ortalama >= 70)
        {
            print("C");
        }
        else
        {
            print("Öðrenci sýnýfta kalmýþtýr :(");
        }
    }

}
