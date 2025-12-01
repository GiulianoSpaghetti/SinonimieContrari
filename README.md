## Sinonimi e contrari

Un semplicissimo sistema per costruirsi un database per giocare a sinonimi e contrari.
Sono ammessi un massimo di 10 sinonimi e di 10 contrari a parola.

## Come si utilizza

Seguite le istruzioni a video per organizzarvi il vostro database (attenzione: c'é il numero di parole, ma non il primo id e non viene eliminato automaticamente l'id del sinonimo o del contrario).
A questo punto col programma acceso basta che dite nel microfono "ciao ia, ti va di giocare?" e giocate.

## Dove funziona il database
Su qualsiasi sistema montante NPU che abbia il dotnet installato, anche android 16 o debian. Basta portarsi il database.

## Bug noti
Se si elimina una parola, la gestione dei collegamenti è manuale, ma questi sono i requisiti.

Non è possibile avere la lista di tutte le parole inserite, ma solo quante ce ne sono.

E' possibile inserire più volte lo stesso collegamento, tanto la IA lo ignora.

E' possibile inserire due volte la stessa parola, ma questo è utile per il cambio di semantica. Esempio: https://sapere.virgilio.it/parole/sinonimi-e-contrari/bianco se clicate su "smorto" i sinonimi cambiano rispetto a "bianco" e vedrete che è aggiunto due volte lo stesso sinonimo: "pallido" col medesimo "peso" (portano alla stessa pagina).

E' possibile inserire la parola vuota ma la parola vuota è sinonimo o contrario di tutte le parole, così dicono i requisiti.

E' possibile inserire un collegamento alla medesima parola (un cappio nel grafo): è utile per fare gli scherzetti.

## Ispirazione per crearsi il database

https://www.listediparole.it/index.htm

https://sapere.virgilio.it/parole/sinonimi-e-contrari/divertente

## Donazioni

https://numerone.altervista.org/donazioni.php
