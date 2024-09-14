using UnityEngine;

public class FindExample : MonoBehaviour
{
    public GameObject kure;
    void Start()
    {
        kure = GameObject.Find("Kure");
        kure.GetComponent<MeshRenderer>().material.color = Color.cyan;
    }
}
