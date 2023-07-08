# *Royal of Ur*

### **Autoria:** 

| **Nome** | **Número** |
| - | - |
| Guilherme Negrinho | 22207383 |

**Repositório Git:** [GitHub](https://github.com/bread-stealer/Royal_Of_Ur_Game)

---

### **Arquitetura da Solução:**
**Program.cs:**
- O programa solicita ao usuário que digite o nome do Jogador 1 e do Jogador 2;
- Um número de dado é gerado aleatoriamente usando a classe Random. Esse número representa a quantidade de espaços que cada jogador irá avançar;
- Cada jogador move sua posição de acordo com o número do dado usando o método Move da classe Player. O jogador 1 move primeiro e o jogador 2 move em seguida.
- O método DisplayBoard da classe GameBoard é chamado para exibir o tabuleiro atualizado com a posição dos jogadores.

**Board.cs:**
- O código define uma classe chamada GameBoard, que é responsável por exibir e atualizar o tabuleiro do jogo;
- A classe possui um campo estático board, que é uma matriz de caracteres que representa o layout do tabuleiro inicial;
- A classe possui um método estático chamado DisplayBoard, que exibe o tabuleiro no console. Ele aceita dois parâmetros;
- O tabuleiro atualizado é então exibido no console, percorrendo a matriz e imprimindo os caracteres.

**Player.cs:**
- O código define uma classe chamada Player, que representa um jogador no jogo;
- A classe possui duas propriedades públicas: Name e Position;
- A classe possui um construtor público que recebe um parâmetro name e inicializa a propriedade Name com o valor fornecido. A propriedade Position é inicializada com o valor 0, indicando que o jogador começa na posição inicial;
- A classe possui um método público chamado Move, que recebe um parâmetro diceNumber representando o número do dado lançado;
- Basicamente, define a estrutura básica de um jogador, armazenando seu nome e posição atual. Ele também fornece um método para atualizar a posição do jogador com base no número do dado lançado.

---

### **Fluxograma:**
![Fluxograma]("C:\Users\Gui\Desktop\LP1\Recurso_L1\LP_1.png")

### **Referências:**
 - [C# API](https://learn.microsoft.com/en-us/dotnet/api/?view=netstandard-2.0)
 - [Stack Overflow](https://stackoverflow.com/)
