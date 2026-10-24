using UnityEngine;
using UnityEngine.InputSystem;

public class Ligar_Lanterna : MonoBehaviour
{
    [SerializeField] private GameObject Luz_Lanterna;
    [SerializeField] private GameObject Texto;

    private bool lanternaLigada = false;

    void Start()
    {
        Luz_Lanterna.SetActive(false);
        Texto.SetActive(false);
        lanternaLigada = false;
    }

    public void SetLanterna(InputAction.CallbackContext callback)
    {
        AlternarLanterna();
    }

    public void AlternarLanterna()
    {
        lanternaLigada = !lanternaLigada;

        Luz_Lanterna.SetActive(lanternaLigada);
        Texto.SetActive(lanternaLigada);
    }
}