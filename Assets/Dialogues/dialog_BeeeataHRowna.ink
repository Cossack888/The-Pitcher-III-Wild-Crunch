INCLUDE Globals.ink
Podwyżek nie bęęędzie dopóki nie ukończycie projektu! Tak powiedział Łuuuka-a-a-asz!
*[Uszanowanko! A mówił czy będzie jakaś niedziela wolna?] --> NerwowaBeeeata
*[Beeeata, po co tak z kopyta? Mam do Ciebie inna sprawę...] --> NerwowaBeeeata

===NerwowaBeeeata===
Da-aj spokój! Za du-użo już widziałam beee. Faktury się nie zgadzają, urwane palce walają mi się po biurku. (zakłopotana Beeeata zakrywa te makabryczne widoki potwierzdzeniem zakupu proszku do wywabiania plam krwi parzystokopytnych i z nerwów zjada ołówek).
*[A może... dasz mi te kłopotliwe rzeczy? Mi się przydadzą...] --> GetPalecAndFakture
*[Beeeata, co się dzieje? Potrzebujesz pomocy?] --> CryBeeeataCry
*[Beeeata, ale przecież kozy mówa "Meee",  anie "Beee"...] --> AngryBeeeata

===CryBeeeataCry===
Ja nie-e wieee-eeem buhuhu-beeee (rozkleja się zupełnie i szlocha). Łuuukasz się zmie-eeenił. Jest teraz taką alfą beeehuhu...
*[Przykro mi, czy jak zabiorę te rzeczy to będzie Ci łatwiej?] --> GetPalecAndFakture

===GetPalecAndFakture===
Tak! Zabierz mi sprzed beee oczu te abeee-ominacje!
*[Palec umarlaka i faktura in minus... To chyba STRATA] --> ByeByeBeeeata
~PalecUmarlaka=true
~StrataFaktura=true

===ByeByeBeeeata===
Dzię-ęęękuję Woofciech, dobry z Ciebie piesełe.
*[Uszanowanko Beeecia.] --> UszanowankoBeeeata

===UszanowankoBeeeata===
*[END]
->DONE

===AngryBeeeata===
Beee, Ty beeeztalencie beeeznadziejne! Znikaj mi z beee-oczu albo Ci kwotę beee-rutto zmienię na umowie na zlecenie!
*[END]
->DONE
