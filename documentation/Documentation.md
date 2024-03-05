# AVA Model Viewer

## Popis programu
AVA Model Editor (AMV) je SW řešení pro zobrazení modelů na platformě AVAplace. AVA platforma definuje datové modely, ale neposkytuje k němu vizuální reprezentaci těchto modelů. Jediný zdroj dat, kterým lze tyto modely vizualizovat je generovaná dokumentace. Editace modelů ve Virtuálním Datovém modelu (VDM) se provádí pomocí definičních souborů ve formátu JSON. Cílem AMV je poskytnou analytiků nástroj jak datové modely ve VDM vizualizovat a vytvářet definiční soubory, případně je posílat dále do API rozhraní AVA platformy.

V principu je AME soukromý, cvičný technologický STACT, pro Milana Křepelka. Zkouším si tady různé technologie jako:

- .NET Core
- DevOps
- Continuous Intigration
- GitHub
- Copilot
- React


### Vývojová platforma

###	Backend
.NET Core + vývojová platforma AVAplace

###	Frontend
Na frontendu bude použit React. Nicméně tato část je zatím nejistá. Nejsem frontendový vývojář a nevím, zda se mi podaří vytvořit něco použitelného. Možná se objeví jednodušší technologie která mě zaujme.

3	DevOps
-	veškeré buildy udržujeme ve firemním prostředí které budou mít tyto vlastnosti
o	automatické buildy
o	automatické testy
4	Analýza
Analýza je popisována z pohledu uživatele. Není zvlášť analyzován backend. 

4.1	Vnitřní funkčnosti
4.1.1	Datové úložiště
AME má dvě úložiště
-	Datovou službu (DS) viz. https://demo.avaplace.com/api/asol/ds/api/v1/DataModels
-	Vnitřní datové úložiště, které je potřeba udržovat taktéž co nejjednodušší. Například DS neudržuje který model patří do jaké domény. Domény neudržuje vůbec. 
V takovém případě vnitřní datové úložiště funguje pouze jako slave a je potřeba vnitřní datové úložiště.
Je potřeba vůbec držet úložiště ve smyslu SQL databáze?	
-	Prozatím stačí udržovat in-memory persistenci s tím, že export bude do definičních souborů?
-	Pokud AVA platforma nabízí easy persistenci je možné použít ji
-	Je možné se vydat cestou embeded databáze
o	Klasika SQL Lite
o	Zajímavá alternativa https://www.litedb.org/
o	
Doménové objekty ( ve smyslu clean architecture)
-	Doména
o	Název domény (Anglicky / Česky)
o	Kód domény ( je to angl. zkrácenina, používá se v technických částech [názvy adresářů apod.])
-	Model
-	Atribut model
4.2	Případy užití

4.2.1	Přihlášení a odhlášení
Přihlášení i odhlášení je platformově závislé. Uživatel se bude přihlašovat/odhlašovat na platformě AVAplace a v AME budou platit jeho přihlašovací údaje
4.3	Po přihlášení
Po přihlášení analytik uvidí standardní AVAplace layout. 

 

4.4	Práce s doménovými objekty
4.4.1	Výběr domény
Hlavní UI rozhraní je levé menu. Uživatel klikne na doménu a zobrazí se mu všechny modely v doméně. 
4.4.2	Vytvoření domény
Vytvoření domény bude možné tlačítkem plus v přehledu domén.  
Omezení
-	Nejde vytvořit doménu s již existujícím názvem
-	Domény jsou v podstatě 
4.4.3	Editace domény
Editace domény je možná v nějakém UI, které není stanoveno. 
4.4.4	Smazání domény
Smazání domény prakticky nemá být možné. Respektive smazat doménu lze, pokud v ní není žádný model.  
4.4.5	Zobrazení modelů v doméně
4.4.6	Vytvoření modelu
Vytvoření modelu v UI by mělo být co nejvíce intuitivní. 
Omezení
-	Nejde vytvořit model se stejným jménem
-	Nejde vytvořit model se stejným Identifikátorem modelu
4.4.7	Editace modelu
Editace modelu má stejné UI jako vytvoření modelu. V principu vlastnosti vypublikovaného modelu měnit nejdou
Omezení 
-	Nejde změnit název modelu
-	Nejde změnit Identifikátor modelu
4.4.8	Smazání modelu
4.4.9	Omezení
