# Buildings — MUQAWAMA (The Resistance)

Muqawama structures are cheap, fast to build, and many are hidden underground.
Destroying their surface buildings is meaningless if the tunnels survive.

---

## PRODUCTION

### 1. Command Mosque (Construction Hub)
| Stat | Value |
|------|-------|
| HP | 1200 |
| Armor | Medium |
| Cost | — (starting structure) |
| Power | Generates 30 |
| Function | Builds all other structures; provides build radius |
| Special | Disguised as civilian structure — enemies cannot distinguish it from decoy buildings without recon; if destroyed, secondary underground command post activates (one-time backup) |

> Hidden in plain sight. Even has a backup underground node.

---

### 2. Generator (Power)
| Stat | Value |
|------|-------|
| HP | 250 |
| Armor | Light |
| Cost | 150 |
| Power | Generates 60 |
| Function | Basic power supply |
| Special | Small footprint; can be built inside tunnel network (immune to air strikes) |

---

### 3. Fuel Depot (Advanced Power)
| Stat | Value |
|------|-------|
| HP | 300 |
| Armor | Light |
| Cost | 400 |
| Power | Generates 150 |
| Prerequisite | Generator |
| Special | Explodes violently when destroyed (damages nearby structures); can be built underground |

---

### 4. Training Camp (Infantry Production)
| Stat | Value |
|------|-------|
| HP | 500 |
| Armor | Light |
| Cost | 300 |
| Power | -10 |
| Function | Produces all infantry units |
| Special | Builds infantry 30% faster than Magen equivalent; can queue larger batches; "Conscription" upgrade: reduces all infantry cost by 20% |

---

### 5. Workshop (Vehicle Production)
| Stat | Value |
|------|-------|
| HP | 600 |
| Armor | Medium |
| Cost | 700 |
| Power | -25 |
| Function | Produces ground vehicles |
| Prerequisite | Training Camp |
| Special | Can produce 2 vehicles simultaneously (but both build slower); improvised repair: vehicles heal 1HP/s when adjacent |

---

### 6. Drone Hangar (Air/Drone Production)
| Stat | Value |
|------|-------|
| HP | 400 |
| Armor | Light |
| Cost | 600 |
| Power | -30 |
| Function | Produces drones and limited air units |
| Prerequisite | Workshop |
| Special | Drones do NOT require landing/rearming (fire-and-forget); hangar supports unlimited drone count; very vulnerable to air strikes |

---

### 7. Smuggling Dock (Naval/Economy)
| Stat | Value |
|------|-------|
| HP | 400 |
| Armor | Light |
| Cost | 500 |
| Power | -15 |
| Function | Produces naval units; generates smuggling income |
| Prerequisite | Workshop |
| Special | Passive income: +$30/10s from arms trafficking; produces smuggling dhows for additional economy |

---

## ECONOMY

### 8. Ore Collector (Resource Processing)
| Stat | Value |
|------|-------|
| HP | 500 |
| Armor | Light |
| Cost | 600 |
| Power | -15 |
| Function | Processes harvested resources; comes with one Harvester |
| Special | Cheaper than Magen equivalent but less efficient (processes slower) |

---

### 9. Smuggling Tunnel (Hidden Economy)
| Stat | Value |
|------|-------|
| HP | 300 |
| Armor | Light (underground) |
| Cost | 400 |
| Power | -10 |
| Function | Generates passive income ($40/10s); immune to surface attacks |
| Special | Completely invisible — must be detected by ground scan; represents cross-border smuggling of weapons and funds; destroyed only by tunnel-clearing abilities |
| Prerequisite | Tunnel Hub |

> Free money from underground. Invisible until detected. The backbone of Muqawama's economy.

---

### 10. Arms Cache (Storage + Bonus)
| Stat | Value |
|------|-------|
| HP | 200 |
| Armor | Light |
| Cost | 150 |
| Power | -5 |
| Function | Increases resource storage; provides unit discount |
| Special | Each Arms Cache reduces unit costs by 3% (stacks up to 5x = 15%); if destroyed, stockpiled weapons explode |

---

## TUNNEL NETWORK (Unique System)

### 11. Tunnel Hub (Network Core)
| Stat | Value |
|------|-------|
| HP | 800 |
| Armor | Medium (underground) |
| Cost | 600 |
| Power | -20 |
| Function | Core of tunnel system; connects all tunnel exits; allows unit transit underground |
| Special | Hidden until detected; units enter any tunnel exit and emerge at any other exit instantly; if Hub destroyed, all tunnels collapse (catastrophic) |
| Prerequisite | Training Camp |

> The heart of the tunnel network. Destroying this kills the entire underground system.

---

### 12. Tunnel Exit (Network Node)
| Stat | Value |
|------|-------|
| HP | 200 |
| Armor | Light |
| Cost | 200 |
| Power | -5 |
| Function | Entry/exit point for tunnel travel; spawns units during Tunnel Breach ability |
| Special | Hidden until enemy unit walks within 2 tiles or detection ability used; can be built anywhere on map by Tunnel Borer unit; maximum 8 per player |
| Prerequisite | Tunnel Hub |

> Pop-up points for surprise attacks. Hidden until the enemy literally steps on them.

---

### 13. Underground Factory (Hidden Production)
| Stat | Value |
|------|-------|
| HP | 600 |
| Armor | Medium |
| Cost | 1200 |
| Power | -40 |
| Function | Produces vehicles and drones underground — completely immune to bombing |
| Special | Build speed is 50% slower than surface Workshop; but units emerge from any tunnel exit; cannot be detected by radar (only ground scan) |
| Prerequisite | Tunnel Hub + Workshop |

> Build tanks underground. They emerge from tunnel exits. Enemy bombing does nothing.

---

## DEFENSE

### 14. Minefield (Passive Defense)
| Stat | Value |
|------|-------|
| HP | — (individual mines: 1 HP) |
| Armor | None |
| Cost | 100 (covers 5x5 area) |
| Weapon | Anti-tank mine (400 damage) or anti-personnel (100 damage, area) |
| Function | Passive area denial |
| Special | Invisible until triggered or detected; cheap and fast to deploy; slows enemy advance massively |

---

### 15. IED Trap (Triggered Explosive)
| Stat | Value |
|------|-------|
| HP | 50 |
| Armor | None |
| Cost | 100 |
| Weapon | 800 damage in medium radius when triggered |
| Function | Manual detonation trap |
| Special | Player triggers manually when enemy passes; invisible; can be placed inside buildings; devastating ambush tool |

---

### 16. Anti-Air Emplacement
| Stat | Value |
|------|-------|
| HP | 400 |
| Armor | Medium |
| Cost | 400 |
| Power | -10 |
| Weapon | SA-7 MANPAD battery (auto-fires at air units) |
| Function | Static anti-air defense |
| Special | Cheap; effective vs. helicopters and drones; less effective vs. fast jets; can be garrisoned by infantry for +50% fire rate |

---

### 17. Rocket Pit (Fortified Rocket Position)
| Stat | Value |
|------|-------|
| HP | 300 |
| Armor | Medium |
| Cost | 350 |
| Power | -10 |
| Weapon | 122mm Grad-type rockets |
| Function | Static indirect fire emplacement |
| Special | Fires at maximum range in targeted area; low accuracy; cheap to mass-produce; designed to overwhelm Iron Dome through volume |

---

### 18. Booby-Trapped Building (Deception Defense)
| Stat | Value |
|------|-------|
| HP | 300 |
| Armor | Light |
| Cost | 200 |
| Weapon | 1000 damage explosion when entered or destroyed by enemy |
| Function | Disguised trap structure |
| Special | Looks identical to civilian building or friendly structure; when enemy enters or attacks it, massive explosion; one-time use |

---

## TECH / SUPPORT

### 19. Propaganda Center (Morale/Tech)
| Stat | Value |
|------|-------|
| HP | 400 |
| Armor | Light |
| Cost | 600 |
| Power | -20 |
| Function | Unlocks T2 units and provides morale bonuses |
| Special | All infantry in large radius gain +15% speed and +10% attack; "Martyrdom Doctrine" upgrade: suicide units do 30% more damage |
| Prerequisite | Training Camp |

---

### 20. Coordination Center (T3 Command)
| Stat | Value |
|------|-------|
| HP | 500 |
| Armor | Medium |
| Cost | 1000 |
| Power | -40 |
| Function | Unlocks T3 and superweapons; coordinates multi-front attacks |
| Special | Ability: "Synchronized Assault" — all units gain +30% speed for 15 seconds (cooldown 120s); required for ballistic missiles and Fattah platform |
| Prerequisite | Propaganda Center + Underground Factory |

---

## SUPERWEAPON

### 21. "Underground Sun" (Strategic Weapon)
| Stat | Value |
|------|-------|
| HP | 1000 (underground, immune to air) |
| Armor | Fortified |
| Cost | 3000 |
| Power | -100 |
| Function | Superweapon — launches salvo of 100 rockets at target area |
| Charge Time | 240 seconds (faster than Magen's Jericho) |
| Damage | 200 per rocket × 100 rockets across large area (total 20000 distributed) |
| Special | Inaccurate but covers massive area; some will be intercepted by Iron Dome but sheer volume means many get through; announced to all players |
| Prerequisite | Coordination Center |

> Not precise. Not surgical. Just overwhelming. Blankets an entire base zone with destruction.

---

## Tech Tree Summary

```
Command Mosque
├── Generator → Fuel Depot
├── Training Camp → Propaganda Center → Coordination Center
│   └── (infantry units)        │           └── "Underground Sun"
│                               └── (T2 units)
├── Ore Collector → Arms Cache (×5 stacking)
├── Workshop → Drone Hangar
│   └── (vehicles)   └── (drones)
├── Tunnel Hub (requires Training Camp)
│   ├── Tunnel Exit (×8 max)
│   ├── Smuggling Tunnel (economy)
│   └── Underground Factory (requires Workshop)
├── Smuggling Dock (requires Workshop)
└── Defenses (Minefields, IEDs, Rocket Pits, AA — available early)
    └── Booby-Trapped Building (deception)
```

---

## Key Differences from Magen Buildings

| Aspect | Magen | Muqawama |
|--------|-------|----------|
| Visibility | All visible | Many hidden underground |
| Durability | High HP, heavy armor | Low HP but replaceable/hidden |
| Cost | Expensive | Cheap |
| Production speed | Slow, one-at-a-time | Fast, parallel production |
| Defense philosophy | Active interception | Passive traps and concealment |
| Economy | Legitimate resource processing | Smuggling + hidden income |
| Vulnerability | Lose a building = lose capability | Lose surface = still have tunnels |
| Superweapon style | Precision nuke | Saturation rocket storm |
