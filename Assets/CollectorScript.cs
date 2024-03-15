using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollectorScript : MonoBehaviour
{
    [SerializeField] private Text LuuText;
    private int Luu = 0;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Luu"))
        {
            Destroy(collision.gameObject);
            Luu++;
            LuuText.text = "Luut: " + Luu;
        }
    }
}
