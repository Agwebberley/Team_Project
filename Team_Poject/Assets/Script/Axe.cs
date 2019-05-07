using UnityEngine;

public class Axe : MonoBehaviour {

    PlayerInventory inv;

    void Start()
    {
        //set active false
    }

    void FixedUpdate()
    {
        if (inv.axe > 0)
        {
            //set active true
        }
    }

}
