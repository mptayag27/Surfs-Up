using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shellspawn : MonoBehaviour
{
    float time = 0.0f;
    float interval = 2.0f;
    GameObject rat;
    float vx;
    float vy;
    float vy2;
    float vy3;
    public GameObject prefab = null;
    // Start is called before the first frame update
    void Start()
    {
        rat = GameObject.Find("ball (1)");
        vx = gameObject.transform.position.x;
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;

        if (time > interval)
        {
            float k = Random.Range(-4, 4);
            //print ("k");
                vy = rat.transform.position.y + k;
                shoot();
                time = 0f;
        }
    }
    void shoot()
    {
        GameObject obj = (GameObject)Instantiate(prefab, new Vector2(vx, vy), Quaternion.identity);
        obj.GetComponent<Rigidbody2D>().velocity = new Vector2(-17f, 0f);
    }
}
