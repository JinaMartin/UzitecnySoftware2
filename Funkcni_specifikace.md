# Chytrý seznam
## Martin Jína
### 31. 5. 2021
#### Verze 2

* Úvod
  * Účel
    * Program je pro kohokoli, kdo chce mít lepší přehled ve své domácnosti.
  * Pro koho je dokument určený
     * Dokument je určený pro uživatele, kteří chtějí podrobnější informace o programu.
  * Odkazy na ostatní dokumenty
     * https://github.com/JinaMartin/UzitecnySoftware/blob/master/Specifikace_pozadavku.md
* Scénáře
  * Všechny reálné způsoby použití
    * Nákupní eznam potravin, nebo jakýchkoli jiných předmětů. Nákupní seznam.
  * Typy uživatelských rolí, „personas“
    * V programu jsou dvě uživatelská role.
  * Detaily, motivace, „živé“ příklady  
    * Program vám uloží libovolný počet skupin s libovolným počtem předmětů, sami si je pojmenujete, přidáte, smažete, upravíte.
    * Program vám umožní libovolně vytvářet a upravovat váš nákupní košík.
  * Vymezení rozsahu
    * V softwaru nebude automatické vložení došlého zboží do nákupního seznamu.
  * Na co se nebude klást důraz
    * Důraz se nebude klást na grafickou část softwaru.
* Celková hrubá architektura
  * Pracocní tok
    * Program by měl být přehledný a funkční.
  * Hlavní moduly
    * První modul vám zobrazí celý váš nákupní seznam. Druhý modul vám umožní vytvořit, nebo upravit novou položku.
  * Detaily
    * Program se skládá ze dvou oken - nákupní seznam, vytvoření nové položky
  * Všechny možné toky programu a jejich projevy
    * Program při spuštění zkontroluje existenci složek s daty. Pokud neexistují tak je vytvoří, pokud existují tak je načte.
  * Všechny dohodnuté principy
* Otevřené otázky
  * Části, na kterých se zatím nedosáhlo shody
    * Program neumožňuje vytvoření nové skupiny položek.
  * Poznámky k realizaci    
