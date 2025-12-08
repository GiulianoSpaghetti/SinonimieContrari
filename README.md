## Sinonimi e contrari

Come e farsi spiegare il readme da gemini: https://g.co/gemini/share/09062b7929d9 , basta loggarsi con l'account Google.

Il gioco dei sinonimi e dei contrari è un vecchio gioco che facevano i maestri (non i professori) per premiare i bambini più bravi
per cui quelli che oggi sembrano bug sono in realtà le regole del gioco, perché era possibile barare, a discrezione del maestro.

Un semplicissimo sistema per costruirsi un database per giocare a sinonimi e contrari.
Sono ammessi un massimo di 10 sinonimi e di 10 contrari a parola.

Tuttavia è possibile scrivere due volte la stessa parola e collegarla come sinonimo o contrario per avere 9+10 slot, basta che la parola sia
la stessa e che sia collegata direttamente, fa da ponte, quante volte si vuole.

## Come si utilizza

Seguite le istruzioni a video per organizzarvi il vostro database (attenzione: c'é il numero di parole, ma non il primo id e non viene eliminato automaticamente l'id del sinonimo o del contrario alla cancellazione della parola).
A questo punto basta che dite nel microfono "ciao ia, ti va di giocare?" e giocate, an che a programma chiuso.

## Dove funziona il database
Su qualsiasi sistema montante NPU che abbia il dotnet installato, anche android 16 o debian. Basta portarsi il database, che può essere letto coi driver sqlite.

TRamite Copilot (il sucessoe di chatgpt) ho ottenuto un diagramma che mostra come il otnet faccia da mente tra npu e database.

<img width="1024" height="1536" alt="1" src="https://github.com/user-attachments/assets/814f40cc-2fd5-49ff-beaf-4b495e39a642" />


https://copilot.microsoft.com/shares/ycecKZnmwVhreoKjWzdWz (qui la conversazione, bisogna loggarsi per poter chattare con chatgpt)


## Bug noti
Se si elimina una parola, la gestione dei collegamenti è manuale, ma questi sono i requisiti.

Non è possibile avere la lista di tutte le parole inserite, ma solo quante ce ne sono.

E' possibile inserire più volte lo stesso collegamento, tanto la IA lo ignora.

E' possibile inserire due volte la stessa parola, ma questo è utile per il cambio di semantica. Esempio: https://sapere.virgilio.it/parole/sinonimi-e-contrari/bianco se cliccate su "smorto" i sinonimi cambiano rispetto a "bianco" e vedrete che è aggiunto due volte lo stesso sinonimo: "pallido" col medesimo "peso" (portano alla stessa pagina).

E' possibile inserire la parola vuota ma la parola vuota è sinonimo o contrario di tutte le parole, così dicono i requisiti.

E' possibile inserire un collegamento alla medesima parola (un cappio nel grafo): è utile per fare gli scherzetti.

## Ispirazione per crearsi il database

https://www.listediparole.it/index.htm

https://sapere.virgilio.it/parole/sinonimi-e-contrari/divertente

## Donazioni

https://numerone.altervista.org/donazioni.php
