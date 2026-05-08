# Iron Rift — Implementation Roadmap

Status legend: [x] done / [ ] to do / [~] partial

---

## Phase 0 — Critical Fixes (game won't launch without these)

### 0.1 Build the Engine
- [ ] Run `make.cmd all` (or `dotnet build OpenRA.sln -c Release`) to produce `bin/OpenRA.exe` and mod assemblies (`OpenRA.Mods.Common.dll`, `OpenRA.Mods.Cnc.dll`)
- [ ] Verify `bin/` folder is populated after build

### 0.2 Install RA Content
- [ ] First launch triggers the `ra-content` installer (mod.yaml `ContentInstallerMod: ra-content`)
- [ ] Complete the RA content download so all `.mix` files resolve

### 0.3 Generate a Playable Map (`test-arena`)
- [x] `map.yaml` exists with correct metadata, players, and spawn points
- [x] `map.bin` generated — 64×64 TEMPERAT clear tiles, ore near spawns, gems in center
- [x] Marked as `Visibility: Lobby, Shellmap` so it doubles as the menu shellmap (placeholder)
- [ ] Author a proper dedicated shellmap with bot AI battle for menu background
- [ ] Open in the in-game map editor to polish terrain, add cliffs/water if desired

### 0.4 Migrate Harvester / Refinery to Dock System
- [x] `rules/vehicles.yaml` — `MHVR`/`QHVR`: removed obsolete `Capacity`, `DeliveryBuildings`, `SearchFromProceedingRecipient`, `SearchFromOrderRecipient`. Added `StoresResources` (capacity + resources) and `DockClientManager`.
- [x] `rules/structures.yaml` — `MREF`/`QREF`: removed obsolete `Refinery.ResourceCapacity`. Added `DockHost` (Type: Unload, DockAngle, DockOffset) and `StoresPlayerResources` (capacity moved here).

---

## Phase 1 — YAML Bug Fixes (runtime errors / warnings)

### 1.1 Fix Self-Referential `mcv` Sequence
- [x] `sequences/vehicles.yaml` — `mcv: Inherits: mcv` creates a circular reference after RA sequences load. **Remove the entry entirely** (RA's `mcv` sequence is already inherited via `mod.yaml` Sequences list).

### 1.2 Fix `QPWR` Missing Shape
- [x] `rules/structures.yaml` — `QPWR` is the only building without an `Inherits@shape` line. Add `Inherits@shape: ^1x1Shape`.

### 1.3 Add Crate Actor
- [x] `rules/misc.yaml` — `CrateSpawner` is enabled in `world.yaml` but no `CRATE` actor exists. Add a minimal crate definition so spawning doesn't error.

### 1.4 Add Aircraft Death Weapons
- [x] `weapons/explosives.yaml` — Aircraft `FireWarheadsOnDeath` references `UnitExplodeSmall`. Add a proper `UnitExplodePlane` weapon for air-unit crashes (explosion + scorch mark).

---

## Phase 2 — Aircraft Overhaul

### 2.1 Add `^Drone` Base Template
- [x] `rules/defaults.yaml` — Create a `^Drone` template analogous to `^Vehicle` that provides: `OwnerLostAction`, `HiddenUnderFog`, `ActorLostNotification`, `GpsDot`, `Guard/Guardable`, `MustBeDestroyed`, `Voiced`, `Tooltip GenericName`, `WithShadow`, `FireWarheadsOnDeath`, `MapEditorData`.

### 2.2 Refactor Aircraft to Use `^Drone`
- [x] `rules/aircraft.yaml` — Replace the hand-rolled `Inherits@1: ^ExistsInWorld` / `Inherits@2: ^SpriteActor` / `Inherits@bounty: ^GlobalBounty` on all four aircraft with a single `Inherits: ^Drone`.

### 2.3 Add `Locomotor@FLY` to World
- [x] `rules/world.yaml` — Aircraft need a no-terrain locomotor (or rely on Aircraft trait). Verify aircraft don't reference an undefined locomotor.

### 2.4 Add Fluent Strings for Aircraft Generic Names
- [x] `fluent/rules.ftl` — Add `actor-drone.generic-name = Drone`.

---

## Phase 3 — Faction-Specific Starting Units

### 3.1 Fix `StartingUnits@lightsupport`
- [x] Currently hardcodes `SupportActors: loham, loham, eitan` — only Magen units. Split into two entries: one per faction with correct actors.

---

## Phase 4 — Map Content (Post-Engine-Build)

### 4.1 Create Additional Skirmish Maps
- [ ] At least 2–4 player maps on TEMPERAT, SNOW, DESERT tilesets
- [ ] Include varied terrain: cliffs, rivers, chokepoints, urban areas

### 4.2 Validate Map in Editor
- [ ] Launch in-game editor, verify all actors can be placed
- [ ] Test resource patches generate harvesters correctly

---

## Phase 5 — Missing Core Mechanics (from docs/)

These are documented in `docs/SPECIAL-MECHANICS.md` but not yet in rules.

| Priority | Mechanic | Complexity | Files Affected |
|----------|----------|-----------|----------------|
| HIGH | Tunnel Network | Large | New actors, new traits (may need C# code) |
| HIGH | Layered Missile Defense (intercept projectiles) | Large | May need custom C# trait |
| MED | Active Protection Systems (Trophy on tanks) | Medium | Condition + damage filter |
| MED | Urban Warfare / Garrisoning | Medium | Already partially in engine |
| LOW | Cyber Warfare | Medium | Support powers + conditions |
| LOW | Day/Night Cycle | Medium | Timed global conditions |
| LOW | Supply & Logistics | Large | New traits needed |
| LOW | Escalation Phases | Medium | Timed tech unlocks |

### 5.1 Tunnel Network (Muqawama)
- [ ] Define `QTUNHUB` (Tunnel Hub) and `QTUNEXIT` (Tunnel Exit) structures
- [ ] Implement `Teleport`-style enter/exit logic (engine has `InstantlyRepairs`-like examples)
- [ ] Add detection trait interaction with Oketz/Radar

### 5.2 Layered Missile Defense (Magen)
- [ ] Upgrade MDOME to use `WithInterceptProjectile`-style trait if available
- [ ] Or implement as high-priority AutoTarget with special damage vs AirborneActor

### 5.3 Active Protection Systems
- [ ] Add `ExternalCondition`-based damage negation for Merkava/Namer with cooldown

---

## Phase 6 — Polish & Content

### 6.1 Custom Art
- [ ] Replace all placeholder RA sprites with original pixel art
- [ ] Populate `bits/` and `chrome/` folders

### 6.2 Custom Audio
- [ ] Faction-specific voice sets
- [ ] Unique weapon/explosion sounds

### 6.3 Campaign Missions
- [ ] 5–8 scripted missions per faction (per `docs/CAMPAIGN.md`)
- [ ] Lua scripts in `maps/<mission>/`

### 6.4 Superweapons
- [ ] Define support powers for both factions
- [ ] Add `SupportPowerManager` entries to `player.yaml`

### 6.5 Tech Levels
- [ ] Wire up `TechLevel` prerequisites on actors
- [ ] Connect to the lobby dropdown already defined in fluent

---

## Immediate Implementation Scope (This Session)

The following are being implemented **now** (Phases 0.3, 1.x, 2.x, 3.1):

1. Fix `mcv` self-reference in sequences
2. Fix `QPWR` missing shape
3. Add `CRATE` actor definition
4. Add `UnitExplodePlane` weapon
5. Add `^Drone` base template
6. Refactor all aircraft to use `^Drone`
7. Add aircraft fluent strings
8. Fix starting units per faction
9. Generate a playable `map.bin` for test-arena
10. Add `MapStartingLocations`, `SpawnStartingUnits`, `MissionObjectives`, `SupportPowerManager`, etc. for skirmish parity
11. Engine fix — `AIUtils.ActiveTransformsInfo` so MCV with multiple `Transforms@` (per-faction) does not crash bot modules
12. Add `RequiredForShortGame: true` to `MCV`, `MCMD`, `QCMD` so the default Short-Game victory condition has units to track (otherwise both players were instantly defeated)
