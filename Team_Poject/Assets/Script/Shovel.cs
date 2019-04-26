using UnityEngine;

public class Shovel : MonoBehaviour
{

    public int health = 5;
    public Inventory inv;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "shovel")
        {
            health--; //subracts health by 1

        }

        if (health < 1)
        {
            //inv.key = inv.key + 1; adds key to the inventory
            Destroy(gameObject);

        }
    }
}
