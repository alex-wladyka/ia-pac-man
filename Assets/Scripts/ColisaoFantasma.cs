using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColisaoFantasma : MonoBehaviour
{
    public GameObject fantasma;
    private Vector3 posInicial;

    private void Start()
    {
        posInicial = fantasma.transform.position;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == LayerMask.NameToLayer("Pacman"))
        {
            Debug.Log("aaaaaaaaaaaaaaaaaaaaaaaa");
            FindObjectOfType<GameManager>().PacmanEaten();
            //fantasma.SetActive(false);
            Invoke(nameof(Resetar),2f);
        }
    }

    private void Resetar()
    {
        SceneManager.LoadScene("GameScene_Pathfinding");
    }
}
