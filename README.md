# POP3
Le but du projet est de développer un Client POP3 en C# en mode graphique. <br>
Le projet n'ai pas fini.
___
## Commande POP3

| Commande | Fonction |
| :--: | :-- |
| USER *utilisateur* | Nom du compte de l’utilisateur |
| PASS *mot de passe*|Mot de passe |
| STAT |Donne le nombre de messages non lus et leur taille totale|
| RETR *n*|Récupère le message numéro n |
| DELE *n*|Supprime le message numéro |
| LAST |Donne le numéro du dernier message auquel on a accédé |
| LIST *[n]*|Taille de n-ème message ou de tous les messages |
| RSET |Annule la suppression de tous les messages |
| TOP *n* *k* |Affiche les entêtes et k lignes du message numéro n |
| NOOP |Ne fait rien |
| QUIT |Termine la session POP3 |
___
## Logiciel
Utilisation de Visual Studio pour du C#


## Author
Guillemin Laborde