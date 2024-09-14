using UnityEngine;

public class _1_DebugLog: MonoBehaviour
{
    private void Awake()
    {   //Awake her türlü çalýþýr
        Debug.Log("Awake çalýþtý");
    }

    void Start()
    {
        Debug.Log("Start çalýþtý");
    }

    void Update()
    {
        
    }
    void LateUpdate()
    {
        
    }
}
