using UnityEngine;

public class _11_For : MonoBehaviour
{
    public string ad = "matematik";
    
    [SerializeField]
    int ustDeger = 100;
    void Start()
    {
        for (int i = 0; i < ustDeger; i++)
        {
            print(ad+" "+i);
        }
    }
}
