using UnityEngine;

public class Pickup : MonoBehaviour
{

    public PlayerInventory inv;

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "tent")
        {
            inv.axe = 1;
            inv.rope = 2;
        }

        if (collision.gameObject.name == "bridge") //third island win condition
        {
            if(inv.rope > 1 && inv.wood > 3)
            {
                //load next scene
            }
        }

    }
}