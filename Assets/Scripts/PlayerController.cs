using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PlayerController : MonoBehaviour
{
    Vector3 yon = Vector3.left;
    public GroundSpawner groundSpawner;

    public static bool isDead=false;

    public float hizlanmaZorlugu;
    float score = 0f;
    float artisMiktari = 1f;

    [SerializeField]
    Text scoreText;

    [SerializeField]
    float speed;

    private void Update()
    {
        if (isDead)
        {
            return;
        }
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

        if (transform.position.y<0.1f)
        {
            isDead = true;
            Destroy(this.gameObject,2f);

        }
    }
    private void FixedUpdate()
    {
        Vector3 hareket = yon * speed * Time.deltaTime;
        speed += Time.deltaTime*hizlanmaZorlugu;
        transform.position += hareket;
        score += artisMiktari * speed * Time.deltaTime;
        
        scoreText.text ="Score : " + ((int)score).ToString();
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.CompareTag("Zemin"))
        {
            StartCoroutine(YokEt(collision.gameObject));
            groundSpawner.ZeminOlustur();
        }
    }

    IEnumerator YokEt(GameObject zemin)
    {
        yield return new WaitForSeconds(0.2f);
        zemin.AddComponent<Rigidbody>();
        yield return new WaitForSeconds(1f);
        Destroy(zemin);
    }





















}//class
