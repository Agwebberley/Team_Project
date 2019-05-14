﻿using UnityEngine;
using UnityEngine.SceneManagement;

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

        if (collision.gameObject.tag == "tree")
        {
            inv.wood = inv.wood + 2;
            Debug.Log("nyeh");
        }

        if (collision.gameObject.name == "bridge") //third island win condition
        {
            if(inv.rope > 1 && inv.wood > 3)
            {
                //load next scene
            }
        }

  if (collision.gameObject.tag == "ladder") //first island win condition
        {
            if(inv.wood > 5)
            {
                //load next scene
               SceneManager.LoadScene("Island 2");
            }
        }


    }
}