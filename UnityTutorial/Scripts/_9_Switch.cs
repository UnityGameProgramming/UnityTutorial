using UnityEngine;

public class _9_Switch : MonoBehaviour
{
    [SerializeField]
    int secilenSeviye;
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) 
        {
            secilenSeviye = Random.Range(0,3);
            switch (secilenSeviye)
            {
                case 0:
                    print("kolay");
                    break;
                case 1:
                    print("orta");
                    break;
                case 2:
                    print("zor");
                    break;
                default:
                    print("Seviye secemediniz");
                    break;

            }
        }
    }
}
