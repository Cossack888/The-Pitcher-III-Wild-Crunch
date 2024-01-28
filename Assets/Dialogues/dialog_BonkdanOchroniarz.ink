INCLUDE Globals.ink
(Bonkdan robi pompki, jego puszyste futro napręża się i faluje) Uff, 67, 68, i...Kto idzie?
*[(Zarumień się) To ja Bonkdanku, Woofciech.] --> ZmianaKoszulki

===ZmianaKoszulki===
(Bonkdan w milczeniu podnosi się, zdejmuje przepoconą koszulkę i daje Ci ją do przytrzymania kiedy zakłada świeżą)
*[(Otrzyj nią spocone czoło, zorientuj się i zakłopotany schowaj ją za plecy.)] --> BedePotrzebowalTejKoszulkiBonkdan
*[(Spróbuj odwrócić wzrok) O, czyżbyś sprawił sobie jamnika?] --> JamnikIntroduction

===BedePotrzebowalTejKoszulkiBonkdan===
Możesz mi oddać koszulkę? Będę jej potrzebował.
*[Haha tak, całkowicie zamierzałem Ci ją oddac, ani trochę nie chciałem jej zatrzymać i wąchać przy biurku.] --> SprawyDoBonkdana
*[Koszulkę, ja-jaką koszulkę? Słuchaj, mam sprawę...] --> SprawyDoBonkdana

===SprawyDoBonkdana===
Hm?
*[Mam za kilka minut preznetację u Szefa...Mógłbys mi jakoś pomóć? Jesteś taki... pewny siebie (zarumień się)] --> PomocBonkdana
*[Chciałbyś wyskoczyć na kawę do kuchni za kwadrans? Tylko my dwaj...] --> KawaChetnie
*[Może wypuściłbyśmnie Bonkdanku, na minutkę chociaż?] --> NieMaWychodzenia
*[Chciałem tylko popatrzeć, to znaczy dotknąć, to znaczy yyy haha?] --> FirstHornyStep

===KawaChetnie===
Będzie mi miło Woofciu. (Bonkdan kładzie Ci swoją mocarną dłoń na ramieniu, ale niezwykle delikatnie)
*[Oooooch, to jesteśmy umówieni (mrugnij figlarnie)] --> SprawyDoBonkdana

===NieMaWychodzenia===
Wykluczone Woofciu, Szefu zabronił kogokoliwek wypuszczać. Wiem, że klimatyzacja zepsuła się dwa tygodnie temu i nie byłeś w domu od miesiąca, ale... Nie chcę stracić tej roboty, rozumiesz? Dopiero zacząłem wychodzić na prostą...
*[Nie szkodzi, Bonkdanku^^] --> SprawyDoBonkdana

===PomocBonkdana===
Jasna sprawa, wiesz że zawsze możesz na mnie liczyć Woofciu. Może jamnik Ci się przyda?
*[Ja-jamnik? C-co masz na myśli (onienie nie daj znać po sobie co TY MASZ NA MYŚLI)] --> JamnikIntroduction
*[Rozumiem, jamnik (mrugnij i porozumiewawczo trąć łokciem Bonkdana)] --> FirstHornyStep

===FirstHornyStep===
(zakłopotany) Ja... wiesz że nie jestem gotowy na to, ale lubię Cię. Nawet bardzo.
*[Jasne, wybacz. Będę leciał bo Szef mnie zabije. Do zobaczonka Bonkciu] --> ZanimPojdzieszBonkdan
*[Ja też Cię lubię i Twoją wielką, twardą...] --> BONK 

===BONK===
BONK! Go to horny Jail.
*[END]
->DONE

===ZanimPojdzieszBonkdan===
Ekhm, zanim pójdziesz. Ja... mam coś dla Ciebie. (rumieni się)
*[Dla mnie? To... urocze Bonkdanku, dziękuję] --> GetSamolot
*[Mówisz o tej wielkiej i twardej...] -->BONK

===GetSamolot===
Sam go budowałem (kiedy bierzesz z dłoni Bonkdana śliczny model samolotu Wasze dłonie na sekundę się spotykają, tak jak Wasze oczy. Zakłopotani zerkacie w podłogę, a potem znowu na siebie. to było...miłe.)
*[Dziękuję Bonkdanku, musze już lecieć. Uszanowanko;)] --> ByeBonkdan
~SamolotModel=true

===JamnikIntroduction===
Taaak, mam jamnika. Myślałem, że będzie śmieszniejszy. Chcesz go przygarnąć?
*[Jasne, jasne, przyda mi się... To znaczyyy zadbam o niego haha.] --> GetJamnik

===GetJamnik===
To bierz go, ma na imię Parówa, ale reaguje też na Kabanos.
*[Dzięki, musze już iść] --> ZanimPojdzieszBonkdan
~Jamnik=true

===ByeBonkdan===
Trzymaj się Woofciu, mam nadzieję, że szybko się zoabczymy.
*[END]
->DONE
