using UnityEngine;

public class FindGameObjectsWithTag : MonoBehaviour
{
    public GameObject[] kups; 
    void Start()
    {
        kups = GameObject.FindGameObjectsWithTag("Kup");
    }
}
