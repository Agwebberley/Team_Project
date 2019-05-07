using UnityEngine;
using UnityEngine.SceneManagement;

public class ExitOne : MonoBehaviour {

    public PlayerInventory inv;
    public int reqWood;
    public int reqNail;

	void FixedUpdate () {
	    
        if(inv.wood > reqWood || inv.nail > reqNail)
        {
            SceneManager.LoadScene("Island2");
        }

	}

}
