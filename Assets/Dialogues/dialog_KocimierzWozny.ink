INCLUDE Globals.ink
Co za syf! Znowu nabazgrane. Ile można?!
Niuch, niuch. Czy ja żem czuję kocimiętkę. Chuchnij no Woofciech!
+ [(jeśli masz kocimiętkę: Być może, zależy co z tego będę miał] --> KocimietkaKocimierz
*[Nie wytrzymam Panie Kocimierzu, może Pan mi pomoże?] --> NieWiemCzyWiesz

===KocimietkaKocimierz===
Dawaj towar i nie gadaj, mam dla Ciebie informacje, ale najpierw daj macha!
*[Sztachnie się Pan...] --> TurlanieKocimierz
*[No nie wiem...] --> TurlanieKocimierz

===TurlanieKocimierz===
Och, mrrrr. O tak, dobry towar. (turla się w kocimiętce, a potem patrzy na Ciebie powięksoznymi źrenicami)
*[Starczy, teraz gadaj.] --> KocimietkaSpecialInfo

===KocimietkaSpecialInfo===
(szeptem) Wierzaj mi lub nie chłopcze, ale dziwne rzeczy tu żem ostatnio widywał. Przyrzekłbym, żem słyszał głos Jeleńdrzeja w kabinie, o tam. (mruga)
A poza tym...
*[...] --> NieWiemCzyWiesz

===NieWiemCzyWiesz===
Nie wiem czy żeś wiesz, ale Jeleńdrzej - poprzedni dezajner, zostawił Ci coś.
*[Co? Co takiego?] --> GetDraft
*[Jeleńdrzej? Ten jeleń? Wielkie rzeczy, designer jednej gry] --> KocimierzDisgusted

===GetDraft===
Zostawił mi te notatki o yyy pyczu swojej nowej widełogry, weźże je proszę. I musiszżeś wiedzieć, że Jeleńdrzej nie został zwolniony... ZOSTAŁ ZABITY!
*[Nie do wiary! Dziękuję! Nie wiem jak się odwdzięczyć! Ale jak to zabity...?] --> GitGuduj
~DraftPitchuDesignera=true
===GitGuduj===
Postaraj się zachować porzadek. Wiesz, odkąd inwestorzy kazali zamknąć Was w biurze to ciągle ktoś tu syf robi. A to nabazgrze na lustrze, a to zrobi jeżyka na korytarzu, a to coś. Bądźże lepszy niż to.
*[Lepszy? Ale jak? To trudne...] --> GetGitGud
*[Żyjemy tu jak zwierzęta a Pan oczekuje od nas dbiania o porządek?] --> KocimierzWkurzon

===GetGitGud===
Nachylże się no, zdradzę Ci sekret. (szpecze i wciska Ci w dłoń buteleczkę) GIT GUD.
*[Um, dziękuję? Uszano...wanko?] --> ByeKocimierz
~GitGud=true

===ByeKocimierz===
Bywaj!
*[END]
->DONE

===KocimierzWkurzon===
Też mi coś. Wynocha, zarobiony żem jest!
*[END]
->DONE

===KocimierzDisgusted===
O nieee! Nie będziesz obrażał Metal Deer Solid! To arcydzieło! Wynośże się, mam mnóstwo roboty!
*[END]
->DONE
