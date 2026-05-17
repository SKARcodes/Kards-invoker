using UnityEngine;

[CreateAssetMenu(fileName = "New Debuff", menuName = "Kards Invoker/Debuff Card", order = 4)]

public class DebuffCard : CardData
{
    [Header("Datos Específicos de Debuff")]
    public bool isStackable = true;
}