INCLUDE Globals.ink
Mrrrr whyyyyy?!
*[Uszanowanko!] --> Powitanie

===Powitanie===
Nie! Nie będę robił mechaniki nurkowania w lawie!
*[Przecież ta mechanika jest kluczowa dla zdobywania zasobów, z których budujemy elementy kosmetyczne!] --> Rezygnacja
*[Nie ma na to czasu, musimy najpierw naprawić chodzenie.] --> Crunch
*[Kocimiętki się najadłeś?! Ja nie w tej sprawie...] --> DoRzeczy

===Rezygnacja===
Dobra, powiedz PMowi, że będzie to MIAU na jutro...
*[Skoro i tak jesteś zajęty... Będziesz jadł ta kanapkę?] --> Kanapka

===Crunch===
Nawet mi nie przypominaj! Nie mam czasu na rozmowy!
*[Ja tylko chciałem spytać o Twoją kanapkę...] --> Kanapka

===DoRzeczy===
Kocimiętka? Mam tu gdzieś działkę, chesz się poturlać?
*[Miaucin, skup się! Mój najnowszy design wymaga, żebym zjadł Twoją kanapkę!] --> Kanapka

===Kanapka===
Mrr, ta kanapka MAIUA dziwny smak. Na pewno ją chcesz? Moge Ci dać kocimiętki.
*[Żartujesz? Odkąd Szef zamknął biuro nic nie jadłem. Dawaj tą kanapkę!] --> KanapkaEnding
*[Dziwny smak? Wszystko jedno, nie zamierzam jej jeść, zamierzam ZROBIĆ GRĘ!] --> KanapkaEnding
*[Daj tą kocimiętkę. Tylko szybko, póki nikt nie patrzy] --> KocimietkaEnding

===KanapkaEnding===
Bierz... Ja muszę najpierw dorwać ten cholerny kursor.
~idiotSandwich=true
*END
->DONE
===KocimietkaEnding===
Sztachnij się Pieseł, czujesz ten zapach? O taaaak (tarza się w kocimiętce).
~kocimietka=true
*END
->DONE

