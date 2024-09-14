using UnityEngine;

public class _3_MatematikselOperatorler : MonoBehaviour
{
    public int intsayi1 = 12;
    public int intsayi2 = 5;
    public int intbolme;
    public int intKalan;
    public int intArttir1 = 14;


    public float floatsayi1 = 5;
    public float floatsayi2 = 7;
    public float floatbolme;
    public string floatbolmeString;
    void Start()
    {
        
        intbolme = intsayi1 / intsayi2;
        intKalan = intsayi1 % intsayi2;   //Kalan 5 deðerini verir

        intArttir1++;//15

        floatbolme = floatsayi1 / floatsayi2;          //0.7142857
        floatbolmeString = floatbolme.ToString("0.00");   //0.71
    }
}
