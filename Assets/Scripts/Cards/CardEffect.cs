using UnityEngine;
[CreateAssetMenu(fileName = "New Effect", menuName = "Kards Invoker/Card Effect", order = 2)]

public class CardEffect : ScriptableObject
{
[Header("Información del Efecto")]
    public string effectName = "Nombre del Efecto";
    
    [TextArea(2, 4)]
    public string description = "Descripción breve";

    [Header("Tipo y Valor")]
    public EffectType effectType;
    public float value = 5f;

    [Header("Duración")]
    public bool isPermanent = true;
    public int durationTurns = 1;             // Solo se usa si isPermanent = false

    [Header("Target")]
    public TargetType target = TargetType.EnemyInvocation;

    [Header("Visual")]
    public Sprite icon;
}

public enum EffectType
{
    // Efectos Comunes
    IncreaseAttack,
    IncreaseDefense,
    IncreaseMaxHealth,
    RestoreHealth,
    DrawCards,
    CleanDebuffs,
    RestoreMana,

    // Efectos Específicos
    RepeatInvocationSkill,
    CopyEnemyCard,
    BlockNextAttacks,
    LastBreath,
    // ... más adelante
}

public enum TargetType
{
    MyInvocation,
    EnemyInvocation,
    BothInvocations,
    Player,
    EnemyPlayer,
    BothPlayers
}