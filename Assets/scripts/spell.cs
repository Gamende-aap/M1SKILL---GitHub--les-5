using UnityEngine;
using UnityEngine.UI; // Nodig voor UI

public class Spellbook : MonoBehaviour
{
    public Text manaText; // Sleep hier je Text component in in de Inspector
    int currentMana = 50;

    void Start()
    {
        UpdateManaUI(); // Laat meteen je huidige mana zien
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Z)) CastSpell("Fireball");
        if (Input.GetKeyDown(KeyCode.X)) CastSpell("Heal");
        if (Input.GetKeyDown(KeyCode.C)) CastSpell("IceBlast");
         if (Input.GetKeyDown(KeyCode.V)) 
    {
        string randomSpell = GetRandomSpell();
        CastSpell(randomSpell);
    }
    }

    void CastSpell(string spellName)
    {
        if (spellName == "Random")
            spellName = GetRandomSpell();

        int cost = GetManaCost(spellName);
        if (currentMana >= cost)
        {
            currentMana -= cost;
            Debug.Log($"Casting {spellName}! Effect: {GetSpellEffect(spellName)}");
            UpdateManaUI();
        }
        else
        {
            Debug.Log($"Not enough mana for {spellName}!");
        }
    }

    int GetManaCost(string spell)
    {
        return spell.ToLower() switch
        {
            "fireball" => 30,
            "heal" => 20,
            "iceblast" => 25,
            _ => 0
        };
    }

    string GetSpellEffect(string spell)
    {
        return spell.ToLower() switch
        {
            "fireball" => "Shoots a fireball!",
            "heal" => "Restores health!",
            "iceblast" => "Freezes the enemy!",
            _ => "Unknown spell..."
        };
    }

    string GetRandomSpell()
    {
        string[] spells = { "Fireball", "Heal", "IceBlast" };
        return spells[Random.Range(0, spells.Length)];
    }

    void UpdateManaUI()
    {
        if (manaText != null)
            manaText.text = $"Mana: {currentMana}";
    }
}
