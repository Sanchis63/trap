using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RUN : MonoBehaviour
{
    public GameObject game;
    public bool jump = false;
    public int JunpForce = 200;
    public bool ToJump = false;
    public bool trap = false;
    public bool tp = false;
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Tramplin")
        {
            ToJump = true;
        }
        if (other.gameObject.name == "Trap")
        {
            trap = true;
        }
        if (other.gameObject.name == "Teleport")
        {
            tp = true;
        }
    }
    public void OnTriggerExit(Collider other)
    {
        if (other.gameObject.name == "Tramplin")
        {
            ToJump = false;
        }
    }
    public void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(new Vector3(0, 0, 1) * 2 * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(new Vector3(0, -0.5f, 0) * 200 * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(new Vector3(0, 0.5f, 0) * 200 * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.Space))
        {
            if (!jump)
            {
                gameObject.GetComponent<Rigidbody>().AddRelativeForce(0, JunpForce, 0, ForceMode.Force);
                StartCoroutine(hamster());
            }
        }
    }
    IEnumerator hamster()
    {
        jump = true;
        
        yield return new WaitForSeconds(2);
        jump = false;
    }
}
