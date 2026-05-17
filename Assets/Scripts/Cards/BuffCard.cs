using UnityEngine;

[CreateAssetMenu(fileName = "New Buff", menuName = "Kards Invoker/Buff Card", order = 3)]
public class BuffCard : CardData
{
    [Header("Datos Específicos de Buff")]
    public bool isStackable = true;           // acumulable
}