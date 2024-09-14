using UnityEngine;

public class _10_SwitchColor : MonoBehaviour
{
    public GameObject kure;
    [SerializeField]
    private int renkKodu = 1;
    void Start()
    {
        kure = GameObject.Find("Kure");
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            renkKodu = 1;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            renkKodu = 2;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            renkKodu = 3;
        }
        else if(Input.GetKeyDown(KeyCode.Alpha4))
        {
            renkKodu = 4;
        }
        Material m = kure.GetComponent<MeshRenderer>().material;
        switch(renkKodu)
        {
            case 1:
                m.color = Color.red; 
                break;
            case 2:
                m.color = Color.blue; 
                break;
            case 3:
                m.color = Color.black; 
                break;
            default:
                m.color = Color.green; 
                break;
        }

    }
}
