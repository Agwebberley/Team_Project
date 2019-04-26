using UnityEngine;

public class Tree1 : MonoBehaviour {

    public int health = 5;
    public Inventory inv;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "axe")
        {
            health--; //subracts health by 1

        }

        if (health < 1)
        {
            inv.wood = inv.wood + 2; //adds wood to the inventory
            Destroy(gameObject);

        }
    }
}
