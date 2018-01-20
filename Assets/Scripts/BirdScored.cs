using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScored : MonoBehaviour
{
    public int HowMuch = 1;
    public bool DestroyAfterCollect = false;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<Bird>() != null)
        {
            GameController.instance.BirdScored(HowMuch);

            if (DestroyAfterCollect)
            {
                this.gameObject.SetActive(false);
            }
        }

       
    }
}
