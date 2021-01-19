using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerTriggerControl : MonoBehaviour
{
    Vector3 originalPosition;
    public GameObject CheckpointText;

    private void Start()
    {
        CheckpointText.SetActive(false);
        originalPosition = gameObject.transform.position;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "CheckPoint")
        {
            originalPosition = gameObject.transform.position;
            CheckpointText.SetActive(true);
        }

        if (other.tag == "KillBox")
        {
            gameObject.transform.position = originalPosition;
        }

    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "CheckPoint") {

            CheckpointText.SetActive(false);
        }
    }
}
