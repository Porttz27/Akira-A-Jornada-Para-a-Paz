using UnityEngine;

public class FundoScript : MonoBehaviour
{
    public float fator = 0.8f;    // velocidade do fundo em relação ao Akira
    public float limite = 4.48f;

    AkiraScript akira;
    float ultimoX;

    void Start()
    {
        akira = FindFirstObjectByType<AkiraScript>();
        ultimoX = akira.transform.position.x;
    }


    void LateUpdate()
    {
        float deslocamento = akira.transform.position.x - ultimoX;
        ultimoX = akira.transform.position.x;

        Vector3 p = transform.localPosition;
        p.x -= deslocamento * fator;

        if (p.x <= -limite || p.x >= limite)
            p.x = 0f;

        transform.localPosition = p;
    }
}