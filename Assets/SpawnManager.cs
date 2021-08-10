using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    GameObject Coin;
    GameObject Lion;
    GameObject Elephant;
    //[SerializeField] Transform SpawnPos;
    float timer = 0f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        if (Random.Range(0, 100) < 5)
        {
            // Coin = ObjectPooling.Instance.Get("Coin");

            if (timer > 2.0f && timer < 5f)
            {
                GameObject Coin = ObjectPooling.Instance.Get("Coin");
                Debug.Log(Coin);
                if (Coin != null)
                {
                    //Debug.Log("Entered");

                    // coin.transform.position = this.transform.position + new Vector3(-2.5f, Random.Range(-3.5f,-0.05f), 0);
                    Coin.transform.position = this.transform.position;
                    Coin.SetActive(true);
                    //timer = 0f;
                }
                //timer = 0f;


            }
            if (timer > 5f)
            {
                GameObject Lion = ObjectPooling.Instance.Get("Lion");
                Debug.Log(Coin);
                if (Lion != null)
                {
                    //Debug.Log("Entered");

                    // coin.transform.position = this.transform.position + new Vector3(-2.5f, Random.Range(-3.5f,-0.05f), 0);
                    Lion.transform.position = this.transform.position + new Vector3(0f, 0.5f, 0f);
                    Lion.SetActive(true);
                    //timer = 0f;
                }
                timer = 0f;
            }
        }
    }
}