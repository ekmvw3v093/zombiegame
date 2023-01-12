using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GAmeOver : MonoBehaviour
{
    public GameObject dead;
    public GameObject win;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "zombie")
        {
            dead.SetActive(true);
            Invoke("NoPicture", 2);
        }
        else if (other.gameObject.tag == "win")
        {
            win.SetActive(true);
        }
    }

    private void NoPicture()
    {
        dead.SetActive(false);
    }
}
