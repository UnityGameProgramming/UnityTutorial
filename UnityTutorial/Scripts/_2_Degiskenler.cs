using UnityEngine;

public class _2_Degiskenler : MonoBehaviour
{
    private string _name;
    private int _number = 20;
    public float numberfloat = 1.2f;
    void Start()
    {
        Debug.Log(_name); //null
        _name = "Degiskenler";
        Debug.Log(_name); //Degiskenler

        Debug.Log(_number); //20
        Debug.Log(numberfloat); //1.2
    }
}
