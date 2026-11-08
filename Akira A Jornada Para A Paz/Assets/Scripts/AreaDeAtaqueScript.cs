using UnityEngine;

public class AreaDeAtaqueScript : MonoBehaviour
{
   public void Destruir()
    {
        Destroy(gameObject);
        Destroy(transform.parent.gameObject);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        InimigoBaseScript inimigo = collision.GetComponentInParent<InimigoBaseScript>();

        if (collision.CompareTag("Inimigo") && collision == inimigo.ColliderdeAtaque)
        {
            if (inimigo != null)
            {
                inimigo.ReceberDano(1);
            }
        }
    }
}
