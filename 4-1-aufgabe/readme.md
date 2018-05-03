# Array vs List

## Array

Array vom Typ T 
T hat den Speicherbedarf S 


## Liste

Liste vom Typ T 

| prev        | next          |
| ------------- |:-------------:|
| <--     | -->|

verweis 

s = T 	


```mermaid
graph TD;
    Find-->search:T;
    search:T-->found[found List <-node->];
    found-->Child[in Child Find : search];
    Child-->No/Yes
    No/Yes-->Yes;
    Yes-->Content[Content = Search];
    Content-->List[this in List];
    No/Yes-->No;
    No-->Liste[return List];
    List-->Liste
```