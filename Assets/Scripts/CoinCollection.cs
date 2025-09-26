using UnityEngine;

public class CoinCollection : MonoBehaviour
{
    
    
    public int numCoins = 0;
    public int health = 3;
    

    

    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.tag == "Coin")
        {
            numCoins++;
            Debug.Log(numCoins);
            Destroy(other.gameObject);
        }

        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.tag == "Danger")
        {
            health--;
            Debug.Log(health);
            if (health == 0)
            {
                Debug.Log("You died. :(");
            }
        }
    }
}
