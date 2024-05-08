using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 0.01f;
    public GameObject bulletPrefab;
    public float bulletSpeed = 500.0f;
    public int bulletCount = 2;
    float pressSpaceTime = 0.0f;
    Vector3 bulletScale; 

    /*
    enum Direction = {up, down, right, left};
    Direction direction;
    */

    void Start()
    {
        /*
        Vector2 newPos = transform.position;
        newPos.x += 3;
        transform.position = newPos;
        */
    }

    void Update()
    {
        if(Input.GetKey(KeyCode.W))     
        {
            this.transform.Translate(0, speed, 0);
            //direction = Direction.up;
        }

        if(Input.GetKey(KeyCode.A))     
        {
            this.transform.Translate(-speed, 0, 0);
            //direction = Direction.left;
        }

        if(Input.GetKey(KeyCode.S))
        {
            this.transform.Translate(0, -speed, 0);
            //direction = Direction.down;
        }

        if(Input.GetKey(KeyCode.D))
        {
            this.transform.Translate(speed, 0, 0);
            //direction = Direction.right;
        }

        if (Input.GetKey(KeyCode.Space))
            pressSpaceTime += Time.deltaTime;
        else
            pressSpaceTime = 0.0f;

        if (Input.GetKeyUp(KeyCode.Space))
        {
            GameObject Bullet = Instantiate(bulletPrefab);
            Bullet.transform.position = this.transform.position;
            if(pressSpaceTime != 0.0f)
            {
                bulletScale *= pressSpaceTime * 0.1f;
                Bullet.transform.localScale = bulletScale;
            }

            Bullet.GetComponent<Rigidbody2D>().AddForce(Vector2.up * bulletSpeed);
        }














        //if (Input.GetKeyUp(KeyCode.Space))
        //{
        //    for (int i = -1; i < BulletCount; i++)
        //    {

        //        GameObject Bullet = Instantiate(bulletPrefab);
        //        Vector3 BulletPos = this.transform.position;

        //        BulletPos.y = BulletPos.y + (i * 0.3f);
        //        Bullet.transform.position = BulletPos;

        //        Bullet.GetComponent<Rigidbody2D>().AddForce(Vector2.up * bulletSpeed);
        //    }
        //}
    }

    /*
                while(true)
                {
                    switch(direction)
                    {   
                        case up : bulletPrefab.transform.Translate(0, speed, 0); break;
                        case left : bulletPrefab.transform.Translate(-speed, 0, 0); break;
                        case down : bulletPrefab.transform.Translate(0, -speed, 0); break;
                        case right : bulletPrefab.transform.Translate(speed, 0, 0); break;
                    }
                    if(Input.GetKey(KeyCode.K)) break;
                }
            }
        }
    */
}
