using UnityEngine;

public class _4_SerializeField : MonoBehaviour
{
    //public olmayan de�i�kenleri g�sterir
    [SerializeField]
    private int _index = 0;
    
    void Start()
    {
        _index += 10;
        print(_index);
    }
}
