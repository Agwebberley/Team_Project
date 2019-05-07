using UnityEngine;
using UnityEngine.SceneManagement;

public class ExitThree : MonoBehaviour
{

    public PlayerInventory inv;
    public int reqRope, reqWood;

    void FixedUpdate()
    {

        if (inv.rope > reqRope || inv.wood > reqWood)
        {
            SceneManager.LoadScene("Island4");
        }

    }

}