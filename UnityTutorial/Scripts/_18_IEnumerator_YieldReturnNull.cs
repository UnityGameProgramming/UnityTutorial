using System.Collections;
using UnityEngine;

public class _17_IEnumerator_YieldReturnNull : MonoBehaviour
{
    [SerializeField]
    Coroutine coroutine;
    IEnumerator IEnumerator_OyunBasladi()
    {
        print("Oyun ba�lad�");
        yield return null;
    }
    void Start()
    {
        if (coroutine == null) {
            coroutine = StartCoroutine(IEnumerator_OyunBasladi());
        }
    }
}
