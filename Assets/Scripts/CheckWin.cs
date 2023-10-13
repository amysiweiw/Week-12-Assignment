using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckWin : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject winMessage;
    void Start()
    {
        winMessage.SetActive(false);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("MainCamera"))
        {
            if(!winMessage.activeInHierarchy)
            {
                winMessage.SetActive(true);
            }
            
        }
    }



}
