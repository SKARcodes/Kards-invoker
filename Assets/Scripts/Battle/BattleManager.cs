using UnityEngine;
using System.Collections;
using Unity.VisualScripting;
using JetBrains.Annotations;

public class NewEmptyCSharpScript : MonoBehaviour
{
    public static MonoBehaviour Instance;

    [Header("Referencias")]
    public PlayerData player;
    public PlayerData EnemyAI;

    [Header("Estado Actual")]
    public battlePhase currentPhase = battlePhase.Preparation;
    public int currentTurn = 1;
    public bool isPlayerTurn = true;

    public enum battlePhase
    {
        None,
        IntroCinematic,
        InvocationSelection,
        Preparation,
        Combat,
        Victory,
        Defeat
    }

    private void Awake()
    {
        Instance = this;
    }
    private void Start()
    {
        StartNewBattle();
    }

    public void StartNewBattle()
    {
        currentTurn = 1;
        currentPhase = battlePhase.IntroCinematic;
        Debug.Log("Inicio de batalla");

        StartCoroutine(IntroCinematicRoutine());
    }

    private IEnumerator IntroCinematicRoutine()
    {
        //animaciones de camara
        Debug.Log("Reproduciendo cinematica de introducción");
        yield return new WaitForSeconds(4f);

        currentPhase = battlePhase.InvocationSelection;
        Debug.Log("Fase: Selección de Invocación");
        //ui de seleccion de invocación
    }

    public void OnInvocationSelected(InvocationCard selectCard)
    {
        player.currentInvocation = selectCard;
        Debug.Log($"Jugador invocó: {selectCard.cardTitle}");

        ApplyInvocationEffects();
        currentPhase = battlePhase.Preparation;
        StartPreparationPhase();
    }

    private void ApplyInvocationEffects()
    {
        Debug.Log("Aplicando efectos de invocación");
    }


    public void StartPreparationPhase()
    {
        Debug.Log("Turno de Preparación");
        //robar cartas y ui
    }

    public void EndPreparationPhase()
    {
        Debug.Log("Jugador terminó su turno de preparación");
        currentPhase = battlePhase.Combat;
        StartCombatPhase();
    }

    private void StartCombatPhase()
    {
        Debug.Log("Fase de combate (10seg)");

        Invoke(nameof(EndCombatPhase), 10f);
    }

    public void EndCombatPhase()
    {
        Debug.Log("Combate terminado");
        CheckBattleEnd();

        if(currentPhase != battlePhase.Victory && currentPhase != battlePhase.Defeat)
        {
            currentTurn++;
            currentPhase = battlePhase.Preparation;
            StartPreparationPhase();
        }
    }

    private void CheckBattleEnd()
    {
        if (player.currentInvocation == null)
        {
            currentPhase = battlePhase.Defeat;
            Debug.Log("DERROTA");
        }
    }

    [ContextMenu("Preparación de combate")]
    public void DebugSkipToPreparation() => StartPreparationPhase();
}
