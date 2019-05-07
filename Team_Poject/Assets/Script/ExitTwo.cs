using UnityEngine;
using UnityEngine.SceneManagement;

public class ExitTwo : MonoBehaviour {

    public PlayerInventory inv;

    void FixedUpdate()
    {

        if (inv.key > 0)
        {
            SceneManager.LoadScene("Island3");
        }

    }

}
