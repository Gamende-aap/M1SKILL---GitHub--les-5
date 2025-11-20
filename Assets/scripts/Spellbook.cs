using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class SpellbookUI : MonoBehaviour
{
    public TextMeshProUGUI spellOutputText;
    public TextMeshProUGUI manaText;
    public Button fireballButton;
    public Button healButton;
    public Button iceblastButton;
    public Button regenerateButton; // nieuwe knop voor mana herstellen

    int currentMana = 50;
    int maxMana = 100;

    void Start()
    {
        // Knoppen koppelen
        fireballButton.onClick.AddListener(() => CastSpell("Fireball"));
        healButton.onClick.AddListener(() => CastSpell("Heal"));
        iceblastButton.onClick.AddListener(() => CastSpell("IceBlast"));
        regenerateButton.onClick.AddListener(RegenerateMana);

        UpdateManaUI();
        spellOutputText.text = "Select a spell to cast!";
    }

    void CastSpell(string spellName)
    {
        int manaCost = GetManaCost(spellName);
        string effect = GetSpellEffect(spellName);
        bool canCast = CanCast(spellName, currentMana);

        if (canCast)
        {
            currentMana -= manaCost;
            spellOutputText.text = $"Casting {spellName}!\nEffect: {effect}\n(-{manaCost} mana)";
        }
        else
        {
            spellOutputText.text = $"Not enough mana for {spellName}!\nRequires {manaCost} mana.";
        }

        UpdateManaUI();
    }

    void RegenerateMana()
    {
        int regenAmount = 10;

        if (currentMana < maxMana)
        {
            currentMana += regenAmount;
            if (currentMana > maxMana)
                currentMana = maxMana;

            spellOutputText.text = $"You meditate and regain {regenAmount} mana.";
        }
        else
        {
            spellOutputText.text = "Your mana is already full!";
        }

        UpdateManaUI();
    }

    int GetManaCost(string spellName)
    {
        switch (spellName.ToLower())
        {
            case "fireball": return 30;
            case "heal": return 20;
            case "iceblast": return 25;
            default: return 0;
        }
    }

    bool CanCast(string spellName, int mana)
    {
        int cost = GetManaCost(spellName);
        return mana >= cost;
    }

    string GetSpellEffect(string spellName)
    {
        switch (spellName.ToLower())
        {
            case "fireball": return "Shoots a blazing ball of fire!";
            case "heal": return "Restores your health!";
            case "iceblast": return "Freezes your enemy solid!";
            default: return "Unknown spell...";
        }
    }

    void UpdateManaUI()
    {
        manaText.text = $"Mana: {currentMana}/{maxMana}";
    }
}
