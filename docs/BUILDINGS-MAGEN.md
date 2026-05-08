# Buildings — MAGEN (The Shield)

Magen structures are expensive, durable, and provide powerful technological upgrades.
Losing key structures is a major strategic blow.

---

## PRODUCTION

### 1. Command Bunker (Construction Yard)
| Stat | Value |
|------|-------|
| HP | 2000 |
| Armor | Fortified |
| Cost | — (starting structure) |
| Power | Generates 50 |
| Function | Builds all other structures; provides build radius |
| Special | Deep underground component — takes 50% less damage from air strikes; if destroyed, can rebuild from MCV vehicle |

> The heart of your base. Heavily fortified and partially underground.

---

### 2. Solar Array (Power Plant)
| Stat | Value |
|------|-------|
| HP | 400 |
| Armor | Light |
| Cost | 300 |
| Power | Generates 100 |
| Function | Provides power for base operations |
| Special | Low-profile (harder to spot); generates more power during "daytime" phase if day/night cycle enabled |

---

### 3. Advanced Reactor (Advanced Power)
| Stat | Value |
|------|-------|
| HP | 600 |
| Armor | Medium |
| Cost | 700 |
| Power | Generates 300 |
| Prerequisite | Solar Array |
| Special | If destroyed, causes radiation damage in small radius for 10 seconds |

---

### 4. Barracks (Infantry Production)
| Stat | Value |
|------|-------|
| HP | 800 |
| Armor | Medium |
| Cost | 500 |
| Power | -20 |
| Function | Produces all infantry units |
| Special | Heal zone — infantry near barracks slowly regenerate; can train veteran infantry for +50% cost |

---

### 5. War Factory (Vehicle Production)
| Stat | Value |
|------|-------|
| HP | 1000 |
| Armor | Heavy |
| Cost | 1200 |
| Power | -40 |
| Function | Produces all ground vehicles |
| Prerequisite | Barracks |
| Special | Repair bay — damaged vehicles can return here to repair (costs resources); builds one vehicle at a time |

---

### 6. Airfield (Air Production)
| Stat | Value |
|------|-------|
| HP | 700 |
| Armor | Medium |
| Cost | 1500 |
| Power | -60 |
| Function | Produces and rearms air units |
| Prerequisite | War Factory + Radar Station |
| Special | Each airfield supports max 4 aircraft; aircraft must return to rearm; destroyed airfield = all its planes crash in 30 seconds |

---

### 7. Naval Yard (Naval Production)
| Stat | Value |
|------|-------|
| HP | 1200 |
| Armor | Heavy |
| Cost | 1500 |
| Power | -40 |
| Function | Produces naval units |
| Prerequisite | War Factory |
| Special | Must be placed on coastline; repairs docked ships slowly |

---

## ECONOMY

### 8. Ore Refinery (Resource Processing)
| Stat | Value |
|------|-------|
| HP | 800 |
| Armor | Medium |
| Cost | 1000 |
| Power | -30 |
| Function | Processes harvested resources; comes with one Harvester |
| Special | Advanced processing upgrade available: +20% resource value |

---

### 9. Resource Silo (Storage)
| Stat | Value |
|------|-------|
| HP | 300 |
| Armor | Light |
| Cost | 200 |
| Power | -5 |
| Function | Increases resource storage capacity |
| Special | If destroyed while full, lose stored resources |

---

## DEFENSE

### 10. Iron Dome Battery (Anti-Air / Anti-Rocket)
| Stat | Value |
|------|-------|
| HP | 600 |
| Armor | Medium |
| Cost | 800 |
| Power | -40 |
| Weapon | Tamir interceptor missiles |
| Function | Automatically intercepts incoming rockets, drones, and missiles within radius |
| Special | Each battery can intercept up to 3 projectiles simultaneously; has ammo (20 interceptors, auto-resupplies over time); covers large radius |
| Prerequisite | Radar Station |

> The iconic defense. Shoots down rockets and drones. But can be overwhelmed by sheer volume.

---

### 11. David's Sling Battery (Medium-Range Interceptor)
| Stat | Value |
|------|-------|
| HP | 800 |
| Armor | Medium |
| Cost | 1500 |
| Power | -60 |
| Weapon | Stunner interceptor |
| Function | Intercepts cruise missiles and large drones that Iron Dome cannot |
| Special | Handles bigger threats; longer range than Iron Dome; 2 simultaneous intercepts; works on aircraft too |
| Prerequisite | Iron Dome Battery |

---

### 12. Arrow Launcher (Strategic Missile Defense)
| Stat | Value |
|------|-------|
| HP | 1000 |
| Armor | Heavy |
| Cost | 2500 |
| Power | -80 |
| Weapon | Arrow-3 exo-atmospheric interceptor |
| Function | Intercepts ballistic missiles (Fateh-110, Sejjil) |
| Special | Only defense against ballistic missiles; 1 intercept at a time; 30s reload; does NOT work against Fattah hypersonic |
| Prerequisite | David's Sling Battery |

> The final layer. Stops ballistic missiles in space. Essential against late-game Muqawama escalation.

---

### 13. Watchtower (Light Defense)
| Stat | Value |
|------|-------|
| HP | 300 |
| Armor | Light |
| Cost | 200 |
| Power | -5 |
| Weapon | 7.62mm MG |
| Function | Light base defense; reveals stealth in small radius |
| Special | Cheap and fast to build; detects tunnel entrances within small radius |

---

### 14. Pillbox (Heavy Defense)
| Stat | Value |
|------|-------|
| HP | 700 |
| Armor | Heavy |
| Cost | 600 |
| Power | -10 |
| Weapon | Remote 12.7mm HMG + anti-tank missile |
| Function | Strong static defense vs. ground |
| Special | Unmanned (automated); can switch between anti-infantry and anti-vehicle mode |

---

### 15. Concrete Wall / Gate
| Stat | Value |
|------|-------|
| HP | 500 per segment |
| Armor | Fortified |
| Cost | 50 per segment |
| Function | Blocks movement; funnels enemies |
| Special | Gate variant allows friendly units through; walls slow D9 equivalents but don't stop them |

---

## TECH / SUPPORT

### 16. Radar Station (Intelligence Center)
| Stat | Value |
|------|-------|
| HP | 500 |
| Armor | Medium |
| Cost | 800 |
| Power | -50 |
| Function | Enables minimap; reveals enemy unit movements on radar; required for air units |
| Special | Upgrade: "Deep Scan" — periodically pulses and reveals all tunnel networks on map for 3 seconds |
| Prerequisite | Ore Refinery |

---

### 17. Tech Center (Advanced Research)
| Stat | Value |
|------|-------|
| HP | 600 |
| Armor | Medium |
| Cost | 1500 |
| Power | -80 |
| Function | Unlocks T3 units and upgrades |
| Special | Provides global upgrades: Trophy APS recharge speed, Iron Beam power, unit veterancy rate |
| Prerequisite | Radar Station + War Factory |

---

### 18. Cyber Warfare Center (Unit 8200 HQ)
| Stat | Value |
|------|-------|
| HP | 400 |
| Armor | Light |
| Cost | 1200 |
| Power | -60 |
| Function | Produces 8200 Hacker infantry; enables cyber abilities |
| Special | Passive: jams enemy radar within large radius (reduces their minimap accuracy); Active ability: "System Crash" — disables one enemy building for 30s (cooldown 90s) |
| Prerequisite | Tech Center |

---

### 19. Field Hospital
| Stat | Value |
|------|-------|
| HP | 400 |
| Armor | Light |
| Cost | 500 |
| Power | -20 |
| Function | Heals infantry in radius; revives killed infantry at 50% chance (they respawn at hospital after 15s) |
| Prerequisite | Barracks |

---

## SUPERWEAPON

### 20. "Jericho" Silo (Strategic Deterrent)
| Stat | Value |
|------|-------|
| HP | 1500 |
| Armor | Fortified |
| Cost | 3500 |
| Power | -150 |
| Function | Superweapon — launches precision Jericho ICBM at any map location |
| Charge Time | 300 seconds |
| Damage | 5000 in small radius (building-killer precision) |
| Special | Extremely precise (small blast = less collateral); can be intercepted by enemy AA if they have Arrow-equivalent; announces launch to all players |
| Prerequisite | Tech Center + Airfield |

> The nuclear option. Precise enough to destroy one target without leveling the surroundings. But everyone knows when it's coming.

---

## Tech Tree Summary

```
Command Bunker
├── Solar Array → Advanced Reactor
├── Barracks → Field Hospital
│   └── (infantry units)
├── Ore Refinery → Resource Silo
│   └── Radar Station
│       ├── Iron Dome Battery → David's Sling → Arrow Launcher
│       ├── Airfield (requires War Factory)
│       └── Tech Center (requires War Factory)
│           ├── Cyber Warfare Center
│           └── Jericho Silo (requires Airfield)
├── War Factory
│   └── (vehicle units)
├── Naval Yard (requires War Factory)
└── Defenses (Watchtower, Pillbox, Walls — available early)
```
