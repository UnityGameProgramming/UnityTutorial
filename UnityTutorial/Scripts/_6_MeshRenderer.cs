using UnityEngine;

public class _6_MeshRenderer : MonoBehaviour
{
    public GameObject kure;
    public int skor = 0;
    void Start()
    {
        kure = GameObject.Find("Kure");
        kure.GetComponent<MeshRenderer>().material.color = Color.red;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && skor <= 50)
        {
            skor+=25;
        }
        if (skor>50)
        {
            kure.GetComponent<MeshRenderer>().material.color = Color.blue;
        }
    }
}
