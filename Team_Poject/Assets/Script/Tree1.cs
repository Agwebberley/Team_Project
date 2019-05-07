using UnityEngine;

public class Tree1 : MonoBehaviour {

    public int health = 5;
    public PlayerInventory inv;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "axe")
        {
            Debug.Log("stuff");
            health--; //subracts health by 1

        }

        if (health < 1)
        {
            Debug.Log("stuff2");
            inv.wood = inv.wood + 2; //adds wood to the inventory
            Destroy(gameObject);

        }
    }
}
