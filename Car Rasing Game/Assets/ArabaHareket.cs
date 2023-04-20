using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ArabaHareket : MonoBehaviour
{
    bool oyunBitti = false;
    public int puan = 0;
    void Start()
    {
        puan = 0;
    }

    void Update()
    {

        if (oyunBitti == false)
        GetComponent<Rigidbody>().AddForce(Vector3.left * 10, ForceMode.Force);

        else if(oyunBitti == true)
        GetComponent<Rigidbody>().velocity = Vector3.zero;

        if (Input.GetKey("d"))
        {
            GetComponent<Rigidbody>().AddForce(0, 0, 100, ForceMode.Force);
        }

        if (Input.GetKey("a"))
        {
            GetComponent<Rigidbody>().AddForce(0, 0, -100, ForceMode.Force);
        }

        if (GetComponent<Rigidbody>().position.x <= -90)
        {
            oyunBitti = true;
            GetComponent<Rigidbody>().velocity = Vector3.zero;
            Invoke("restart", 3f);
        }
    }
    
    private void OnCollisionEnter(Collision collision) 
    {
        if (collision.collider.tag == "Engel")
        {
            Invoke("restart", 3f);
            oyunBitti = true;
        }

        if (collision.collider.tag == "Coin")
        {
            Destroy(collision.gameObject);
            puan++;
        }

    }

    private void restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        oyunBitti = false;
    }

 }










