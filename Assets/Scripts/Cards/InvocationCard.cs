using UnityEngine;
using System.Collections.Generic;

[CreateAssetMenu(fileName = "New Invocation", menuName = "Kards Invoker/Invocation Card", order = 5)]

public class InvocationCard : CardData
{
    [Header("Stat base de la invocación")]
    public int baseHealth = 200;
    public int baseAttack = 12;
    public int baseDefense = 8;
    public float AttackSpeed = 1.8f;

    [Header("Habilidad de invocación")]
    [TextArea(3,5)]

    public string InvocationSkillDescription;

    public List<CardEffect> invocationEffects = new List<CardEffect>(); // Efectos de invocación

    [Header("Visual 3D")]
    public GameObject ModelPrefab; // Modelo 3D
}