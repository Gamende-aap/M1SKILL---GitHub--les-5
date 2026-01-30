# GDV Lessen

<br>

# Wat Hebben We Gedaan – Les 1.1

<br>

We hebben Unity geïnstalleerd en ons eerste project gemaakt.
We leerden de basis van de Unity-interface kennen: Scene View, Game View, Hierarchy, Inspector en Project Window.
We ontdekten dat alles in Unity een GameObject is, en dat elk object components heeft die bepalen wat het doet.
Daarna maakten we ons eerste GameObject (een cube) en pasten we positie, rotatie en schaal aan met het Transform-component.
Tot slot leerden we wat een Scene is en hoe je je project netjes organiseert in mappen.

<br>

# Wat Hebben We Gedaan – Les 1.2

<br>

We hebben ons eerste C# script in Unity gemaakt.
We leerden wat programmeren eigenlijk is: stap-voor-stap instructies geven aan de computer.
We ontdekten de basisstructuur van een script: using statements, class, Start en Update functies.
We gebruikten Debug.Log() om berichten te tonen in de Console.
We leerden hoe je comments toevoegt om je code duidelijk te houden.
Tot slot hebben we ons script op een GameObject gezet en uitgeprobeerd tijdens het spelen van de game.

<br>

![1_2_RESULT_game_museum](https://github.com/user-attachments/assets/fdc2ed00-ec62-431c-b2f4-e59f40f1e2b9)

<br>

# Link naar 1.1/1.2 scripts
https://github.com/Gamende-aap/M1SKILL---GitHub--les-5/blob/main/Assets/scripts/PlayerMovement.cs

<br>

# Wat Hebben We Gedaan – Les 2.1

<br>

We hebben geleerd hoe je in Unity GameObjects kunt besturen met code.
We ontdekten wat Scenes, GameObjects en Components zijn, en hoe je het Transform-component gebruikt om positie, rotatie en schaal aan te passen.
Met Time.deltaTime zorgden we dat beweging op elke computer even snel gaat.
Tot slot hebben we een script gemaakt om een object te laten bewegen met behulp van Vector3.

<br>

![1_2_RESULT_playlist](https://github.com/user-attachments/assets/2886890b-f615-404a-85d8-5040ca7f9e12)

<br>

# Wat Hebben We Gedaan – Les 2.2

<br>

We hebben geleerd hoe je informatie kunt opslaan en gebruiken in Unity met variabelen.
We ontdekten de belangrijkste datatypes: int (gehele getallen), float (kommagetallen), string (tekst) en bool (waar/onwaar).
We hebben onze eerste variabelen aangemaakt, veranderd en gebruikt met Debug.Log().
We leerden hoe we toetsenbordinput kunnen verwerken met Input.GetKey(), Input.GetKeyDown() en Input.GetAxis().
Tot slot maakten we een simpel bewegingssysteem waarbij een GameObject reageert op WASD toetsen en leerden we hoe variabelen zichtbaar worden in de Inspector.

<br>

# Link naar 2.1/2.2 scripts
https://github.com/Gamende-aap/M1SKILL---GitHub--les-5/blob/main/Assets/scripts/PlayerMovement.cs
<br>
https://github.com/Gamende-aap/M1SKILL---GitHub--les-5/blob/main/Assets/scripts/player.cs

<br>

# Wat Hebben We Gedaan – Les 3.1

<br>

We hebben geleerd hoe je realistische physics toevoegt aan GameObjects in Unity.
We ontdekten het Rigidbody component, dat objecten massa, zwaartekracht en krachten geeft.
We leerden wat Colliders zijn en hoe ze botsingsdetectie mogelijk maken.
We hebben physics-objecten laten vallen, botsen en bewegen met AddForce(), velocity en physics materials.
Tot slot hebben we gekeken naar best practices, zoals het gebruik van FixedUpdate voor physics en het vermijden van handmatig aanpassen van transform.position.

<br>

![3_1_cube_collision](https://github.com/user-attachments/assets/bb75b2bf-6bc5-4f57-a233-4955364d0bc5)

<br>


# Wat Hebben We Gedaan – Les 3.2

<br>

We hebben geleerd hoe je functies maakt en gebruikt om code te organiseren en hergebruiken.
We ontdekten het gebruik van argumenten (parameters) om data door te geven aan functies en return types om data terug te krijgen.
We maakten praktische voorbeelden met jumping, beweging en scoreberekeningen.
We bespraken het verschil tussen void functies (geen output) en functies die een waarde teruggeven.
Tot slot hebben we gekeken naar function naming best practices, variable scope (local vs global) en hoe je functies kunt debuggen met Debug.Log().

<br>

# Link naar 3.1/2.13.2 scripts
https://github.com/Gamende-aap/M1SKILL---GitHub--les-5/blob/main/Assets/scripts/player.cs
<br>
https://github.com/Gamende-aap/M1SKILL---GitHub--les-5/blob/main/Assets/scripts/WeaponSelector.cs

<br>

# Wat Hebben We Gedaan – Les 4.1

<br>

We hebben geleerd hoe Colliders en Triggers werken en het verschil ertussen.
We ontdekten dat Physics Colliders botsingen fysiek afhandelen, terwijl Trigger Colliders alleen contact detecteren.
We gebruikten Tags om GameObjects te labelen en makkelijk te identificeren.
We hebben een eenvoudig pickup systeem gemaakt waarbij een speler een trigger object kan oppakken.
Tot slot bespraken we Rigidbody combinaties, Kinematic vs Non-Kinematic, en best practices voor performance en trigger detectie.

<br>

<img width="1506" height="951" alt="4_1_transparent_material" src="https://github.com/user-attachments/assets/45af1bc2-3fb1-4d2f-abfc-99f168074ab7" />

<br>

# Wat Hebben We Gedaan – Les 4.2

<br>

We hebben geleerd hoe je met code kunt reageren op botsingen en triggers.
We ontdekten het verschil tussen OnTriggerEnter/Stay/Exit voor triggers en OnCollisionEnter/Stay/Exit voor echte physics botsingen.
We hebben tags gebruikt om te controleren welk object contact maakte met een collider.
We maakten praktische systemen zoals een pickup item, een damage zone, en een bouncing ball.
Tot slot bespraken we best practices zoals het gebruik van CompareTag(), het organiseren van collision code in functies en debuggen met Debug.Log().

<br>

# Link naar 4.1/4.2 scripts
https://github.com/Gamende-aap/M1SKILL---GitHub--les-5/blob/main/Assets/scripts/CollectObject.cs
<br>
https://github.com/Gamende-aap/M1SKILL---GitHub--les-5/blob/main/Assets/scripts/HitObject.cs
<br>
https://github.com/Gamende-aap/M1SKILL---GitHub--les-5/blob/main/Assets/scripts/Coincollector.cs

<br>

# Wat Hebben We Gedaan – Les 5.1

<br>

We hebben geleerd hoe we beslissingen in code kunnen nemen met if-statements en switch statements.
We ontdekten het verschil tussen if, else if en else, en hoe we complexe logica kunnen maken met vergelijkings- en logische operatoren (==, !=, <, >, >=, <=, &&, ||, !).
We hebben praktische voorbeelden gemaakt zoals een level system, een combat system en een NPC dialogue system, waarbij input, collision detection en functies samenkomen.
We bespraken switch statements als overzichtelijk alternatief voor veel if-else checks en leerden hoe je ze correct gebruikt met case en break.
Daarnaast hebben we geavanceerde technieken behandeld zoals de ternary operator voor korte beslissingen en early returns / guard clauses om code leesbaarder te maken en nesting te verminderen.

<br>

# Wat Hebben We Gedaan – Les 5.2

<br>

We hebben geleerd hoe we logica, collision detection en input combineren om interactieve gameplay te maken.
We gebruikten if-statements en switch statements om beslissingen te nemen gebaseerd op spelvoorwaarden zoals gezondheid, sleutels en nabijheid van objecten.
We hebben de GetComponent<Type>() functie toegepast om componenten en scripts van andere GameObjects op te halen en zo interacties tussen objecten te organiseren.
Praktische voorbeelden waren onder andere slimme pickups die alleen kunnen worden opgepakt onder bepaalde voorwaarden en een interactieve deur die opent als de speler een sleutel heeft en dichtbij staat.
We combineerden kennis uit eerdere lessen: input uit Les 2.2, collision detection uit Les 4.2, en logica uit Les 5.1, en leerden patronen voor leesbare en onderhoudbare code.

<br>

# Link naar 5.1/5.1 scripts
https://github.com/Gamende-aap/M1SKILL---GitHub--les-5/blob/main/Assets/scripts/PlayerHealthSystem.cs
<br>
https://github.com/Gamende-aap/M1SKILL---GitHub--les-5/blob/main/Assets/scripts/PlayerLife.cs

<br>

# Wat Hebben We Gedaan – Les 6.1

<br>

We hebben geleerd hoe we lijsten (Lists) in C# kunnen gebruiken om meerdere items van hetzelfde type te beheren.
We ontdekten dat lijsten dynamisch zijn en makkelijk kunnen groeien of krimpen, in tegenstelling tot arrays die een vaste grootte hebben.
We hebben geleerd hoe je:

Een List<> aanmaakt en vult bij declaratie of via de Inspector
Items toevoegt met Add() en verwijdert met Remove() of RemoveAt()
Items invoegt op een specifieke positie met Insert()
Alle items uit een lijst verwijdert met Clear()
Door een lijst heen loopt met een for-loop of foreach-loop
Lijsten van GameObjects gebruikt voor bijvoorbeeld vijanden, collectibles of inventory
Het verschil tussen arrays en lijsten begrijpt en wanneer je welke gebruikt
Praktische voorbeelden waren onder andere een inventory systeem en een enemy manager waarbij vijanden werden gespaard, getoond en verwijderd uit de lijst en scene.
We hebben ook indexen behandeld en hoe je die gebruikt om specifieke items te benaderen.

<br>

<img width="712" height="842" alt="6_1_lists_inspector" src="https://github.com/user-attachments/assets/f36478ff-a952-4626-baa8-fbf768d6da21" />

<br>

# Wat Hebben We Gedaan – Les 6.2

<br>

We hebben geleerd hoe we for-, foreach-, while- en do-while-loops gebruiken om herhalingen en iteraties in Unity te maken.
We hebben gezien hoe nested loops (loops in loops) werken voor complexe structuren zoals grids en inventory systemen.

Daarnaast hebben we loop control statements zoals break en continue toegepast om het gedrag van loops te sturen en onnodige iteraties over te slaan.
We hebben ook aandacht besteed aan loop performance en optimalisatie, zoals het cachen van Count en GetComponent om efficiënter te werken bij grote lijsten van GameObjects.

Praktische voorbeelden waren onder andere: het verwerken van vijanden in een lijst, het doorlopen van een inventory grid, en het beheren van tower defense waves waarbij meerdere enemies automatisch worden gespawnd en gecontroleerd.
We combineerden kennis uit eerdere lessen en leerden patronen voor efficiënte, overzichtelijke en onderhoudbare code met loops.

<br>

# Link naar 6.1/6.2 scripts
https://github.com/Gamende-aap/M1SKILL---GitHub--les-5/blob/main/Assets/scripts/WalkCycle.cs
<br>
https://github.com/Gamende-aap/M1SKILL---GitHub--les-5/blob/main/Assets/scripts/RotateObject.cs
<br>
https://github.com/Gamende-aap/M1SKILL---GitHub--les-5/blob/main/Assets/scripts/RotateAround.cs

<br>  
<br>
<br>

----

<br>
<br>
<br>

<h1><b><strong>Module 2</strong></b></h1>

<br>
<br>
<br>

----

# Wat hebben we gedaan - les 1.1

<br>

we hebben geleerd hoe je een array handig kan gebruiken

<h2>demo:</h2>
<br>
<img width="403" height="566" alt="Schermafbeelding 2025-11-20 124019" src="https://github.com/user-attachments/assets/326127d6-f204-4880-9cf2-d7faee143d58" />
<br>
<br>

<h2>code:</h2>
<br>
<img width="1214" height="1292" alt="Schermafbeelding 2025-11-20 124149" src="https://github.com/user-attachments/assets/4db2f8c6-e795-45e5-b452-7dfa94079a36" />
<br>
<br>
<br>

----

<br>
<br>
<br>

# Pegel opdracht 1.2

<br>

we moeten een consept voor de pegel opdrach maken:

<br>
<br>
<br>

----

<br>
<br>
<br>

# Opdracht 2.2: Mikken, Shieten en Line Renderer

<br>

we moeten een wapen maken om te richeten en dingen te vuuren

<h2>demo</h2>
<br>
https://github.com/user-attachments/assets/4d228a97-18d7-41fa-9cd7-65f21d1065a8
<br>
<br>

<h2>Code</h2>
<br>
<img width="1256" height="1350" alt="Schermafbeelding 2025-12-01 153435" src="https://github.com/user-attachments/assets/4e2e8d69-5fac-4050-9646-971c62fe2a97" />
<br>
<img width="1343" height="1193" alt="Schermafbeelding 2025-12-01 153445" src="https://github.com/user-attachments/assets/71691d22-f9be-404f-9062-9c608be83bb6" />
<br>
<br>
<br>

----

<br>
<br>
<br>


# GD - M2 - GDV: Opdracht 3.1 Score & Triggers Opdracht

<br>

We moesten een Peggle die reageert wanneer de bal het object raakt maken, bijhoudt hoeveel hits er nog over zijn, punten doorgeeft aan de ScoreManager en verdwijnt zodra de ingestelde hoeveelheid hits is bereikt.

<br>

<h2>demo</h2>
<br>



Uploading Schermopname 2025-12-11 123558.mp4…



<br>
<br>

<h2>Code</h2>
<br>
<img width="1061" height="756" alt="Schermafbeelding 2025-12-11 123955" src="https://github.com/user-attachments/assets/d05c43c2-8783-4dcf-96cb-544a1228ece8" />

<br>
<br>
<br>

----




# GD - M2 - GDV: Opdracht 3.2: Bumpers en Combo System

<br>

we moesten bumpers maken voor de pegel game

<h2>demo</h2>
<br>


https://github.com/user-attachments/assets/0023b2b5-261f-4774-a64a-5fac8840fcf5


<br>
<br>

<h2>Code</h2>
<br>
<img width="1045" height="867" alt="Schermafbeelding 2025-12-01 152841" src="https://github.com/user-attachments/assets/395b2d4e-d980-4d95-8d95-fb9a2766880c" />

<br>
<br>
<br>

----

<br>
<br>
<br>

# GD - M2 - GDV: Les 4.1 – Week 4 Level Design & UI

<br>

We moesten een nieuw level maken voor onze Peggle game en een UI bouwen met een score, een eigen font en extra UI-elementen.  
De UI moest goed schalen op verschillende resoluties met anchors, Canvas Scaler en een 9-slice element.

<br>


<h2>Level</h2>
<br>

<img width="1852" height="855" alt="Schermafbeelding 2026-01-30 173621" src="https://github.com/user-attachments/assets/c5981967-890a-4721-a816-c6b278fd398b" />


<br>
<br>

<h2>UI</h2>
<br>


<img width="490" height="254" alt="Schermafbeelding 2026-01-30 173658" src="https://github.com/user-attachments/assets/b38b37e8-3533-4de7-8b6f-142b5b3b8d8a" />

<br>
<br>
<br>

----

<br>
<br>
<br>

# GD - M2 - GDV: Les 4.2 Scores versturen naar UI

<br>

We moesten ervoor zorgen dat de score en combo multiplier vanuit het spel naar de UI worden gestuurd.  
Daarnaast hebben we het aantal geschoten ballen bijgehouden en na 5 schoten het schieten uitgeschakeld.

<br>

<h2>Code</h2>
<br>

<img width="2198" height="1244" alt="Schermafbeelding 2026-01-30 173913" src="https://github.com/user-attachments/assets/05317e8e-d87a-4182-a9b2-ee0f9ff80a72" />


<br>

<h2>UI</h2>
<br>

<img width="490" height="254" alt="Schermafbeelding 2026-01-30 173658" src="https://github.com/user-attachments/assets/8448c884-5c1b-464e-9ade-310333f8a7eb" />

<br>
<br>
<br>

----

<br>
<br>
<br>

# GD - M2 - GDV: Les 5.2 Particles, Sounds & Screenshake

<br>

We moesten particles, geluiden en een screenshake toevoegen aan onze Peggle game.  
Wanneer de bal een bumper raakt worden particles afgespeeld, een geluid afgespeeld en het scherm schudt voor extra impact.

<br>

<h2>demo</h2>
<br>



https://github.com/user-attachments/assets/918bd6ce-a4aa-4fea-a85b-a5bdd1e0d95f



<br>
<br>

<h2>Code</h2>
<br>

<img width="930" height="985" alt="Schermafbeelding 2026-01-30 174341" src="https://github.com/user-attachments/assets/1b62f204-b558-438e-b26a-24bb44c325eb" />

<br>
<br>
<br>

----

<br>
<br>
<br>

# GD - M2 - GDV: Les 6 Afronden en uitbreiden

<br>

In deze les heb ik mijn Peggle game getest, de checklist bekeken en gewerkt aan het afronden van het spel.  
Daarna heb ik een nieuwe feature toegevoegd zonder bestaande onderdelen te breken.

<br>

<h2>Checklist</h2>
<br>

- Werkende Peggle game  
- Score en UI werken correct  
- Particles, geluid en screenshake werken  
- Geen vastlopers tijdens het spelen  

<br>

<h2>Planning</h2>
<br>

- Ontbrekende onderdelen afronden  
- Bugs oplossen  
- Nieuwe feature bedenken en bouwen  
- Game testen en build maken  

<br>

<h2>Nieuwe feature</h2>
<br>

Ik heb een nieuwe feature toegevoegd om het spel leuker en duidelijker te maken voor de speler.  
Deze feature werkt samen met de bestaande systemen en breekt niets in de game.

<br>

<h2>demo</h2>
<br>

![Bezig met opnemen 2026-01-30 174737](https://github.com/user-attachments/assets/77da495c-24cf-4690-a941-3296317faee1)


<br>
<br>

<h2>Build</h2>
<br>

De build van het spel staat onder **Releases** in deze repository.

<br>
<br>
<br>
