using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    GameObject Coin;
    GameObject Lion;
    GameObject Elephant;
    GameObject Stone;
    float timer = 0f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        timer = timer += Time.deltaTime;

        if (Random.Range(0, 100) < 5)
        {
           // Coin = ObjectPooling.Instance.Get("Coin");
            
                if (timer > 2.0f)
                {
                Coin = ObjectPooling.Instance.Get("Coin");
                if (Coin != null)
                    {

                        // coin.transform.position = this.transform.position + new Vector3(-2.5f, Random.Range(-3.5f,-0.05f), 0);
                        Coin.transform.position = this.transform.position + new Vector3(Random.Range(-2.5f, -10.02f), -3.29f, 0);
                    Coin.SetActive(true);
                    timer = 0f;
                }

                timer = 0f;
            }

            // StartCoroutine(WaitAfter10Seconds());
            //coin.SetActive(false);




            /*  Lion = PoolMethod.Instance.Get("Cactus");
               if (Cactus != null)
               {
                   if (timer > 10.0f)
                   {
                       Cactus.transform.position = this.transform.position + new Vector3(Random.Range(0.0f, -1.0f), -3.9f, 0);
                       Cactus.SetActive(true);
                   }
               }
               Crystal = PoolMethod.Instance.Get("Crystal");
               if (Crystal != null)
               {
                   if (timer > 5.0f)
                   {
                       Crystal.transform.position = this.transform.position + new Vector3(Random.Range(-0.89f, -2.17f), Random.Range(-1.5f, 0.27f), 0);
                       Crystal.SetActive(true);
                   }
               }


           }*/
        }
    }


    }