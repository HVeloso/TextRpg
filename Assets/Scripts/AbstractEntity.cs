using UnityEngine;

public class AbstractEntity : MonoBehaviour
{
    // Entity Base Status -> ScriptableObject | Status | Status Mediator
    private float _health;
    private float _strength;
    private float _luck;
    private float _dexterity;

    // Inventory
    private int _potions;
    private int _armorHelmet;
    private int _armorChest;
    private int _weapom1;
    private int _weapom2;
    
    // Level system
    private float _requireToNextLevel;
    private float _currentExp;
}
