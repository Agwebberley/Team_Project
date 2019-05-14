using UnityEngine;
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
            
        }

        if (collision.gameObject.name == "bridge") //third island win condition
        {
            if(inv.rope > 1 && inv.wood > 3)
            {
                //load next scene
                SceneManager.LoadScene("AVIsland");
            }
        }

  if (collision.gameObject.tag == "ladder 2") //second island win condition
        {
            if(inv.wood > 3)
            {
                //load next scene
                SceneManager.LoadScene("Island 2.5");
            }
        }


  if (collision.gameObject.name == "Portal") //second island win condition
        {
         SceneManager.LoadScene("Island3");
        }

  if (collision.gameObject.tag == "ladder") //first island win condition
        {
            if(inv.wood > 5)
            {
                //load next scene
               SceneManager.LoadScene("Island 2");
            }
        }

   if (collision.gameObject.name == "Fire") //last island win condition
        {
            if(inv.wood > 3)
            {
          
             Application.Quit (); 
            }
        }

    }
}