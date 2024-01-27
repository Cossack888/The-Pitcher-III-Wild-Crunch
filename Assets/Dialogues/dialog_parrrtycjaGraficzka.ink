INCLUDE Globals.ink
Uuf, znowu poniedziałek. Ale mnie głowa rrrypie po tej weekendowe imprrrezie.
*[Poniedziałek? Parrrtycja, jest środa...] --> SrodaCzegoChcesz

===SrodaCzegoChcesz===
Śrrroda? ŚRRRODA?!
*[Tak, tak, ale teraz słuchaj. Potrzebuję pomocy bo mnie Szef zabije...] --> ZabijeNieNie

===ZabijeNieNie===
Zabije? Nie no co tyyy... Zwolni Cię najwyżej hehe. To by za bardzo namieszało w moim zen. Rrrety, ale mnie suszy.
*[Masz tu jakieś rzeczy, które mogę zabrać na pitch?] --> SukienkiWybor
*[Wof, nieuszanowanko, tak do roboty na kacu...] --> ObrazaParrrtycji
*[Ej, czemu Huhubert się na Ciebie dąsa?] --> OjojojWcaleNie

===OjojojWcaleNie===
Ojojoj, ar ar. Huhubert wierzy w jakieś kłamstwa. Twój poprzednik - Jeleńdrzej został zwolniony. ZWOLNIONY! ZWOLNIONY! Wcale nie konał w WC z rrrozszarrrpaną aorrrtą. Nienienienie. ZWOLNIONY!
*[O czym Ty gadasz?!] --> SukienkiWybor

===SukienkiWybor===
No, no. Chciałeś jakieś grrraty, którrrych nie używam? Możesz wziąć tą sukienkę. To znaczy sukienki. Którrrą wolisz?
*[Wezmę niebiesko-czarną sukienkę] --> GetNiebCzar
*[Wezmę biało-złotą sukienkę] --> GetBiaZlo
*[Wezmę obie. I tak wyglądają podobnie.] --> GetBoth

===GetNiebCzar===
Prrroszę barrrdzo.
*[Dzięki! Uszanowanko!] --> UszanowankoParrrtycji
~SukienkaCzarnoNiebieska=true

===GetBiaZlo===
Prrroszę, oj to nie ta, to ta drrruga. Są zbyt podobne hehe.
*[Dzięki! Uszanowanko!] --> UszanowankoParrrtycji
~SukienkaBialoZlota=true

===GetBoth===
Bierz i tańcz, pij, kochaj...! Arrr! Moja głowa!
*[Nie pij tyle Parrrti. Uszanowanko!] --> UszanowankoParrrtycji
~SukienkaBialoZlota=true
~SukienkaCzarnoNiebieska=true

===ObrazaParrrtycji===
A się Ciebie ktoś o coś kiedyś się pytał?! Wyprrraszam sobie, sio! SIO! NIEDOBRY PIESEŁ!
*[END]
->DONE

===UszanowankoParrrtycji===
Na rrrazie Woofciech!
*[END]
->DONE