# Project: IRON RIFT — Game Design Overview

## Concept

**IRON RIFT** is a 2D real-time strategy mod for OpenRA set in an alternate-history version of the Middle Eastern conflict (2023–2026). It pits two asymmetric factions against each other in a war defined by precision technology vs. overwhelming swarm tactics, intelligence superiority vs. tunnel deception, and layered air defense vs. rocket saturation.

The game is **semi-realistic** in its doctrinal inspiration (real weapon categories, real tactical dilemmas) and **semi-fantasy** in its execution (exaggerated abilities, fictional super-units, stylized escalation arcs).

---

## Design Pillars

### 1. Asymmetric Warfare
The two factions play fundamentally differently. One faction wins through precision, the other through volume. One faction defends the sky, the other owns the underground.

### 2. Layered Conflict
Combat operates on multiple layers simultaneously:
- **Sky layer** — drones, jets, missiles, air defense
- **Surface layer** — armor, infantry, urban combat
- **Underground layer** — tunnels, bunkers, hidden networks
- **Information layer** — intel, cyber, deception

### 3. Escalation Curve
Matches begin as skirmishes and escalate toward devastating late-game superweapons and total war mechanics. Early game rewards scouting and positioning; late game rewards industrial output and decisive strikes.

### 4. Moral Ambiguity
Neither faction is portrayed as "good" or "evil." Both have strengths, flaws, and desperate survival motivations. The player experiences war as brutal, costly, and strategically fascinating.

---

## Faction Summary

| Faction | Codename | Doctrine | Strength | Weakness |
|---------|----------|----------|----------|----------|
| **Magen** (Shield) | Iron Covenant | Precision + Defense | Tech superiority, intel, air power | Expensive, low unit count, attrition-vulnerable |
| **Muqawama** (Resistance) | Shadow Axis | Asymmetry + Swarm | Cheap mass, tunnels, surprise | Fragile individually, slower tech curve |

---

## Visual Style

- **Magen**: Clean angular designs, blue-white-grey palette, high-tech glow effects, geometric HUD
- **Muqawama**: Rough improvised look, green-black-sand palette, underground/organic feel, chaotic swarm animations

---

## Win Conditions

1. **Annihilation** — destroy all enemy structures and units
2. **Decapitation** — destroy the enemy Command structure
3. **Objective** — campaign-specific (hold territory, escort, survive timer)

---

## Target Scope (Mod v1.0)

- 2 fully playable factions
- 15–20 unique units per faction
- 10–12 buildings per faction
- 8 weapon categories
- 6 special mechanics (tunnels, missile defense, cyber, etc.)
- 5–8 campaign missions per faction
- 4+ skirmish maps

---

## File Reference

| Document | Contents |
|----------|----------|
| `FACTIONS.md` | Detailed faction lore, identity, and doctrine |
| `UNITS-MAGEN.md` | All Magen faction units |
| `UNITS-MUQAWAMA.md` | All Muqawama faction units |
| `BUILDINGS-MAGEN.md` | Magen structures and tech tree |
| `BUILDINGS-MUQAWAMA.md` | Muqawama structures and tech tree |
| `WEAPONS.md` | All weapon systems, damage types, mechanics |
| `SPECIAL-MECHANICS.md` | Unique gameplay systems |
| `CAMPAIGN.md` | Campaign structure and mission outlines |
