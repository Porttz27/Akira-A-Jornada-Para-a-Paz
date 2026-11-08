using UnityEngine;

public class SeguirFundoScript : MonoBehaviour
{
    AkiraScript Akira;
    void Start()
    {
        Akira = FindFirstObjectByType<AkiraScript>();
    }
    void Update()
    {
        transform.position = Akira.transform.position;
    }
}
