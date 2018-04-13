## Übungsaufgabe

Betrachtet die Source-Code-Dateien 
[FamilyTree.cs](FamilyTree.cs) und 
[Program.cs](Program.cs). In Familytree wird eine Datenstruktur aufgebaut,
die eine Art Familienstammbaum repräsentiert (Ähnlichkeiten mit realen Personen sind rein zufällig :-)).


Macht euch klar, dass die Datenstruktur `Person` rekursiv ist, denn jedes Objekt vom Typ `Person` referenziert
zwei weitere Objekte vom Typ `Person`, nämlich `Mom` und `Dad`.

> ## Antwort
> Die Funktion `public static Person Find(Person person)` ruft sich immer wieder selbstständig auf bis die Funktion `null` zurückliefert.

Die Methdode `BuildTree()` baut einen Beispiel-Baum auf. Setzt einen Breakpoint in [Zeile 19 von Program.cs](Program.cs#L19),
startet den Debugger und seht Euch den Inhalt von `root` im Debugger an. 

> ## Antwort:
>
> Jüngste Person im Stammbaum ist Willi Cambridge.
>
> Die Eltern von Willi Cambridge sind 
>
> |     Mom       |     Dad       |
> | ------------- |:-------------:|
> | Diana Spancer     | Charlie Wales |


> Die Eltern von Diana Spancer:
>
> |     Mom       |     Dad       |
> | ------------- |:-------------:|
> | Franzi Roche  | Edie Spencer  |

> Die Eltern von Franzi Roche:
>
> |     Mom       |     Dad       |
> | ------------- |:-------------:|
> | Ruth Gill     | Moritz Roche  |

> Die Eltern von Edie Spencer:
>
> |     Mom       |     Dad       |
> | ------------- |:-------------:|
> | Cynthia Hamilton  | Albert Spencer  |

> Die Eltern von Charlie Wales:
>
> |     Mom       |     Dad       |
> | ------------- |:-------------:|
> | Else Windsor  | Philipp Battenberg  |

> Die Eltern von Philip Battenberg:
>
> |     Mom       |     Dad       |
> | ------------- |:-------------:|
> | Alice Battenberg | Andi ElGreco  |

> Die Eltern von Else Windsor :
>
> |     Mom       |     Dad       |
> | ------------- |:-------------:|
> | Lisbeth Bowes-Lyon | Schorsch-Albert York  |

> Der Stammbaum hört bei Null auf.
> Bei der Abfrage der einzelnen Personen, wird immer weiter in den Stammbaum durchwandert, bis die letzte Person ausgegeben wurde


Die Methode `Find()` durchläuft rekursiv den Baum und prüft alle `Person`-Objekte darauf, ob die Bedingung in 
[Zeile 22](FamilyTree.cs#L22) gegeben ist. Die erste `Person`, die die Bedingung erfüllt, wird zurückgeliefert.

Ändert die Bedingung so, dass nicht gleich die erste Person ("Willi") zurückgegeben wird. Eventuell gibt es Abstürze.
Analysiert die Abstürze mit dem Debugger, überprüft Variableninhalte und den Call-Stack.

> ## Antwort
>
>```C#
>if (person.LastName != "Cambridge" && person.LastName !=  "Spencer")
>```
> Wenn man diese if-Bedienung durchläuft, ist die erste Person die zurück gegeben wird `Franzi Roche`.
>
> Wenn man die if Abfrage so umschreibt:
>
> `if (person.LastName == "Battenberg")`
>
> wirft die if-Bedienung eine `'System.NullReferenceException'`, da der Stammbaum Rekursive durchwandert wird um zu überprüfen ob die Person `"Battenberg"` vorhanden ist.
> Dies ist nicht der Fall da die Person Battenberg in dem Mütterlichen Stammbaum nicht vorhanden ist, und das führt dann dabei zu einer NullReferenceException
>
> Wenn man nun in den Code diese if Abfrage hinzufügt, wird verhindert das es zu einer `'System.NullReferenceException'` kommt.
> ```C#
> if(person.Mom != null)
>   ret = Find(person.Mom);
> if(person.Dad != null)
>   ret = Find(person.Dad);
>  return ret;
>```



Schreibt komplexere Bedingungen, findet z.B. die erste Person, die in einer Altersspanne liegt, verleicht dazu, person.DateOfBirth.Year
mit DateTime.Now.Year. Analysiert mit dem Debugger, ob Eure Bedingung richtig ist. 

> ## Antwort
>
> ```C#
>   int age = DateTime.Now.Year - person.DateOfBirth.Year;
>       if(50 < age && age < 100)
>          return person;
>                
>           if(person.Mom != null)
>               ret = Find(person.Mom);
>           if (ret != null)
>               return ret;
>           if(person.Mom != null)
>               ret = Find(person.Dad);
>           return ret;
>```
>
> Wenn man nun diese if Abfrage im Code hinzufügt, kann man nun nach einer Gewissen Alterspanne Filtern.
>
> [Family Tree](https://github.com/benediktgrether/Softwaredesign-Praktikum/blob/master/2-1-aufgabe/FamilyTree.cs)





