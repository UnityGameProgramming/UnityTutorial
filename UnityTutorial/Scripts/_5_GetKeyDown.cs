using UnityEngine;

public class _5_GetKeyDown : MonoBehaviour
{
    [SerializeField]
    private int _puan = 0;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            _puan+=10;
            Debug.Log("Indeks "+ _puan);
        }
    }
}
