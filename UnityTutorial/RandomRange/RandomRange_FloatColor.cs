using UnityEngine;

public class RandomRange_FloatColor : MonoBehaviour
{
    void Update()
    {
        if (Input.GetMouseButtonUp(0))
        {
            float red = Random.Range(0.0f, 1.0f);
            float green = Random.Range(0.0f, 1.0f);
            float blue = Random.Range(0.0f, 1.0f);

            transform.GetComponent<MeshRenderer>().material.color = new Color(red, green, blue);
        }
    }
}
