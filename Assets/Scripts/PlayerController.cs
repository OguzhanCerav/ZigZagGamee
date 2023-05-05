using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Vector3 yon = Vector3.left;
    public GroundSpawner groundSpawner;

    [SerializeField]
    float speed;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (yon.x==0)
            {
                yon = Vector3.left;
            }
            else
            {
                yon = Vector3.back;
            }
        }
    }
    private void FixedUpdate()
    {
        Vector3 hareket = yon * speed * Time.deltaTime;
        transform.position += hareket;
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.CompareTag("Zemin"))
        {
            YokEt(collision.gameObject);
            groundSpawner.ZeminOlustur();
        }
    }

    void YokEt(GameObject zemin)
    {
        Destroy(zemin);
    }





















}//class
