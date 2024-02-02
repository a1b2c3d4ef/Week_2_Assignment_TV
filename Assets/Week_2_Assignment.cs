using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Week_2_Assignment : MonoBehaviour
{
    [SerializeField] private string characterName;
    [SerializeField] private int proficiencyBonus;
    [SerializeField] private bool finesseWeapon;
    [SerializeField][Range(-5, 5)] private int strength, dexterity;

    private void Start()
    {
        print("Press Space to roll dice");
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            RollDice();
    }
    private void RollDice()
    {
        int diceNum = Random.Range(1, 20);
        int enemyAC = Random.Range(10, 20);
        int modDamage = GetModifiderDamage();
        print(characterName + "'s hit modifier is " + (modDamage > 0 ? "+" : "") + modDamage);
        print("Enemy AC is " + enemyAC);
        print(characterName + " rollled a " + diceNum);
        print((modDamage + diceNum > enemyAC ? "Enemy is hit!" : "Enemy dodged " + characterName + "'s attack!"));

    }

    private int GetModifiderDamage()
    {
        return (finesseWeapon ? (strength >= dexterity ? strength : dexterity) : strength) + proficiencyBonus;
    }
}
