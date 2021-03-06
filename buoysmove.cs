using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buoysmove : MonoBehaviour
{
    float time = 0.0f;
    float interval = 2.0f;
    GameObject obstacle;
    float vx;
    float vy;
    float vy2;
    float vy3;
    public GameObject prefab = null;
    // Start is called before the first frame update
    void Start()
    {
        obstacle = GameObject.Find("ball (1)");
        vx = gameObject.transform.position.x;
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;

        if (time > interval)
        {
            float k = Random.Range(1, 4);
            //print ("k");


            if (k == 3)
            {
                vy = obstacle.transform.position.y + 3;
                vy2 = obstacle.transform.position.y;
                vy3 = obstacle.transform.position.y + 1;
                shoot();
                time = 0f;
            }

            if (k == 2)
            {
                vy = obstacle.transform.position.y + 6;
                vy2 = obstacle.transform.position.y + 3;
                vy3 = obstacle.transform.position.y + 9;
                shoot();
                time = 0f;
            }

            if (k == 1)
            {
                vy = obstacle.transform.position.y + 4;
                vy2 = obstacle.transform.position.y + 8;
                vy3 = obstacle.transform.position.y + 5;
                shoot();
                time = 0f;
            }
            time = 0f;
        }
    }
    void shoot()
    {
        GameObject obj = (GameObject)Instantiate(prefab, new Vector2(vx, vy), Quaternion.identity);
        GameObject obj2 = (GameObject)Instantiate(prefab, new Vector2(vx, vy2), Quaternion.identity);
        GameObject obj3 = (GameObject)Instantiate(prefab, new Vector2(vx, vy3), Quaternion.identity);
        obj.GetComponent<Rigidbody2D>().velocity = new Vector2(-17f, 0f);
        obj2.GetComponent<Rigidbody2D>().velocity = new Vector2(-20f, 0f);
        obj3.GetComponent<Rigidbody2D>().velocity = new Vector2(-8f, 0f);
    }
}
