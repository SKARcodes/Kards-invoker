using System.Collections.Generic;
using UnityEngine;

public class PlayerData : MonoBehaviour
{

    [Header("Información del Jugador")]
    public string playerName = "Jugador";

    [Header("Recursos")]
    public int currentMana = 10;
    public int maxMana = 10;

    [Header("Mano y mazo")]
    public List<CardData> deck = new List<CardData>();
    public List<CardData> hand = new List<CardData>();

    [Header("Invocación actual")]
    public InvocationCard currentInvocation;
    public GameObject invocationModel1; //para el modelo 3D

//Mecanica para robar cartas (a mejorar)
    public void DrawCard(int amount = 1)
    {
        Debug.Log($"Robaste {amount} carta(s)");
    }

    public void SpendMana(int amount)
    {
        currentMana = Mathf.Max(0, currentMana - amount);
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
