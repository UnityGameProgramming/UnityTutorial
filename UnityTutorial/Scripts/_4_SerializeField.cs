using UnityEngine;

public class _4_SerializeField : MonoBehaviour
{
    //public olmayan değişkenleri gösterir
    [SerializeField]
    private int _index = 0;
    
    void Start()
    {
        _index += 10;
        print(_index);
    }
}
