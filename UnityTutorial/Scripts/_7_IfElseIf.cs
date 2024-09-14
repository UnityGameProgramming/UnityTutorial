using UnityEngine;

public class _7_IfElseIf : MonoBehaviour
{
    public int kolaySeviye = 0;
    public int ortaSeviye = 1;
    public int zorSeviye = 2;

    public int gecerliSeviye;

    void Start()
    {
        gecerliSeviye = 1;
    }

    void Update()
    {
        if (gecerliSeviye == 0) { print("kolay seviye"); }
        else if (gecerliSeviye == 1) { print("orta seviye"); }
        else { print("zor seviye"); }
    }
}
