using System.Collections;
using UnityEngine;

public class FantasmaScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator Ataque()
    {
       int ataque = Random.Range(0, 100);
       int timer = Random.Range(7, 13);
        if (ataque < 50)
        {
            GetComponent<Animator>().SetTrigger("Ataque1");
        }
        else
        {
            GetComponent<Animator>().SetTrigger("Ataque2");
        }
        yield return new WaitForSeconds(timer);
        StartCoroutine(Ataque());
    }
}
