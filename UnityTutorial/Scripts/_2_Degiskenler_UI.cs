using UnityEngine;
using UnityEngine.UI;

public class _2_Degiskenler_UI : MonoBehaviour
{
    private string _name;
    public float numberfloat = 1.2f;

    public Text text;
    void Start()
    {
        text = GameObject.FindAnyObjectByType<Text>();
        if (text != null)
        {
            text.text = _name + " " + numberfloat;
            //_name boþ string atýyor null hatasý vermiyor
        }
        else Debug.LogWarning("UI text atanmamýþ");
    }
}
