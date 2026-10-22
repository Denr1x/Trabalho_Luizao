using UnityEditor.Build;
using UnityEngine;
using UnityEngine.UIElements;
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
    }

    
    public void SetLanterna(InputAction.CallbackContext callback)
    {
        lanternaLigada = !lanternaLigada;
        if(lanternaLigada)
        {
            Luz_Lanterna.SetActive(true);
            Texto.SetActive(true);
            lanternaLigada = true;
        }
        else
        {
            Luz_Lanterna.SetActive(false);
            Texto.SetActive(false);
            lanternaLigada = false;
        }
        
    }
}
