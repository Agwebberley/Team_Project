using UnityEngine;

public class tree : MonoBehaviour {

    public int health = 100;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "axe")
        {
            health = health - 10;
            Debug.Log("It works");
        }

        if (health < 1)
        {
            Destroy(gameObject);
        }
    }
}
