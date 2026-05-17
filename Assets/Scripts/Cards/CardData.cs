using UnityEngine;
using System.Collections.Generic;

[CreateAssetMenu(fileName = "New Card", menuName = "Kards Invoker/Card Data", order = 1)]
public class CardData : ScriptableObject
{
    [Header("Información General")]
    public string cardTitle = "Nombre de la Carta";
    
    [TextArea(3, 6)]
    public string description = "Descripción de la carta";

    [Header("Visual")]
    public Sprite artwork;
    public Rarity rarity = Rarity.Common;

    [Header("Costos")]
    public int manaCost = 3;

    [Header("Tipo de Carta")]
    public CardType cardType = CardType.Buff;

    [Header("Lista de Efectos (Sistema Avanzado)")]
    public List<CardEffect> effects = new List<CardEffect>();
    
    public string effectDescription = "Descripción del efecto ingame";
}

public enum CardType
{
    Invocation,
    Buff,
    Debuff
}

public enum Rarity
{
    Common,
    Rare,
    Epic,
    Legendary
}