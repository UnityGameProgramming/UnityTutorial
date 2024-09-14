using UnityEngine;

public class _13_ForBreak : MonoBehaviour
{    
    void Start()
    {
        int sayi = 1;
        for (; ; )
        {
            print(sayi++);
            if (sayi > 40) break;
        }
        print("Döngü sonlandý");
    }
}
