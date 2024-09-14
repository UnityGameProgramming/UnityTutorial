using UnityEngine;

public class GetChilds : MonoBehaviour
{
    [SerializeField]
    int childCount;

    [SerializeField]
    GameObject[] childs;
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            childCount = transform.childCount;
            childs = new GameObject[childCount];
            for (int i = 0; i < childCount; i++)
            {
                childs[i] = transform.GetChild(i).gameObject;
            }

            print("Childs count: "+ childCount);
            print("Childs "+ childs);
            for (int i = 0; i < childCount; i++) {
                print(childs[i].name);
            }
        }
    }
   
}
