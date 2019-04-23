using UnityEngine;

public class Tree : MonoBehaviour {

    public int health = 100;
    public Inventory inv;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "axe")
        {
            health = health - 50;
            Debug.Log("damaged");
        }

        if (health < 1)
        {
            inv.wood = inv.wood + 2;
            Destroy(gameObject);
            Debug.Log("Tree Destroyed");
        }
    }
}
